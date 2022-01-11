using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities
{
    public class Enum
    {
        public enum OrderType
        {
            Waiting,
            Cooking,
            ReadyForPacking,
            Packing,
            Packed,
            ReadyToDeliver,
            OnTheWay,
            Delivered,
            Cancelled,
        }

        public enum IngredientType
        {
            ProductType,
            CategoryType,
        }
        public enum ContentType
        {
            TermsAndConditions,
            AboutUs,
            AboutApp,
            PrivacyPolicy,
        }
        public enum CartStatus
        {
            Active,
            OrderConfirmed,
        }

        public enum EntityStatus
        {
            Active,
            Blocked,
        }

        public enum UserStatus
        {
            Active,
            Blocked,
            Left,
        }
        public enum UserType
        {
            SuperAdmin,
            Receptionist,
            Cook,
            Packer,
            Driver,
            User,
        }

        public enum LoginProvider
        {
            WithEmail,
            WithGmail,
            WithFacebook,
        }

        public enum DurationType
        {
            Days,
            Weeks,
            Months,
            Years,
        }

        public enum PaymentStatus
        {
            UnPaid,
            Paid,
        }

        public enum QueryStatus
        {
            Resolved,
            UnResolved,
        }

        public enum GenderType
        {
            Male,
            Female,
        }

        public enum NotificationType
        {
            Check,
            QueryResolved
        }
    }
}
