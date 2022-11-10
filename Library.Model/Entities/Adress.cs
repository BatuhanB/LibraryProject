using Library.Model.BaseEntity;

namespace Library.Model.Entities
{
    public class Adress:IEntity
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }

        public Adress() { }

        public Adress(string country, string city,
                      string phone)
        {
            Country = country;
            City = city;
            Phone = phone;
        }
    }
}
