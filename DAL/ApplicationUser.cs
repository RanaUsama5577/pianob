﻿using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using static Entities.Enum;

namespace DAL
{
    public class ApplicationUser : IdentityUser
    {
        public UserType Type { get; set; }
        public UserStatus Status { get; set; }
        public DateTime RegisteredAt { get; set; }
        public LoginProvider ExternalType { get; set; }
        public string ExternalId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ProfileImageUrl { get; set; }
        public bool IsNotificationDisabled { get; set; }
        public string LanguageSelection { get; set; }
        public string Address { get; set; }
        public string FcmToken { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Gender { get; set; }
        [ForeignKey("BranchObject")]
        public int? BranchId { get; set; }
        public virtual Branches.Branch BranchObject { get; set; }
    }
}
