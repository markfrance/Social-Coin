using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SocialCoin.Models;

namespace SocialCoin.Controllers.Modules
{
    public class TopDailyPerformersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var service = new CoinMarketCapService();

            return View(await service.GetBestPerforming());
        }


    }
}