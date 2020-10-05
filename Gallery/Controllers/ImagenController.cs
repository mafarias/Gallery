using Gallery.ClienteApi;
using Gallery.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Web;
using System.Web.Mvc;

namespace Gallery.Controllers
{
    public class ImagenController : Controller
    {
        // GET: Imagen
        public ActionResult Index()
        {
            string url = "https://picsum.photos/v2/list?page=1&limit=50";
            ConsumoApi cliente = new ConsumoApi();
            var options = new JsonSerializerOptions
            {
                DictionaryKeyPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
            string json = cliente.GetApiHttpGet(url);
            List<Imagen> lista = new List<Imagen>();
            lista = JsonConvert.DeserializeObject<List<Imagen>>(json);
            return View(lista);
        }

        // GET: Imagen/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Imagen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Imagen/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Imagen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Imagen/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Imagen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Imagen/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
