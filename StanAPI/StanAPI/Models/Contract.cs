using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }
        public Apartment Apartment { get; set; }
        public User User { get; set; }

    }
}
