using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Dominion.Data;
using Dominion.Models;
using Microsoft.AspNetCore.Authorization;

namespace Dominion.Controllers
{
    [Authorize]
    public class StockListsController : Controller
    {
        private readonly DominionContext _context;

        public StockListsController(DominionContext context)
        {
            _context = context;
        }

        // GET: StockLists
        public async Task<IActionResult> Index()
        {
            return View(await _context.StockList.ToListAsync());
        }

        // GET: StockLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockList = await _context.StockList
                .FirstOrDefaultAsync(m => m.StockID == id);
            if (stockList == null)
            {
                return NotFound();
            }

            return View(stockList);
        }

        // GET: StockLists/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StockLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StockID,ItemName,ImagePath,OrgID")] StockList stockList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stockList);
        }

        // GET: StockLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockList = await _context.StockList.FindAsync(id);
            if (stockList == null)
            {
                return NotFound();
            }
            return View(stockList);
        }

        // POST: StockLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StockID,ItemName,ImagePath,OrgID")] StockList stockList)
        {
            if (id != stockList.StockID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stockList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StockListExists(stockList.StockID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stockList);
        }

        // GET: StockLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stockList = await _context.StockList
                .FirstOrDefaultAsync(m => m.StockID == id);
            if (stockList == null)
            {
                return NotFound();
            }

            return View(stockList);
        }

        // POST: StockLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stockList = await _context.StockList.FindAsync(id);
            _context.StockList.Remove(stockList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StockListExists(int id)
        {
            return _context.StockList.Any(e => e.StockID == id);
        }
    }
}
