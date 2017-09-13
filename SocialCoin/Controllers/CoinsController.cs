using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SocialCoin.Models;

namespace SocialCoin.Controllers
{
    public class CoinsController : Controller
    {
        private readonly SocialCoinContext _context;
        private CoinMarketCapService service = new CoinMarketCapService();

        public CoinsController(SocialCoinContext context)
        {
            _context = context;
        }

        // GET: Coins
        public async Task<IActionResult> Index()
        {
            return View(await service.GetCoinsAsync());
        }

        // GET: Coins/Details/5
        public async Task<IActionResult> Details(string name)
        {
            if (name == null)
            {
                return NotFound();
            }

            var coin = await service.GetCoinAsync(name);
            if (coin == null)
            {
                return NotFound();
            }

            return View(coin);
        }

        // GET: Coins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Coins/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description")] Coin coin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(coin);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(coin);
        }

        // GET: Coins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var coin = await _context.Coin.SingleOrDefaultAsync(m => m.ID == id);
            if (coin == null)
            {
                return NotFound();
            }
            return View(coin);
        }

        // POST: Coins/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description")] Coin coin)
        {
            if (id != coin.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(coin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CoinExists(coin.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(coin);
        }

        private bool CoinExists(int id)
        {
            return _context.Coin.Any(e => e.ID == id);
        }
    }
}
