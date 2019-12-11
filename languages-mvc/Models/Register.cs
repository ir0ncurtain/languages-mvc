using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace languages_mvc.Models
{
    public class Register
    {
        [Display(Name = "FirstName", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "FirstNameIsRequired")]
        public string FirstName
        {
            get;
            set;
        }
        [Display(Name = "LastName", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "LastNameIsRequired")]
        public string LastName
        {
            get;
            set;
        }
        [Display(Name = "Email", ResourceType = typeof(Resources.Resource))]
        [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "EmailIsRequired")]
        [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "InvalidEmail")]
        public string Email
        {
            get;
            set;
        }
    }
}