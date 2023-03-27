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
                new Book { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Zorbalığa Karşı Taktiklerim Var", Stock = 10, Price = 64, PageCount = 32, EditionYear = 2023, EditionNumber = 1, Url="zorbaliga-karsi-taktiklerim-var"}, 

                new Book { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Bronz Kutulu", Stock = 10, Price = 92,95, PageCount = 448, EditionYear = 2023, EditionNumber = 2, Url="bronz-kutulu" },

                new Book { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Atomik Alışkanlıklar", Stock = 10, Price = 74,25, PageCount = 352, EditionYear = 2020, EditionNumber = 1, Url="atomik-aliskanliklar" },

                new Book { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Dakikalar İçinde Atatürk ve Dünyası", Stock = 10, Price = 31, PageCount = 416, EditionYear = 2023, EditionNumber = 1, Url="dakikalar-icinde-ataturk-ve-dunyasi" },
            );
        }
    }
}