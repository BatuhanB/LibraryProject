using Library.Model.BaseEntity;

namespace Library.Model.Entities
{
    public class Category:IEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public Category() { }
    }
}
