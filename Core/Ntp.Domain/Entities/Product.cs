using Ntp.Domain.Common;

namespace Ntp.Domain.Entities;

public class Product : EntityBase
{
    public Product()
    {

    }

    public Product(string name, int price, string description)
    {
        name = Name;
        price = Price;
        description = Description;
    }
    public required string Name { get; set; }
    public required int Price { get; set; }
    //public string ImageUrl { get; set; }
    public required string Description { get; set; }
    public ICollection<Category> Categories { get; set; }
}
