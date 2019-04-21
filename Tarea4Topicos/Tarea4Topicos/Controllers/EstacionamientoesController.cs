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

        public static int Tarifa = 0;
        public static int Impuesto = 0;
        public static int Mantenimiento = 0;
        public static int Ganacia = 0;
        public static DateTime ingreso;
        public static DateTime Salida;

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

            var estacionamiento = await _context.Estacionamiento.Include(m => m.ParqueoId).Include(m => m.VehiculoId)
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
            var ListaP = _context.Parqueo.ToList();
            ViewBag.listaP = new SelectList(ListaP, "ParqueoId", "Descripcion");

            var ListaV = _context.Vehiculo.ToList();
            ViewBag.listaV = new SelectList(ListaV, "VehiculoId", "Placa");
            return View();


        }

        // POST: Estacionamientoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EstacionamientoId,FechaIngreso,FechaSalida,TarifaBasica,Ganancia,Mantenimiento,ImpuestoVenta,TotalAPagar,ParqueoId,VehiculoId")] Estacionamiento estacionamiento)
        {
            if (ModelState.IsValid)
            {
                Parqueo parqueo = await _context.Parqueo
               .FirstOrDefaultAsync(m => m.ParqueoId == estacionamiento.ParqueoId.ParqueoId);
                Vehiculo vehiculo = await _context.Vehiculo
               .FirstOrDefaultAsync(m => m.VehiculoId == estacionamiento.VehiculoId.VehiculoId);

                estacionamiento.ParqueoId = parqueo;
                estacionamiento.VehiculoId = vehiculo;
                estacionamiento.FechaIngreso = DateTime.Now;
                estacionamiento.TarifaBasica = 600;
                estacionamiento.Mantenimiento = 100;
                estacionamiento.ImpuestoVenta = 0;
                estacionamiento.Ganancia = 200;

                Tarifa = estacionamiento.TarifaBasica;
                Mantenimiento = estacionamiento.Mantenimiento;
                Impuesto = estacionamiento.ImpuestoVenta;
                Ganacia = estacionamiento.Ganancia;
                ingreso = estacionamiento.FechaIngreso;

                _context.Add(estacionamiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estacionamiento);
        }
        public void CalcularTarifa(Estacionamiento estacionamiento)
        {
            
            
            int horasTotales = estacionamiento.FechaSalida.Hour - estacionamiento.FechaIngreso.Hour;
            int minutosTotales = estacionamiento.FechaSalida.Minute - estacionamiento.FechaIngreso.Minute;
            if (minutosTotales < 0)
            {
                minutosTotales = 60 + minutosTotales;
            }
            estacionamiento.TotalAPagar = (horasTotales * estacionamiento.TarifaBasica) + (horasTotales * estacionamiento.Mantenimiento) + (minutosTotales * 10);
            estacionamiento.ImpuestoVenta = (estacionamiento.TotalAPagar * 13) / 100;
            estacionamiento.TotalAPagar = estacionamiento.TotalAPagar + estacionamiento.ImpuestoVenta;
            estacionamiento.Ganancia = (estacionamiento.Ganancia * horasTotales) + ((200 / 60) * minutosTotales);
        }

        // GET: Estacionamientoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
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

                    estacionamiento.TarifaBasica = Tarifa;
                    estacionamiento.Mantenimiento = Mantenimiento;
                    estacionamiento.ImpuestoVenta = Impuesto;
                    estacionamiento.Ganancia = Ganacia;
                    estacionamiento.FechaIngreso = ingreso;
                    estacionamiento.FechaSalida = DateTime.Now;
                    Salida = estacionamiento.FechaSalida;

                    CalcularTarifa(estacionamiento);
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
