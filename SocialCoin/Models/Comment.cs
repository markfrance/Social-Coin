using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCoin.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public User User { get; set; }
        public string CoinId { get; set; }
        public string Body { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatePosted { get; set; }
    }
}
