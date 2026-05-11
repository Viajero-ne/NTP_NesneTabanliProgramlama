using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntp.Domain.Entities;

namespace Ntp.Persistance.Configurations;

public class DetailConfiguration : IEntityTypeConfiguration<Detail>
{
    public void Configure(EntityTypeBuilder<Detail> builder)
    {
        Detail detail1 = new() { Id = 1, Title = "Cat3DetailTitle1", Description = "Cat3DetailDescription1", CategoryId = 3, IsDeleted = false };
        Detail detail2 = new() { Id = 2, Title = "Cat3DetailTitle2", Description = "Cat3DetailDescription2", CategoryId = 3, IsDeleted = false };
        Detail detail3 = new() { Id = 3, Title = "Cat4DetailTitle1", Description = "Cat4DetailDescription1", CategoryId = 4, IsDeleted = false };
        Detail detail4 = new() { Id = 4, Title = "Cat4DetailTitle2", Description = "Cat4DetailDescription2", CategoryId = 4, IsDeleted = true };
        Detail detail5 = new() { Id = 5, Title = "Cat4DetailTitle3", Description = "Cat4DetailDescription3", CategoryId = 4, IsDeleted = false };

        builder.HasData(detail1, detail2, detail3, detail4, detail5);
    }
}