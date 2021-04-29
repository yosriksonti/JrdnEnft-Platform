using test_request.Models.daycare;
using test_request.Models.parent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace test_request.Models.admin
{
    public class Reclamation
    {
        [Display(Name = "Reclamation name")]
        [StringLength(5)]
        public String RecName { get; set; }
        [Display(Name = "description")]
        [Required]
        [StringLength(100)]

        public String descripRec { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DateRec { get; set; }
        public RoleRec rolerec { get; set; }
        protected List<Parent> parents { get; set; }
        protected List<Daycare> daycares { get; set; }

    }
}