using BooksApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksApp.Data.Concrete.EfCore.Config
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(100);

            builder.Property(x => x.Stock).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.PageCount).IsRequired();

            builder.Property(x => x.EditionYear).IsRequired();

            builder.Property(x => x.EditionNumber).IsRequired();

            builder.HasData(
               new Book { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Tarçın'ın Kaybolan Havuçları", Stock = 10, Price = 20, PageCount = 32, EditionYear = 2023, EditionNumber = 1, Url = "tarcinin-kaybolan-havuclari" },
               new Book { Id = 2, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Bir Milyon Öpücük", Stock = 10, Price = 62, PageCount = 496, EditionYear = 2023, EditionNumber = 1, Url = "bir-milyon-opucuk" },
               new Book { Id = 3, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Bilişsel Davranışçı Terapi: Temel İlkeler ve Uygulama", Stock = 10, Price = 107, PageCount = 416, EditionYear = 2018, EditionNumber = 1, Url = "bilissel-davranisci-terapi-temel-ilkeler-ve-uygulama" },
                new Book { Id = 4, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Kadın Haklarının Gerekçelendirilmesi", Stock = 10, Price = 7, PageCount = 160, EditionYear = 2019, EditionNumber = 1, Url = "kadin-haklarinin-gerekcelendirilmesi" }
            );
        }
    }
}