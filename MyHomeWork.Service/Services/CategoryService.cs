using MyHomeWork.Data.Infrastructure;
using MyHomeWork.Data.IRepositories;
using MyHomeWork.Model.Models;
using MyHomeWork.Service.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Service.Services
{
    public class CategoryService: ICategoryService
    {

        private ICategoryRepository _categoryReponsitory;
        private IUnitOfWork _unitOfWork;

        public CategoryService(ICategoryRepository categoryReponsitory, IUnitOfWork unitOfWork) {
            _categoryReponsitory = categoryReponsitory;
            _unitOfWork = unitOfWork;
        }

        public Category Add(Category category)
        {
            return _categoryReponsitory.Add(category);
        }

        public List<Category> GetCategories()
        {
            return _categoryReponsitory.GetCategories().ToList();
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
