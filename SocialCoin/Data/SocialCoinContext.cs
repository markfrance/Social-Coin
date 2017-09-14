using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SocialCoin.Models;

namespace SocialCoin.Models
{
    public class SocialCoinContext : DbContext
    {
        public SocialCoinContext (DbContextOptions<SocialCoinContext> options)
            : base(options)
        {
        }

        public DbSet<SocialCoin.Models.User> User { get; set; }

        public DbSet<SocialCoin.Models.Coin> Coin { get; set; }

        public DbSet<SocialCoin.Models.CoinDTO> CoinDTO { get; set; }

        public DbSet<SocialCoin.Models.Global> Global { get; set; }
    }
}
