using Microsoft.EntityFrameworkCore;
using Ntp.Domain.Entities;
using System.Reflection;

namespace Ntp.Persistance.Context;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {

    }

    public AppDbContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Detail> Details { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}