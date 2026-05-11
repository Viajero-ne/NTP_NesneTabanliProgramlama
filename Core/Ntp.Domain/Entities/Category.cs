using Ntp.Domain.Common;

namespace Ntp.Domain.Entities;

public class Category : EntityBase
{
    public Category()
    {

    }

    public Category(string name, int subCategoryId, int sort)
    {
        Name = name;
        SubCategoryId = subCategoryId;
        Sort = sort;
    }

    public required string Name { get; set; }
    public required int SubCategoryId { get; set; }
    public required int Sort { get; set; }


    public virtual ICollection<Detail> Details { get; set; }
    public ICollection<Product> Products { get; set; }

}