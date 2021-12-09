using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class Contract
    {
        public int ContractId { get; set; }
        public int Date { get; set; }
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
