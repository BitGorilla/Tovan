using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tovan_v3.Models;
using System.IO;


namespace Tovan_v3.Controllers
{
    public class HomeController : Controller
    {
        private project_tovanEntities db = new project_tovanEntities();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.imageCategory = new SelectList(db.Tbl_category, "categoryID", "categoryType");
            return View();
        }

        [HttpPost]
        /*public ActionResult Index(HttpPostedFileBase imageSrc, FormCollection imageCategory)
        {

           
           if (imageSrc != null)
            {
                string path = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                imageSrc.SaveAs(path + Path.GetFileName(imageSrc.FileName));
                ViewBag.Message = imageCategory["category"].ToString();
                ViewBag.Image = "/Uploads/" + Path.GetFileName(imageSrc.FileName);

                
                if (ModelState.IsValid)
                {
                    db.Tbl_images.Add(tbl_images);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }



            }

            return View();
        }*/
        public ActionResult Index([Bind(Include = "imageID, imageSrc, imageCategory")] Tbl_images tbl_images)
        { 
                if (ModelState.IsValid)
                {
                    db.Tbl_images.Add(tbl_images);
                    db.SaveChanges();
                }

            return View();
        }
    }
}