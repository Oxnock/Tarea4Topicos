using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Tarea4Topicos.Data;
using Tarea4Topicos.Models;

namespace Tarea4Topicos.Controllers
{
    public class ParqueosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ParqueosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Parqueos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Parqueo.ToListAsync());
        }

        // GET: Parqueos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
           
            var parqueo = await _context.Parqueo.Include(m=>m.ListaEstacionamientos).Include("ListaEstacionamientos.VehiculoId")
                .FirstOrDefaultAsync(m => m.ParqueoId == id);
            

            if (parqueo == null)
            {
                return NotFound();
            }

            return View(parqueo);
        }

        // GET: Parqueos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Parqueos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ParqueoId,Descripcion")] Parqueo parqueo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(parqueo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(parqueo);
        }

        // GET: Parqueos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parqueo = await _context.Parqueo.FindAsync(id);
            if (parqueo == null)
            {
                return NotFound();
            }
            return View(parqueo);
        }

        // POST: Parqueos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ParqueoId,Descripcion")] Parqueo parqueo)
        {
            if (id != parqueo.ParqueoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(parqueo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParqueoExists(parqueo.ParqueoId))
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
            return View(parqueo);
        }

        // GET: Parqueos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var parqueo = await _context.Parqueo
                .FirstOrDefaultAsync(m => m.ParqueoId == id);
            if (parqueo == null)
            {
                return NotFound();
            }

            return View(parqueo);
        }

        // POST: Parqueos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var parqueo = await _context.Parqueo.FindAsync(id);
            _context.Parqueo.Remove(parqueo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParqueoExists(int id)
        {
            return _context.Parqueo.Any(e => e.ParqueoId == id);
        }
    }
}
