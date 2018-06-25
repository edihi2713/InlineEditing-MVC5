using InlineEditing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InlineEditing.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            Meucci3Entities entities = new Meucci3Entities();

            return View(entities.Dominios);
        }

        [HttpPost]
        public JsonResult insertDominio(Dominios dominio)
        {

            dominio.domFechaCreacion = DateTime.Now;
            dominio.domFechaDesde = DateTime.Now;

            //using (Meucci3Entities entities = new Meucci3Entities())
            //{

            //    entities.Dominios.Add(dominio);
            //    entities.SaveChanges();
            //}

            return Json(dominio);
        }

        [HttpPost]
        public ActionResult UpdateDominio(Dominios dominio)
        {
            using (Meucci3Entities entities = new Meucci3Entities())
            {
                Dominios entity = entities.Dominios.Find(dominio.domDominioId);

                entity.domDescripcion = dominio.domDescripcion;

                //entities.SaveChanges();
            }

            return new EmptyResult();

        }


        [HttpPost]
        public ActionResult DeleteDominio(int dominioId)
        {
            using (Meucci3Entities entities = new Meucci3Entities())
            {
                Dominios entity = entities.Dominios.Find(dominioId);
                //entities.Dominios.Remove(entity);
                //entities.SaveChanges();
            }
            return new EmptyResult();
        }



	}
}