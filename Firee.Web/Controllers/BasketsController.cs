using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Firee.Web.Controllers
{
    public class BasketsController : Controller
    {
        // GET: Baskets
        public ActionResult Index()
        {


            return View();
        }

        // GET: Baskets/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Baskets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Baskets/Create
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

        // GET: Baskets/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Baskets/Edit/5
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

        // GET: Baskets/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Baskets/Delete/5
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
