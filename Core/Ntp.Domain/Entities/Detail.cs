using Ntp.Domain.Common;

namespace Ntp.Domain.Entities;

public class Detail : EntityBase
{
    public Detail()
    {

    }

    public Detail(string title, string value, int categoryId)
    {
        title = Title;
        value = Description;
        categoryId = CategoryId;
    }

    public required string Title { get; set; }
    public required string Description { get; set; }
    public required int CategoryId { get; set; }
    public Category Category { get; set; }
}
