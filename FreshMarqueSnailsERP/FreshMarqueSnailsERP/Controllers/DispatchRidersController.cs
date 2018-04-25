using FreshMarqueSnailsERP.Data;
using FreshMarqueSnailsERP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FreshMarqueSnailsERP.Controllers
{
    public class DispatchRidersController : Controller
    {
        private readonly DataContext _context;

        public DispatchRidersController(DataContext context)
        {
            _context = context;
        }

        // GET: DispatchRiders
        public async Task<IActionResult> Index()
        {
            return View(await _context.DispatchRiders.ToListAsync());
        }

        // GET: DispatchRiders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispatchRider = await _context.DispatchRiders
                .SingleOrDefaultAsync(m => m.Id == id);
            if (dispatchRider == null)
            {
                return NotFound();
            }

            return View(dispatchRider);
        }

        // GET: DispatchRiders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DispatchRiders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Contact,Company,Supervisor")] DispatchRider dispatchRider)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dispatchRider);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dispatchRider);
        }

        // GET: DispatchRiders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispatchRider = await _context.DispatchRiders.SingleOrDefaultAsync(m => m.Id == id);
            if (dispatchRider == null)
            {
                return NotFound();
            }
            return View(dispatchRider);
        }

        // POST: DispatchRiders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Contact,Company,Supervisor")] DispatchRider dispatchRider)
        {
            if (id != dispatchRider.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dispatchRider);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DispatchRiderExists(dispatchRider.Id))
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
            return View(dispatchRider);
        }

        // GET: DispatchRiders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dispatchRider = await _context.DispatchRiders
                .SingleOrDefaultAsync(m => m.Id == id);
            if (dispatchRider == null)
            {
                return NotFound();
            }

            return View(dispatchRider);
        }

        // POST: DispatchRiders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dispatchRider = await _context.DispatchRiders.SingleOrDefaultAsync(m => m.Id == id);
            _context.DispatchRiders.Remove(dispatchRider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DispatchRiderExists(int id)
        {
            return _context.DispatchRiders.Any(e => e.Id == id);
        }
    }
}
