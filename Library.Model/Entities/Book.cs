using Library.Core.Entities;

namespace Library.Model.Entities
{
    public class Book : Entity
    {
        public string  Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookImage { get; set; }
        public Guid AuthorId { get; set; }
        public virtual Author Author { get; set; }
        public virtual ICollection<BookPublisher> BookPublishers{ get; set; }
        public Guid CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public Book() { }

        public Book(string name, string title,
            string description, DateTime publishDate,
            string bookImage, Author author,
            Category category, Guid categoryId,
            Guid authorId, ICollection<BookPublisher> bookPublishers)
        {
            Name = name;
            Title = title;
            Description = description;
            PublishDate = publishDate;
            BookImage = bookImage;
            Author = author;
            Category = category;
            CategoryId = categoryId;
            AuthorId = authorId;
            BookPublishers = bookPublishers;
        }
    }
}
