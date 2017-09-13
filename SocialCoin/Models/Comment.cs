using System;
using System.Collections.Generic;
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
        public DateTime DatePosted { get; set; }
    }
}
