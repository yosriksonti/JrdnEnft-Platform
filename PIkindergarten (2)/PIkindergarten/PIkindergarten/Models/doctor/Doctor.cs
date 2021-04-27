using PIkindergarten.Models.admin;
using PIkindergarten.Models.daycare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.doctor
{
    public class Doctor : ProfilAdmin
    {
        private bool isActive { get; set; }

        public virtual Daycare daycare { get; set; }
        public ICollection<HealthRecord> healthRecords { get; set; }

        public ICollection<DoctorAvailability> availabilities { get; set; }


        public Doctor()
        {

        }




    }
}