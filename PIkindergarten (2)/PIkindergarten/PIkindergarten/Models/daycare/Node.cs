using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.daycare
{
    public class Node
    {

        protected string name { get; set; }

        protected List<Node> shortestPath { get; set; }

        protected double distance { get; set; }
        protected string Maps { get; set; }






    }
}