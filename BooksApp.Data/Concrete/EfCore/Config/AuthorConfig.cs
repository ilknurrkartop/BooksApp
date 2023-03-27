using BooksApp.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BooksApp.Data.Concrete.EfCore.Config
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();
            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);

            builder.Property(x => x.BirthDate).IsRequired();

            builder.Property(x => x.Gender).IsRequired();

            builder.HasData(
                new Author { Id = 1, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Andreas König", Gender = "E", Url = "andreas-konig" },
                new Author { Id = 2, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Monica Murphy", Gender = "E", Url = "monica-murphy" },
                new Author { Id = 3, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Prof. Dr. M. Hakan Türkçapar", Gender = "E", Url = "hakan-türkcapar" },
                new Author { Id = 4, CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsApproved = true, Name = "Mary Wollstonecraft", Gender = "E", Url = "mary-wollstonecraft" }
            );
        }
    }
}