using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL.Products
{
    public class Ingredients:Base
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public IngredientType Type { get; set; }

        [ForeignKey("ProductsObject")]
        public int? ProductId { get; set; }
        public virtual Products ProductsObject { get; set; }

        [ForeignKey("CategoriesObject")]
        public int? CategoryId { get; set; }
        public virtual Categories.Categories CategoriesObject { get; set; }
    }
}
