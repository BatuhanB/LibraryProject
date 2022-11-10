using Library.Model.BaseEntity;

namespace Library.Model.Entities
{
    public class Publisher:IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid AdressId { get; set; }
        public virtual Adress Adress { get; set; }
        public virtual ICollection<BookPublisher> BookPublishers{ get; set; }
        public Publisher() { }

        public Publisher(string name, string description,
            Adress adress, Guid adressId,
            ICollection<BookPublisher> bookPublishers)
        {
            Name = name;
            Description = description;
            Adress = adress;
            AdressId = adressId;
            BookPublishers = bookPublishers;
        }
    }
}
