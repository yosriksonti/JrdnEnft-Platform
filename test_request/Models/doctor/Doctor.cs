using test_request.Models.admin;
using test_request.Models.daycare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_request.Models.doctor
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