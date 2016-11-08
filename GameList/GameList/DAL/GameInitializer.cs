using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GameList.Models;
using System.Data.Entity;

namespace GameList.DAL
{
    public class GameInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameContext>
    {
        protected override void Seed(GameContext context)
        {
            var Games = new List<Game>
            {
            new Game{GameName="Carson"},
            new Game{GameName="Meredith"},
            new Game{GameName="Arturo"},
            new Game{GameName="Gytis"},
            new Game{GameName="Yan"},
            new Game{GameName="Peggy"},
            new Game{GameName="Laura"},
            new Game{GameName="Nino"}
            };

            Games.ForEach(s => context.Games.Add(s));
            context.SaveChanges();
            var Platforms = new List<Platform>
            {
            new Platform{PlatformID=1050,PlatformName="Chemistry"},
            new Platform{PlatformID=4022,PlatformName="Microeconomics"},
            new Platform{PlatformID=4041,PlatformName="Macroeconomics"},
            new Platform{PlatformID=1045,PlatformName="Calculus"},
            new Platform{PlatformID=3141,PlatformName="Trigonometry"},
            new Platform{PlatformID=2021,PlatformName="Composition"},
            new Platform{PlatformID=2042,PlatformName="Literature"}
            };
            Platforms.ForEach(s => context.Platforms.Add(s));
            context.SaveChanges();
            var Collections = new List<Collection>
            {
            new Collection{GameID=1,PlatformID=1050,Value=Value.A},
            new Collection{GameID=1,PlatformID=4022,Value=Value.C},
            new Collection{GameID=1,PlatformID=4041,Value=Value.B},
            new Collection{GameID=2,PlatformID=1045,Value=Value.B},
            new Collection{GameID=2,PlatformID=3141,Value=Value.F},
            new Collection{GameID=2,PlatformID=2021,Value=Value.F},
            new Collection{GameID=3,PlatformID=1050},
            new Collection{GameID=4,PlatformID=1050,},
            new Collection{GameID=4,PlatformID=4022,Value=Value.F},
            new Collection{GameID=5,PlatformID=4041,Value=Value.C},
            new Collection{GameID=6,PlatformID=1045},
            new Collection{GameID=7,PlatformID=3141,Value=Value.A},
            };
            Collections.ForEach(s => context.Collections.Add(s));
            context.SaveChanges();
        }
    }
}