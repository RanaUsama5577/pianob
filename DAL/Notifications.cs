using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL
{
    public class Notifications: Base
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool IsSeen { get; set; }
        public NotificationType Type { get; set; }
        public virtual ApplicationUser NotifyByObject { get; set; }
        public virtual ApplicationUser NotitfyToObject { get; set; }


        [ForeignKey("NotifyByObject")]
        public string NotifyBy { get; set; }
        [ForeignKey("NotitfyToObject")]
        public string NotifyTo { get; set; }
    }
}
