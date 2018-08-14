using MyHomeWork.Data.Infrastructure;
using MyHomeWork.Data.IRepositories;
using MyHomeWork.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Data.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<Category> GetCategories()
        {
            return DbContext.Categories.ToList();
        }

    }
}
