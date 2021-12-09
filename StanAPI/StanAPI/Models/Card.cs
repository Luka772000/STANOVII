using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StanAPI.Models
{
    public class Card
    {
        [Key]
        public int CardId { get; set; }
        public string CardName { get; set; }
        public int CardNumber { get; set; }
        public int CardExpDate { get; set; }
        public int CVV { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
