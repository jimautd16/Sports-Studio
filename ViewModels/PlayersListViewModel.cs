using SportsStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStudio.ViewModels
{
	public class PlayersListViewModel
	{
		public IEnumerable<Players> Players { get; set; }
		public string Position { get; set; }
	}
}
