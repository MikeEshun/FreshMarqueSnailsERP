using FreshMarqueSnailsERP.Data;
using FreshMarqueSnailsERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FreshMarqueSnailsERP.Controllers
{
    public class RetailersController : Controller
    {
        private readonly DataContext _context;

        public RetailersController(DataContext context)
        {
            _context = context;
        }

        // GET: Retailers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Retailers.ToListAsync());
        }

        // GET: Retailers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.Retailers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (retailer == null)
            {
                return NotFound();
            }

            return View(retailer);
        }

        // GET: Retailers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Retailers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Contact,Location,Type")] Retailer retailer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(retailer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(retailer);
        }

        // GET: Retailers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.Retailers.SingleOrDefaultAsync(m => m.Id == id);
            if (retailer == null)
            {
                return NotFound();
            }
            return View(retailer);
        }

        // POST: Retailers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Contact,Location,Type")] Retailer retailer)
        {
            if (id != retailer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(retailer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RetailerExists(retailer.Id))
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
            return View(retailer);
        }

        // GET: Retailers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var retailer = await _context.Retailers
                .SingleOrDefaultAsync(m => m.Id == id);
            if (retailer == null)
            {
                return NotFound();
            }

            return View(retailer);
        }

        // POST: Retailers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var retailer = await _context.Retailers.SingleOrDefaultAsync(m => m.Id == id);
            _context.Retailers.Remove(retailer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RetailerExists(int id)
        {
            return _context.Retailers.Any(e => e.Id == id);
        }
    }
}
