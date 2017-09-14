using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SocialCoin.Controllers.Modules
{
    public class MarketStatsController : Controller
    {

        private CoinMarketCapService service = new CoinMarketCapService();

        public async Task<IActionResult> Index()
        {
            return View(await service.GetGlobalData());
        }
    }
}