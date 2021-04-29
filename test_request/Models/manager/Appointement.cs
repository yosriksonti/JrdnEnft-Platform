using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_request.Models.manager
{
    public class Appointement
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public Manager manager { get; set; }
    }
}