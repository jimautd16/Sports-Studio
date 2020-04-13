using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SportsStudio.Models;

namespace SportsStudio.Abstractions
{
	public interface IPlayerRepository
	{
		IEnumerable<Players> AllPlayers { get; }
		Players GetPlayersById(int PlayerId);
	}
}
