using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tarea4Topicos.Models;


namespace Tarea4Topicos.Controllers
{
    public class SalidaAutomovilController : Controller
    {
        
        // GET: SalidaAutomovil
        public ActionResult Index()
        {
            return View();
        }

        // GET: SalidaAutomovil/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SalidaAutomovil/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SalidaAutomovil/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalidaAutomovil/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SalidaAutomovil/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: SalidaAutomovil/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SalidaAutomovil/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}