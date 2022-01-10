using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL.Orders
{
    public class Carts:Base2
    {
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int? OrderId { get; set; }
        public CartStatus Status { get; set; }

        [ForeignKey("ProductsObject")]
        public int ProductId { get; set; }
        public virtual Products.Products ProductsObject { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }
    }

    
}
