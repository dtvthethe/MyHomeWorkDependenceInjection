using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyHomeWork.Data.Infrastructure;
using MyHomeWork.Service.IServices;


namespace MyHomeWork.Test
{
    [TestClass]
    public class TestCategory
    {
        private ICategoryService _categoryService;
        private IUnitOfWork _unitOfWork;


        [TestMethod]
        public void GetData()
        {
            var cats = _categoryService.GetCategories();

            Assert.IsTrue(cats.Count > 0);
        }
    }
}
