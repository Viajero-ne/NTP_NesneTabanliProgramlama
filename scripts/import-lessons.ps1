# Script to import lesson folders into repo branches and merge to master
Set-StrictMode -Off
$ErrorActionPreference = 'Stop'
$repo = (Get-Location).Path
$old = Join-Path $repo 'old'
$searchRoots = @()
if (Test-Path $old) { $searchRoots += $old }
$searchRoots += 'C:\Users\almac\OneDrive\Masaüstü'
Write-Host "Search roots: $searchRoots"
$dirs = @()
foreach ($r in $searchRoots) {
    if (-not (Test-Path $r)) { continue }
    try {
        $found = Get-ChildItem -Path $r -Directory -Recurse -Force -ErrorAction SilentlyContinue | Where-Object { $_.Name -like 'Ntp_NesneTabanliProgramlama2-Ders*' }
    } catch {
        $found = @()
    }
    foreach ($f in $found) { $dirs += $f.FullName }
}
if (-not $dirs) { Write-Host 'No lesson folders found in search paths.'; exit 0 }
$pattern = 'Ders(\d+)'
$unique = $dirs | Sort-Object -Unique
$sorted = $unique | Sort-Object {[int](([regex]::Match($_,$pattern)).Groups[1].Value)}
foreach ($d in $sorted) {
    $m = [regex]::Match($d,$pattern)
    if (-not $m.Success) { continue }
    $num = $m.Groups[1].Value
    $branch = "ders$($num)"
    Write-Host "\n--- Processing $d -> branch $branch ---"
    # ensure master is up-to-date
    git checkout master
    git pull origin master
    # delete local branch if exists
    if (git rev-parse --verify $branch 2>$null) { git branch -D $branch }
    git checkout -b $branch

    # Determine source path: if there's a child folder with same leaf name, use it
    $leaf = Split-Path $d -Leaf
    $candidate = Join-Path $d $leaf
    if (Test-Path $candidate) { $src = $candidate } else { $src = $d }
    Write-Host "Using source: $src"

    # Copy files into repo root (overwrite). Exclude .git, .vs, node_modules and not overwrite .gitignore/.gitattributes
    $robocopyExclude = @('.git','.vs','node_modules')
    $excludeDirs = $robocopyExclude | ForEach-Object { "/XD `"$($_)`"" } | Out-String
    $excludeFiles = '/XF ".gitignore" ".gitattributes"'

    # Run robocopy
    Write-Host "Robocopy from $src to $repo"
    robocopy "$src" "$repo" /E /COPY:DAT /R:2 /W:1 /NFL /NDL /NJH /NJS $excludeFiles /XD ".git" ".vs" "node_modules" | Out-Null

    # Git add/commit/push
    git add -A
    $commitMsg = "Add files from $branch"
    $commitResult = & git commit -m $commitMsg 2>&1
    if ($LASTEXITCODE -eq 0) { Write-Host "Committed: $commitMsg" } else { Write-Host "Nothing to commit or commit failed: $commitResult" }

    git push -u origin $branch

    # Merge into master locally and push
    git checkout master
    git merge --no-ff $branch -m "Merge $branch"
    git push origin master

    Write-Host "Finished $branch"
    Start-Sleep -Seconds 1
}
Write-Host '\nAll done.'
