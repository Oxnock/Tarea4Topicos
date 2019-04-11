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
    public class EstacionamientoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EstacionamientoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Estacionamientoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Estacionamiento.ToListAsync());
        }

        // GET: Estacionamientoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamiento = await _context.Estacionamiento
                .FirstOrDefaultAsync(m => m.EstacionamientoId == id);
            if (estacionamiento == null)
            {
                return NotFound();
            }

            return View(estacionamiento);
        }

        // GET: Estacionamientoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Estacionamientoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstacionamientoId,FechaIngreso,FechaSalida,TarifaBasica,Ganancia,Mantenimiento,ImpuestoVenta,TotalAPagar")] Estacionamiento estacionamiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estacionamiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estacionamiento);
        }

        // GET: Estacionamientoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamiento = await _context.Estacionamiento.FindAsync(id);
            if (estacionamiento == null)
            {
                return NotFound();
            }
            return View(estacionamiento);
        }

        // POST: Estacionamientoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EstacionamientoId,FechaIngreso,FechaSalida,TarifaBasica,Ganancia,Mantenimiento,ImpuestoVenta,TotalAPagar")] Estacionamiento estacionamiento)
        {
            if (id != estacionamiento.EstacionamientoId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estacionamiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstacionamientoExists(estacionamiento.EstacionamientoId))
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
            return View(estacionamiento);
        }

        // GET: Estacionamientoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estacionamiento = await _context.Estacionamiento
                .FirstOrDefaultAsync(m => m.EstacionamientoId == id);
            if (estacionamiento == null)
            {
                return NotFound();
            }

            return View(estacionamiento);
        }

        // POST: Estacionamientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estacionamiento = await _context.Estacionamiento.FindAsync(id);
            _context.Estacionamiento.Remove(estacionamiento);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstacionamientoExists(int id)
        {
            return _context.Estacionamiento.Any(e => e.EstacionamientoId == id);
        }
    }
}
