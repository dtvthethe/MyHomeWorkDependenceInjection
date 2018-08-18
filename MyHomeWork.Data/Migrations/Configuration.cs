namespace MyHomeWork.Data.Migrations
{
    using MyHomeWork.Model.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyHomeWork.Data.MyHomeWorkDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyHomeWork.Data.MyHomeWorkDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            if (context.Categories.Count() == 0)
            {
                context.Categories.AddRange(new List<Category> {
                    new Category { Name = "ShortPain", CreateDate = DateTime.Now },
                    new Category { Name = "T-Shirt", CreateDate = DateTime.Now },
                    new Category { Name = "Skirt", CreateDate = DateTime.Now }
                });
                context.SaveChanges();
            }


            if (context.Products.Count() == 0 && context.Categories.Count() > 0)
            {
                context.Products.AddRange(
                    new List<Product>
                    {
                        new Product { Name = "ShortPain A111", Price = 2000, CreateDate = DateTime.Now, CatetegoryID = 1, Quantity = 15 },
                        new Product { Name = "ShortPain A222", Price = 1000, CreateDate = DateTime.Now, CatetegoryID = 1, Quantity = 34 },

                        new Product { Name = "T-Shirt T111", Price = 2200, CreateDate = DateTime.Now, CatetegoryID = 2, Quantity = 5 },
                        new Product { Name = "T-Shirt T222", Price = 2700, CreateDate = DateTime.Now, CatetegoryID = 2, Quantity = 124 },
                        new Product { Name = "T-Shirt T333", Price = 2210, CreateDate = DateTime.Now, CatetegoryID = 2, Quantity = 25 },

                        new Product { Name = "Skirt S111", Price = 4000, CreateDate = DateTime.Now, CatetegoryID = 3, Quantity = 45 },
                        new Product { Name = "Skirt S222", Price = 2200, CreateDate = DateTime.Now, CatetegoryID = 3, Quantity = 46 },

                    });
            }

        }
    }
}
