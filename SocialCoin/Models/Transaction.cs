using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCoin.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public User User { get; set; }
        public Coin Coin { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
    }
}
