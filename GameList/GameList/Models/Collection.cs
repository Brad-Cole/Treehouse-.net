using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameList.Models
{
    public enum Value
    {
       A, B, C, D, F
    }
    public class Collection
    {
        public int CollectionID { get; set; }
        public int PlatformID { get; set; }
        public int GameID { get; set; }
        public Value? Value { get; set; }

        public virtual Platform Platform { get; set; }
        public virtual Game Game { get; set; }
    }
}