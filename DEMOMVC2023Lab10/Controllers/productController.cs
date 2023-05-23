using DEMOMVC2023Lab10.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace DEMOMVC2023Lab10.Controllers
{
    public class productController : Controller
    {
        private NeptunoEntities db = new NeptunoEntities();

        // GET: product
        public ActionResult Index()
        {
            return View(db.productos.ToList());
        }

        // GET: productos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: productos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idproducto,nombreProducto,precioUnidad,nombreCategoria")] productos productos)
        {
            if (ModelState.IsValid)
            {
                db.productos.Add(productos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(productos);
        }
    }
}