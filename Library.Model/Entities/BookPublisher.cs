using Library.Model.BaseEntity;

namespace Library.Model.Entities
{
    public class BookPublisher : IEntity
    {
        public Guid BookId { get; set; }
        public Book Book { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        public BookPublisher(Guid bookId, Book book, Guid publisherId, Publisher publisher)
        {
            BookId = bookId;
            Book = book;
            PublisherId = publisherId;
            Publisher = publisher;
        }
        public BookPublisher() { }
    }
}
