using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AppInfo:Base2
    {
        public string Address { get; set; }
        public string TelephoneNumber { get; set; }
        public string Email { get; set; }
        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string GoogleUrl { get; set; }
        public string YoutubeUrl { get; set; }
    }
}
