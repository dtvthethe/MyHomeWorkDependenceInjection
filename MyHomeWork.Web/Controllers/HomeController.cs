using MyHomeWork.Service.IServices;
using MyHomeWork.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyHomeWork.Web.Controllers
{
    public class HomeController : Controller
    {

        private ICategoryService _categoryService;

        public HomeController(ICategoryService categoryService) {
            _categoryService = categoryService;
        }


        public ActionResult Index()
        {
            var aa = _categoryService.GetCategories();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}