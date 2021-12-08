using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int DateOfBirth { get; set; }

        public string Email { get; set; }

        public int Phone { get; set; }

        public int TransAcc { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public Card Card { get; set; }

        //kartica strani kljuc entitte
    }
}
