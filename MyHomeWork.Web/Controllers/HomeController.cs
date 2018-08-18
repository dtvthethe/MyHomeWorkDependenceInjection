using MyHomeWork.Data.Infrastructure;
using MyHomeWork.Model.Models;
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
            //var aa = _categoryService.GetCategories();



            var cat = new Category { Name="Accessories", CreateDate = DateTime.Now };

            var aa = _categoryService.Add(cat);
            _categoryService.SaveChanges();

            var aaa = aa;



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