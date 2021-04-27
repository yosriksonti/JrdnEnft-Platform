using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PIkindergarten.Models.daycare
{
	public class Post
	{

		protected int id;


		protected Daycare daycare { get; set; }

		protected string media { get; set; }
		protected string title { get; set; }
		protected string body { get; set; }


		protected int likes { get; set; }
		protected int dislikes { get; set; }

		protected DateTime creationDate { get; set; }
		protected DateTime modificationDate { get; set; }




	}
}