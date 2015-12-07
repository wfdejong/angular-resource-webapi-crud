using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using AngularTutorial.Models;

namespace AngularTutorial
{
	public class Singleton
	{
		private static Singleton instance;

		private Singleton() { }

		public static Singleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
				return instance;
			}
		}

		public List<Suitcase> Suitcases { get; set; } 
	}
}