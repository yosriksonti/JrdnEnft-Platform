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
        private int id { get; set; }

        public DateTime day { get; set; }

        public virtual Parent parent { get; set; }

        public virtual DoctorAvailability availability { get; set; }

        private int idParent { get; set; }
        private long idAvaibility { get; set; }
        private bool isConfirmed { get; set; }
    }
}