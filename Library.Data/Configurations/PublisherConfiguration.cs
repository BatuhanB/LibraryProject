using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations
{
    public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.ToTable("Publishers");
            builder.HasKey(x => x.Id);  
            builder.Property(x=>x.Id).ValueGeneratedOnAdd();
            builder.Property(x=>x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x=>x.Description).IsRequired().HasMaxLength(100);
            builder.HasOne(x=>x.Adress);
        }
    }
}
