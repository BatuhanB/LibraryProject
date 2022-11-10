using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations
{
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.ToTable("Adresses");
            builder.HasKey(x => x.Id);  
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.City).IsRequired().HasMaxLength(30);
            builder.Property(x=>x.Country).IsRequired().HasMaxLength(30);
            builder.Property(x=>x.Phone).IsRequired().HasMaxLength(13);
        }
    }
}
