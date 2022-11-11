using Library.Core.Entities;

namespace Library.Model.Entities
{
    public class Author : Entity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public Guid AdressId { get; set; } 
        public virtual Adress Adress { get; set; }

        public Author() { }

        public Author(string firstname, string lastname, int age,
                    ICollection<Book> books, Adress adress, Guid adressId)
        {
            Firstname = firstname;
            Lastname = lastname;
            Books = books;
            Adress = adress;
            Age = age;
            AdressId = adressId;
        }
    }
}
