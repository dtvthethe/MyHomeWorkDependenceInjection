using MyHomeWork.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Data
{
    public class MyHomeWorkDBContext : DbContext
    {
        public MyHomeWorkDBContext() : base("MyHomeWorkDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }

    }
}
