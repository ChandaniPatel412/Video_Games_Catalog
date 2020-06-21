using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Video_Games_Catalog.Data.Models;
using Video_Games_Catalog.Services.IServices;

namespace Video_Games_Catalog.Services.Services
{
    public class GameService : IGameService
    {
        private GameCatalogDBContext _dbContext = new GameCatalogDBContext();

        public List<Game> GetGames()
        {
            return _dbContext.Games.ToList();
        }

        public Game GetGame(int id)
        {
            return _dbContext.Games.Where(x => x.GameId == id).FirstOrDefault();
        }

        public Game UpdateGame(Game game)
        {
            var _game = GetGame(game.GameId);

            if (_game != null)
            {
                _game.GameName = game.GameName;
                _game.GameDetail = game.GameDetail;
                _game.Price = game.Price;
                _game.AuthorName = game.AuthorName;
                _game.GameImage = game.GameImage;
                _dbContext.SaveChanges();
            }
            else
            {
                return null;
            }

            return _game;
        }
    }
}