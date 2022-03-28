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
        public string OrderId { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal SubTotal { get; set; }
        public decimal DeliveryCharges { get; set; }
        public decimal ServiceCharges { get; set; }
        public string Address { get; set; }
        public string Note { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public OrderStatus Status { get; set; }
        public OrderType Type { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }

        [ForeignKey("AssignedObject")]
        public string AssigneeId { get; set; }
        public virtual ApplicationUser AssignedObject { get; set; }

        [ForeignKey("BranchesObject")]
        public int BranchId { get; set; }
        public virtual Branch BranchesObject { get; set; }

        [ForeignKey("CreatorObject")]
        public string CreatedBy { get; set; }
        public virtual ApplicationUser CreatorObject { get; set; }
    }
}
