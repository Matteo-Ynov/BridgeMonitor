using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using VCubWatcher.Models;

namespace BridgeMonitor.Controllers
{
    public class FermetureController : Controller
    {

        public static List<Boats> BoatsList = new List<Boats>();
        public FermetureController()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = client.GetAsync("https://api.alexandredubois.com/vcub-backend/vcub.php").Result)
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
            return View();
        }

        public IActionResult FermetureDetail()
        {
            return View();
        }

        public IActionResult NextFermeture()
        {
            return View();
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
