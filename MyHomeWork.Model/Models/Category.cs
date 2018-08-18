using MyHomeWork.Model.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Model.Models
{
    public class Category : Auditable
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
