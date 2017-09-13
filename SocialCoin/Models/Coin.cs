using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace SocialCoin.Models
{
    public class Coin
    {
        public int ID { get; set; }
        [JsonProperty(PropertyName = "id")]
        public string CmcId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Symbol { get; set; }

        [Display(Name = "#")]
        public int Rank { get; set; }

        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        [JsonProperty(PropertyName = "price_usd")]
        public decimal PriceUSD { get; set; }

        [Display(Name = "BTC Value")]
        [DisplayFormat(DataFormatString = "{0:0.0000000000}")]
        [JsonProperty(PropertyName = "price_btc")]
        public decimal PriceBTC { get; set; }

        [Display(Name = "24hr Vol")]
        [DataType(DataType.Currency)]
        [JsonProperty(PropertyName = "24h_volume_usd")]
        public decimal DailyVolume { get; set; }

        [Display(Name = "Market Cap")]
        [DataType(DataType.Currency)]
        [JsonProperty(PropertyName = "market_cap_usd")]
        public decimal MarketCapUSD { get; set; }

        [JsonProperty(PropertyName = "available_supply")]
        public decimal AvailableSupply { get; set; }

        [Display(Name = "1hr %")]
        [DisplayFormat(DataFormatString = "{0}%")]
        [JsonProperty(PropertyName = "percent_change_1h")]
        public decimal Change1hr { get; set; }

        [Display(Name = "24hr %")]
        [DisplayFormat(DataFormatString = "{0}%")]
        [JsonProperty(PropertyName = "percent_change_24h")]
        public decimal Change24hr { get; set; }

        [Display(Name = "7d %")]
        [DisplayFormat(DataFormatString = "{0}%")]
        [JsonProperty(PropertyName = "percent_change_7d")]
        public decimal Change7d { get; set; }



    }
}
