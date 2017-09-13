using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SocialCoin.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace SocialCoin.Controllers
{
    public class CoinMarketCapService
    {
        readonly string uri = "https://api.coinmarketcap.com/v1/";

        public async Task<List<Coin>> GetCoinsAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<Coin>>(await client.GetStringAsync($"{uri}ticker/?limit=50"));
            }
        }

        public async Task<Coin> GetCoinAsync(string name)
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<List<Coin>>(await client.GetStringAsync($"{uri}ticker/{name}")).SingleOrDefault();
            }
        }

        public async Task<Global> GetGlobalData()
        {
            using (HttpClient client = new HttpClient())
            {
                return JsonConvert.DeserializeObject<Global>(await client.GetStringAsync($"{uri}/global"));
            }
        }
    }
}
