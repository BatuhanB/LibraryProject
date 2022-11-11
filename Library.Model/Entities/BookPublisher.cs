using Library.Core.Entities;

namespace Library.Model.Entities
{
    public class BookPublisher : Entity
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
