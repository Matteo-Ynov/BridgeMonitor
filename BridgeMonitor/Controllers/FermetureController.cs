using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using BridgeMonitor.Models;

namespace BridgeMonitor.Controllers
{
    public class FermetureController : Controller
    {
        public static List<Boats> BoatsList = new List<Boats>();
        public FermetureController()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://api.alexandredubois.com/pont-chaban/api.php").Result)
                {
                    using (HttpContent content = response.Content)
                    {
                        var json = content.ReadAsStringAsync().Result;
                        BoatsList = JsonConvert.DeserializeObject<List<Boats>>(json);
                    }
                }
            }
        }
        public IActionResult AllFermeture()
        {
            return View(BoatsList);
        }

        public IActionResult FermetureDetail()
        {
            return View(BoatsList);
        }

        public IActionResult NextFermeture()
        {
            return View(BoatsList);
        }

        // POST: Fermeture/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fermeture/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Fermeture/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Fermeture/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Fermeture/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
