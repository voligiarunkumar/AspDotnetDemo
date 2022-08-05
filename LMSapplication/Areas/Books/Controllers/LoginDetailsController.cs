using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LMSapplication.Data;
using LMSapplication.Models;

namespace LMSapplication.Areas.Books.Controllers
{
    [Area("Books")]
    public class LoginDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Books/LoginDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginDetails.ToListAsync());
        }

        // GET: Books/LoginDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginDetails = await _context.LoginDetails
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (loginDetails == null)
            {
                return NotFound();
            }

            return View(loginDetails);
        }

        // GET: Books/LoginDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Books/LoginDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,FirstName,LastName,ContactNumber,Address")] LoginDetails loginDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginDetails);
        }

        // GET: Books/LoginDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginDetails = await _context.LoginDetails.FindAsync(id);
            if (loginDetails == null)
            {
                return NotFound();
            }
            return View(loginDetails);
        }

        // POST: Books/LoginDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,FirstName,LastName,ContactNumber,Address")] LoginDetails loginDetails)
        {
            if (id != loginDetails.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginDetailsExists(loginDetails.UserName))
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
            return View(loginDetails);
        }

        // GET: Books/LoginDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginDetails = await _context.LoginDetails
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (loginDetails == null)
            {
                return NotFound();
            }

            return View(loginDetails);
        }

        // POST: Books/LoginDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loginDetails = await _context.LoginDetails.FindAsync(id);
            _context.LoginDetails.Remove(loginDetails);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginDetailsExists(string id)
        {
            return _context.LoginDetails.Any(e => e.UserName == id);
        }
    }
}
