using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.doctor
{
    public class DoctorAvailability
    {
        [Key]
        public int id { get; set; }
        public virtual Doctor Doc { get; set; }
        public int doctor { get; set; }
        public int hdebut { get; set; }
        public int mdebut { get; set; }
        public int hfin { get; set; }
        public int mfin { get; set; }

        //public virtual ICollection<AppoitementDoc> Apps { get; set; }







    }
}