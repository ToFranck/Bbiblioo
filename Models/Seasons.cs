using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bbiblioo.Models
{
    public class Seasons
    {

        private Int32 season_id;
        private DateTime seanson_start;
        private DateTime season_end;
        private String season_description; 



        public Int32 Season_id { get; set; }
        public DateTime Season_start { get; set; }
        public DateTime Season_end { get; set; }
        public String Season_description { get; set; }

        public void create_season()
        {

        }

    }
}
