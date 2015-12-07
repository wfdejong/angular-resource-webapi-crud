using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularTutorial.Models
{
	public class Suitcase
	{
		public long Id { get; set; }
		public bool Locked { get; set; }
		public int Wheels { get; set; }
	}
}