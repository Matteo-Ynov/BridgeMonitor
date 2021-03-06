using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using BridgeMonitor.Models;
using System.Linq;

namespace BridgeMonitor.Controllers
{
    public class FermetureController : Controller
    {

        public static List<Boats> BoatsList = new List<Boats>();
        private static readonly HttpClient client = new HttpClient();
        public FermetureController()
        {
            var stringTask = client.GetStringAsync("https://api.alexandredubois.com/pont-chaban/api.php");
            var myJsonResponse = stringTask.Result;
            var result = JsonConvert.DeserializeObject<List<Boats>>(myJsonResponse);
            BoatsList = result.OrderBy(closing =>
            Convert.ToDateTime(closing.ClosingDate)).ToList();
        }

        public IActionResult AllFermeture()
        {
            return View(BoatsList);
        }

        [HttpGet]
        [Route("/Fermeture/FermetureDetail/{id}")]
        public IActionResult FermetureDetail(int id)
        {     
            return View(BoatsList[id]);
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
