using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Video_Games_Catalog.Data.Models;

namespace Video_Games_Catalog.Services.IServices
{
    public interface IGameService
    {
        List<Game> GetGames();

        Game GetGame(int id);

        Game UpdateGame(Game game);
    }
}
