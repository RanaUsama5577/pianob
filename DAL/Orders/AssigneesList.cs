using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Orders
{
    public class AssigneesList:Base2
    {
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        [ForeignKey("OrderObject")]
        public int OrderId { get; set; }
        public virtual Orders OrderObject { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }
    }
}
