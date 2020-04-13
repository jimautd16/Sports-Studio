using SportsStudio.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStudio.Models
{
	public class MockPlayerRepoistory : IPlayerRepository
	{
		private readonly IPositionRepository _positionRepository = new MockPositionRepository();
		public IEnumerable<Players> AllPlayers =>
			new List<Players>
			{
				new Players { PlayerId=1, FirstName="Eric", Surname="Cantona", ImgUrl="~/Images/avatar.png", Address1="Old Traffold", Address2="Manchester", Age=40, Phone=07986123456, position= _positionRepository.AllPositions.ToList()[0], PostCode="BT12 7PJ"},
				new Players { PlayerId=2, FirstName="David", Surname="Beckham", ImgUrl="~/Images/avatar.png", Address1="Old Traffold", Address2="Manchester", Age=30, Phone=07986456122, position= _positionRepository.AllPositions.ToList()[1], PostCode="BT12 7PJ" },
				new Players { PlayerId=3, FirstName="Paul", Surname="Scholes", ImgUrl="~/Images/avatar.png", Address1="Old Traffold", Address2="Manchester", Age=40, Phone=07986123456, position= _positionRepository.AllPositions.ToList()[2], PostCode="BT12 7PJ"},
				new Players { PlayerId=4, FirstName="Jaap", Surname="Stam",ImgUrl="~/Images/avatar.png", Address1="Old Traffold", Address2="Manchester", Age=40, Phone=07986123456, position= _positionRepository.AllPositions.ToList()[2], PostCode="BT12 7PJ"}
			};

		public Players GetPlayersById (int playerid)
		{
			return AllPlayers.FirstOrDefault(p => p.PlayerId == playerid);
		}
	}
}
