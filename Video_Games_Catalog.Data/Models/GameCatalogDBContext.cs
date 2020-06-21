using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Video_Games_Catalog.Data.Models
{
    public class GameCatalogDBContext : DbContext
    {
        public GameCatalogDBContext()
        {

        }
        
        public DbSet<Game> Games { get; set; }
    }
}