using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Products
{
    public class Products:Base
    {
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        
        [ForeignKey("CategoriesObject")]
        public int CategoryId { get; set; }
        public virtual Categories.Categories CategoriesObject { get; set; }
    }
}
