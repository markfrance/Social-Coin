using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public string Bio { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }
        public IEnumerable<Comment> Comments { get; set; }
        // public IEnumerable<User> Following { get; set; }
        //  public IEnumerable<User> Followers { get; set; }

        private readonly SocialCoinContext _context;

        public IEnumerable<Coin> GetCoins()
        {
            return new List<Coin>();
        }

        public IEnumerable<Comment> GetComments()
        {
            if (Comments == null)
            {
                Comments = new List<Comment> { new Comment { User = this, DatePosted = DateTime.Now, Body = "This is a test comment" } };
            }

            return Comments;
        }
        public IEnumerable<Transaction> GetTransactions()
        {
            if (Transactions == null)
            {
                Transactions = new List<Transaction> { new Transaction { Amount = 1, CoinID = "bitcoin", Price = 4000, Date = DateTime.Now } };
            }

            return Transactions.OrderByDescending(t => t.Date);
        }

        public IEnumerable<Comment> GetCommentsForCoin(Coin coin)
        {
            return Comments.Where(c => c.CoinId == coin.CmcId);
        }

        //public IEnumerable<User> GetFollowing()
        //{
        //    return _context.User.ToList().
        //}
    }
}
