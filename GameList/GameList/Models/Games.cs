using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameList.Models
{
    public class Game
    {
        public int ID { get; set; }
        public string GameName { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
    }
}