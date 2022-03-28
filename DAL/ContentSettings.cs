using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entities.Enum;

namespace DAL
{
    public class ContentSettings:Base2
    {
        public string title { get; set; }
        public string content { get; set; }
        public ContentType contentType { get; set; }
    }
}
