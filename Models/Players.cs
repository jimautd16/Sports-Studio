using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStudio.Models
{
	public class Players
	{
		public int PlayerId { get; set; }
		public string ImgUrl { get; set; }
		public string FirstName { get; set; }
		public string Surname { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string PostCode { get; set; }
		public int Age { get; set; }
		public long Phone { get; set; }
		public Position position { get; set; }
		public string fullName
		{ 
			get
			{
				return FirstName + " " + Surname;
			}
				
		}
	}
}
