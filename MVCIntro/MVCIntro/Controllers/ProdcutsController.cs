using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCIntro.Controllers
{
    public class ProdcutsController : Controller
    {
        // GET: Prodcuts
        public ActionResult Index()
        {
            return View();
        }

        // GET: Prodcuts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Prodcuts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prodcuts/Create
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

        // GET: Prodcuts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Prodcuts/Edit/5
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

        // GET: Prodcuts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Prodcuts/Delete/5
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
