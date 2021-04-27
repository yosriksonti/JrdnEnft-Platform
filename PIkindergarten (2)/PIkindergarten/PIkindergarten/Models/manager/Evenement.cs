using PIkindergarten.Models.parent;
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
        public int nbParticipant { get; set; }
        public String atelier { get; set; }
        public Manager manager { get; set; }
        public Parent parent { get; set; }

        public Evenement(int id ,String name, String type, DateTime date, String image, int nbParticipant, String atelier, Manager manager)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.date = date;
            this.image = image;
            this.nbParticipant = nbParticipant;
            this.atelier = atelier;
            this.manager = manager;

        }

        public Evenement(int id, Manager manager)
        {
            this.id = id;
         
            this.manager = manager;

        }
        public Evenement()
        {
           

        }
    }
}