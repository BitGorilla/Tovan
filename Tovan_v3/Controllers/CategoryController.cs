using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tovan_v3.Models;

namespace Tovan_v3.Controllers
{
    public class CategoryController : Controller
    {
        private project_tovanEntities db = new project_tovanEntities();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
    }
}