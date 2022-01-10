using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Products
{
    public class ProductsImages:Base
    {
        public string Image { get; set; }

        [ForeignKey("ProductsObject")]
        public int ProductId { get; set; }
        public virtual Products ProductsObject { get; set; }
    }
}
