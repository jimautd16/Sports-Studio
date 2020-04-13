using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStudio.Models
{
	public class MockPositionRepository : IPositionRepository
	{
		public IEnumerable<Position> AllPositions =>
			new List<Position>
			{
				new Position{ PoistionId=1, PositionName="Forward"},
				new Position{ PoistionId=2, PositionName="Midfield"},
				new Position{ PoistionId=3, PositionName="Defender"},
			};
	}
}
