using Library.Core.Entities;

namespace Library.Model.Entities
{
    public class Category : Entity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Category() { }
    }
}
