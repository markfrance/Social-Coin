using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCoin.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string RealName { get; set; }
        public string Email { get; set; }
        public string ProfilePicUrl { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateCreated { get; set; }
        public string Bio { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        //public IEnumerable<User> Following { get; set; }
        //public IEnumerable<User> Followers { get; set; }
    }
}
