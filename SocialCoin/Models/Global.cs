using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCoin.Models
{
    public class Global
    {
        public decimal Total_Market_Cap_Usd { get; set; }
        public decimal Total_24hr_Volume_Usd { get; set; }
        public double Bitcoin_Percentage_Of_Market_Cap { get; set; }
        public int Active_Currencies { get; set; }
        public int Active_Assets { get; set; }
        public int Active_Markets { get; set; }
    }
}
