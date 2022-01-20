using DAL.Products;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL.Orders
{
    public class CartIngredients : Base2
    {
        public decimal Price { get; set; }
        public CartStatus Status { get; set; }
        
        #region ForienKeys
        
        [ForeignKey("IngredientObject")]
        public int IngredientId { get; set; }
        public virtual Ingredients IngredientObject { get; set; }

        [ForeignKey("CartsObject")]
        public int? CartId { get; set; }
        public virtual Carts CartsObject { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }
        
        #endregion

    }
}
