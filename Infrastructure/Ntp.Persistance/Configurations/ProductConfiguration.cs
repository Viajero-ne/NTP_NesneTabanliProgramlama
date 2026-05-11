using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ntp.Domain.Entities;

namespace Ntp.Persistance.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        Product product1 = new()
        {
            Id = 1,
            Name = "Asus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar",
            Description = "Asus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\nAsus TUF Gaming FX607VU-RL017 Intel Core 5 210H 16GB 512GB SSD RTX4050 Freedos 16\" Taşınabilir Bilgisayar\r\n",
            Price = 43899,
            IsDeleted = false
        };
        Product product2 = new()
        {
            Id = 2,
            Name = "Lenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\n",
            Description = "Lenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOSLenovo Thınkbook 16 21CY006FTR I5-1235U 8gb 512GB SSD 16\" Fdos\r\nLENOVO THINKBOOK 16 21CY006FTR i5-1235U 8GB 512GB SSD 16\" FDOS",
            Price = 35000,
            IsDeleted = false
        };
        Product product3 = new()
        {
            Id = 3,
            Name = "Kapüşonlu Polar Welsoft Peluş Hırka",
            Description = "GENEL ÖZELLİKLER Boy: 70 cm Kol Boyu: 62 cm Desen: Düz Renk Kumaş.; Wellsoft Ek Özellik: Kapüşonlu “Ürünümüz wellsoft kumaştan üretilmiştir. Kumaşın doğası gereği ilk kullanımda hafif tüy bırakabilir, ancak bu durum ilk yıkamadan sonra tamamen ortadan kalkar. Bu, kumaşın özelliğinden kaynaklıdır ve ürünün kalitesine olumsuz bir etkisi yoktur.” YIKAMA ÖZELLİKLERİ - Maksimum 30 derecede yıkayınız.; - Yüksek ısıda ütü yapmayınız.; - Ağartıcı ve kimyasal madde kullanmayınız.; - Kurutma makinesine atmayınız.; KUMAŞ ÖZELLİKLERİ - Rahat ve yumuşak dokusu ile ön plana çıkan welsoft kumaşlar, tamamen polyesterden üretilmiş olan kumaş türleridir.; - Welsoft kumaş pek çok farklı özelliği ile günümüzde sağlık açısından büyük öneme sahip kumaş türlerinden biridir.; - özelliğe sahiptir.; - Alerji ve ile gibi durumlarda çocuklar ve yetişkinler için kullanılır.",

            Price = 470,
            IsDeleted = false
        };
        Product product4 = new()
        {
            Id = 4,
            Name = "Yaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket",
            Description = "Yaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç CeketYaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç CeketYaman Market Kadın Uzun Kollu Önü Açık Desenli Şardonlu Dalgıç Ceket\r\nKadın Uzun Kollu önü Açık Desenli şardonlu Dalgıç Ceket",

            Price = 1000,
            IsDeleted = false
        };
        Product product5 = new()
        {
            Id = 5,
            Name = "Asus deleted",
            Description = "Asus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deletedAsus deleted",
            Price = 10000,
            IsDeleted = true
        };
        builder.HasData(product1, product2, product3, product4, product5);
    }
}