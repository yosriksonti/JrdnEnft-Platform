using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.manager
{
    public class Evenement
    {
        public int id { get; set; }
        public String name { get; set; }
        public String type { get; set; }
        public DateTime date { get; set; }
        public String image { get; set; }
        private String nbParticipant { get; set; }
        private String atelier { get; set; }
    }
}