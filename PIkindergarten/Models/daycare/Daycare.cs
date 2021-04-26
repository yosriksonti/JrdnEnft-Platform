using PIkindergarten.Models.admin;
using PIkindergarten.Models.doctor;
using PIkindergarten.Models.manager;
using PIkindergarten.Models.parent;
using PIkindergarten.Models.visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.daycare
{
	public class Daycare
	{


		protected int id { get; set; }
		protected string daycareName { get; set; }
		protected string region { get; set; }
		protected string logo { get; set; }
		protected string reputation { get; set; }
		protected int nbReclamations { get; set; }
		protected Doctor doctor { get; set; }
		protected Manager manager { get; set; }
		protected List<Favorite> favorites { get; set; }
		protected Position position { get; set; }
		protected List<Parent> parents { get; set; }
		protected List<Post> posts { get; set; }
		protected List<HealthRecord> healthRecords { get; set; }
		protected Director director { get; set; }


	}
}