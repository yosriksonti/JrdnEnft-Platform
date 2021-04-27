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
        private int doctor { get; set; }
        private int hdebut { get; set; }
        private int mdebut { get; set; }
        private int hfin { get; set; }
        private int mfin { get; set; }

        public virtual ICollection<AppoitementDoc> Apps { get; set; }







    }
}