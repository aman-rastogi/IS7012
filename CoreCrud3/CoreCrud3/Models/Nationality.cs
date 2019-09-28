using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud3.Models
{
    public class Nationality
    {
        public int ID { get; set; }
        public string CountryName { get; set; }

        public ICollection<HockeyTeam> HockeyTeams { get; set; }
    }
}
