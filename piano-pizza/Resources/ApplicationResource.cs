using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace piano_pizza.Resources
{
    public class ApplicationResource
    {
        private static System.Resources.ResourceManager resourceMan;

        private static System.Globalization.CultureInfo resourceCulture;

        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal ApplicationResource()
        {
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.Equals(null, resourceMan))
                {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Application.UI.Resources.ApplicationResource", typeof(ApplicationResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }
        public static string category_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("category_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string cuisine_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("cuisine_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string sort_order_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("sort_order_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string maximum_200_number_of_characters_can_stored
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("maximum_200_number_of_characters_can_stored", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string name_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("name_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string first_name_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("first_name_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string email_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("email_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string password_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("password_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string price_is_required
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("price_is_required", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
        public static string password_and_confirm_password_does_not_match
        {
            get
            {
                try
                {
                    return ResourceManager.GetString("password_and_confirm_password_does_not_match", resourceCulture);
                }
                catch (Exception ex)
                {
                    return ResourceManager.GetString("resource_keyword_not_found", resourceCulture); ;
                }
            }
        }
    }
}
