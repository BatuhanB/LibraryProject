using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Authors");
            builder.HasKey(x=> x.Id);
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Firstname).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Lastname).IsRequired().HasMaxLength(100);
            builder.Property(x=>x.Age).IsRequired().HasMaxLength(3);
            builder.HasOne(x => x.Adress);
            builder.HasMany(x=>x.Books).WithOne();
        }
    }
}
