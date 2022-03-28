using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ResetPasswordVMS
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }
        public string Email { get; set; }
        public string Code { get; set; }
    }
}