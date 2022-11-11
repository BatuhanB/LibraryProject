using Library.Core.Entities;

namespace Library.Model.Entities
{
    public class Adress:Entity
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
