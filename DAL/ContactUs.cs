using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL
{
    public class ContactUs:Base2
    {
        public string Review { get; set; }
        public string Subject { get; set; }
        public QueryStatus Status { get; set; }

        [ForeignKey("UserObject")]
        public string UserId { get; set; }
        public virtual ApplicationUser UserObject { get; set; }
    }
}
