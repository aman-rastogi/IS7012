using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class HockeyTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        [DataType(DataType.Date)]
        public DateTime TeamCreationDate { get; set; }
        public bool IsTeamActive { get; set; }
        public decimal Budget { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TeamEndDate { get; set; }
        public int NationalityID { get; set; }
        public Nationality nationality;

    }
}
