using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsStudio.Abstractions;
using SportsStudio.Models;
using SportsStudio.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsStudio.Controllers
{
	public class PlayersController : Controller
	{
		private readonly IPlayerRepository _player;
		private readonly IPositionRepository _Position;

		public PlayersController(IPlayerRepository player, IPositionRepository position)
		{
			_player = player;
			_Position = position;
		}
		// GET: /<controller>/
		public ViewResult List()
		{
			PlayersListViewModel playersListViewModel = new PlayersListViewModel();
			playersListViewModel.Players = _player.AllPlayers;

			playersListViewModel.Position = "Defenders";
			return View(playersListViewModel);
		}
	}
}
