using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test_request.Models.visitor
{
    public class Visitor
    {
        public String Name { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Password { get; set; }
        public String Image { get; set; }
        public String Cin { get; set; }
        public String Login { get; set; }
        public int phonenumber { get; set; }
        public DateTime Birthday { get; set; }
        public bool isVIP { get; set; }
        public Position position { get; set; }

        public Status status { get; set; }
    }
}