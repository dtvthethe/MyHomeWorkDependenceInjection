using MyHomeWork.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHomeWork.Model.Models
{
    [Table("Products")]
    public class Product : Auditable
    {
        [Required()]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price can't null!")]
        [Range(0, Int32.MaxValue, ErrorMessage = "The quantity must be greater than 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The quantity can't null!")]
        [Range(1, Int32.MaxValue, ErrorMessage = "The quantity must be greater than 1")]
        public int Quantity { get; set; }

        [ForeignKey("Category")]
        public int CatetegoryID { get; set; }
        public Category Category { get; set; }

    }
}
