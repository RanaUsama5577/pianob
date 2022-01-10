using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Branches
{
    public class BranchImages:Base2
    {
        public string Image { get; set; }

        [ForeignKey("BranchesObject")]
        public int BranchId { get; set; }
        public virtual Branch BranchesObject { get; set; }
    }
}
