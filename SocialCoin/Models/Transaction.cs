using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SocialCoin.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string CoinID { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
