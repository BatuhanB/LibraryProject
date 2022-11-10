using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Books");
            builder.HasKey(x => x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.BookImage).IsRequired().HasMaxLength(255);
            builder.HasOne(x=>x.Author).WithMany(x=>x.Books).HasForeignKey(x=>x.AuthorId);
            builder.HasOne(x=>x.Category).WithMany(x=>x.Books).HasForeignKey(x=>x.CategoryId);
        }
    }
}
