using Library.Model.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Data.Configurations
{
    public class BookPublisherConfiguration : IEntityTypeConfiguration<BookPublisher>
    {
        public void Configure(EntityTypeBuilder<BookPublisher> builder)
        {
            builder.ToTable("BookPublishers");
            builder.HasKey(x=> new {x.PublisherId,x.BookId});
            builder.HasOne(x=>x.Publisher)
                .WithMany(x=>x.BookPublishers)
                .HasForeignKey(x=>x.PublisherId);
            builder.HasOne(x=>x.Book)
                .WithMany(x=>x.BookPublishers)
                .HasForeignKey(x=>x.BookId);
        }
    }
}
