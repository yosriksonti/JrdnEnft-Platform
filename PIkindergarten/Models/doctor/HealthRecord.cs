using PIkindergarten.Models.daycare;
using PIkindergarten.Models.parent;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.doctor
{
    public class HealthRecord
    {
        [Key]
        public int id { get; set; }

        public DateTime AppointDate { get; set; }
        private string description { get; set; }
        private string etat { get; set; }
        public string images { get; set; }

        public virtual Daycare daycare { get; set; }
        public virtual Doctor doc { get; set; }

        public virtual Parent parent { get; set; }

    }
}