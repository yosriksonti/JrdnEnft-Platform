using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.admin
{
    public class ProfilAdmin
    {

        private int id;
        [StringLength(10)]
        protected String Name { get; set; }
        [StringLength(10)]
        protected String Lastname { get; set; }

        [DataType(DataType.EmailAddress), EmailAddress, Required]

        protected String Email { get; set; }
        protected String Address { get; set; }

        [DataType(DataType.Password), MinLength(8)]
        protected String Password { get; set; }
        protected String Image { get; set; }
        [Required, MinLength(8), MaxLength(8)]
        protected String Cin { get; set; }
        protected String Login { get; set; }
        [Display(Name = "phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        protected int phonenumber { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        [Display(Name = "Date of Birth")]
        protected DateTime Birthday { get; set; }
        public RoleAdmin roleadmin { get; set; }
    }
}