using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class Apartment
    {
        [Key]
        public int ApId { get; set; }

        public int Price { get; set; }

        public int Space { get; set; }

        public int NumberOfRooms { get; set; }

        public Adress Adress { get; set; }

        public List<Contract> Contracts { get; set; }
        
    }
}
