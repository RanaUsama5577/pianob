using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class PayModel
    {
        [Required]
        public string cardNumber { get; set; }
        [Required]
        public int month { get; set; }
        [Required]
        public int year { get; set; }
        [Required]
        public string Cvc { get; set; }
        [Required]
        public decimal amount { get; set; }
    }
}
