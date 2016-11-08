using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameList.Models
{
    public class Platform
   {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlatformID { get; set; }
        public string PlatformName { get; set; }

        public virtual ICollection<Collection> Collections { get; set; }
   }
}