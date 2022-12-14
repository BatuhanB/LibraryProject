namespace Library.Service.Features.Books.Dtos
{
    public class CreatedBookDto
    {
        public Guid Id { get; set; }
        public string  Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime PublishDate { get; set; }
        public string BookImage { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid PublisherId { get; set; }
    }
}
