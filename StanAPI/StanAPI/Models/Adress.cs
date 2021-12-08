using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class Adress
    {
        [Key]
        public int AdressId { get; set; }

        public string City { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public int PostNumber { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
    }
}
