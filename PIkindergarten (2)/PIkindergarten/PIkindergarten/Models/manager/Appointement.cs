using PIkindergarten.Models.parent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.manager
{
    public class Appointement
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public shift shift { get; set; }
        public Manager manager { get; set; }
        public Parent parent { get; set; }
    }
}