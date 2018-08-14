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
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        protected ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
