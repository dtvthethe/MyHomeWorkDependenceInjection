using MyHomeWork.Data.Infrastructure;
using MyHomeWork.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Data.IRepositories
{
    public interface ICategoryRepository: IRepository<Category>
    {
        IEnumerable<Category> GetCategories();
    }
}
