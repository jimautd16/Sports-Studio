﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStudio.Models
{
	public class Position
	{
		public int PoistionId { get; set; }
		public string PositionName { get; set; }
		public List<Players> players { get; set; }
	}
}
