using DAL.Branches;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL.Orders
{
    public class Orders:Base2
    {
        public decimal TotalPrice { get; set; }
        public OrderType Status { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }

        [ForeignKey("AssignedObject")]
        public string AssigneeId { get; set; }
        public virtual ApplicationUser AssignedObject { get; set; }

        [ForeignKey("BranchesObject")]
        public int BranchId { get; set; }
        public virtual Branch BranchesObject { get; set; }
    }
}
