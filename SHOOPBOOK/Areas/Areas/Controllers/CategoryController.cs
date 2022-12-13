using Microsoft.Ajax.Utilities;
using SHOOPBOOK.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SHOOPBOOK.Areas.Areas.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext _dbConect = new ApplicationDbContext();
        // GET: Areas/Category
        public ActionResult Index()
        {
            var items =_dbConect.Categories;
            return View(items);
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}