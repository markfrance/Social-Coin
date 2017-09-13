using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialCoin
{
    public static class Extensions
    {
        public static string GetPercentageColour(this decimal value)
        {
            if (value < 0) return "red";
            if (value > 0) return "green";
            return "";
        }
    }
}
