using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_request.Models.admin
{
    public class ProfilAdmin
    {

        public int id;
        [StringLength(10)]
        public String Name { get; set; }
        [StringLength(10)]
        public String Lastname { get; set; }

        [DataType(DataType.EmailAddress), EmailAddress, Required]

        public String Email { get; set; }
        public String Address { get; set; }

        
        public String Password { get; set; }
        public String Image { get; set; }
        [Required, MinLength(8), MaxLength(8)]
        public String Cin { get; set; }
        public String Login { get; set; }
        [Display(Name = "phone number")]
        [DataType(DataType.PhoneNumber)]
       
        public int phonenumber { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Invalid Date Format")]
        [Display(Name = "Date of Birth")]
        public DateTime Birthday { get; set; }
        public RoleAdmin roleadmin { get; set; }
    }
}