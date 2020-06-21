using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using Video_Games_Catalog.Data.Models;
using Video_Games_Catalog.Services.IServices;
using Video_Games_Catalog.Services.Services;

namespace Video_Games_Catalog.Controllers
{
    public class GameController : ApiController
    {
        private IGameService _gameService;

        public GameController()
        {
            _gameService = new GameService();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var game = _gameService.GetGames();
            if (game == null)
                return NotFound();
            return Ok(game);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var games = _gameService.GetGame(id);
            if (games == null)
                return NotFound();
            return Ok(games);
        }
        
        [HttpPut]
        public IHttpActionResult Put([FromBody] Game game)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");
            var _game = _gameService.UpdateGame(game);
            if (_game == null)
                return NotFound();
            return Ok(_game);
        }

    }
}
