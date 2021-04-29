using test_request.Models.daycare;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_request.Models.visitor
{
    public class Favorite
    {
        public int id { get; set; }
        public Visitor visitor { get; set; }
        public List<Daycare> daycares { get; set; }
    }
}