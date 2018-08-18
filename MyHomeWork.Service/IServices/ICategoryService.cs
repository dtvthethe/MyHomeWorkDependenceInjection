using MyHomeWork.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Service.IServices
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        Category Add(Category category);
        void SaveChanges();
    }
}
