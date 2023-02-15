using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MVCFormValidationProj.Models;

namespace MVCFormValidationProj.Models
{
    public class MVCFormValidation
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Provide FamilyName")]
        //[Display(Compare(Name,"Please Provide proper FamilyName"))]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "Please Provide Eamil")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public int Phone { get; set; }

        [Required(ErrorMessage = "Zip Code is Required")]
        public int Zipcode { get; set; }

        [Required( ErrorMessage = "Please Provide Age")]
        [Range(25, 45, ErrorMessage = "Age Should be min 16 and max 45")]
        public int Age
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please Provide Gender")]
        public string  Gender
        {
            get;
            set;
        }

    }
}