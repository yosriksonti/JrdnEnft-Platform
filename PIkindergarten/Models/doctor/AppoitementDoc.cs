using PIkindergarten.Models.parent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.doctor
{
    public class AppoitementDoc
    {
        [Key]
        public int id { get; set; }

        public DateTime day { get; set; }

        public virtual Parent parent { get; set; }

        public virtual DoctorAvailability availability { get; set; }

        public int idParent { get; set; }
        public int idAvaibility { get; set; }
        public bool isConfirmed { get; set; }
    }
}