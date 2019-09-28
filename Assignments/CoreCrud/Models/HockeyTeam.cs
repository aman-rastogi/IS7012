using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class HockeyTeam
    {
        [Key]
        public int ID { get; set; }
        public string TeamName { get; set; }
        [DataType(DataType.Date)]
        public DateTime TeamCreationDate { get; set; }
        public bool IsTeamActive { get; set; }
        public decimal Budget { get; set; }
        public int Wins { get; set; }
        public int Loss { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TeamEndDate { get; set; }
        public int GoalsScored { get; set; }
        public int GoalsAgainst { get; set; }
        public int NationalityID { get; set; }
        public Nationality nationality { get; set; }

        [NotMapped]
        public string FlagHelper
        {
            get
            {
                if (NationalityID == 1)
                    return "IND";
                else if (NationalityID == 2)
                    return "AUS";
                else if (NationalityID == 3)
                    return "BEL";
                else if (NationalityID == 4)
                    return "NET";
                else if (NationalityID == 6)
                    return "GER";
                else if (NationalityID == 7)
                    return "ENG";
                else if (NationalityID == 8)
                    return "SPN";
                else if (NationalityID == 9)
                    return "ARG";
                else if (NationalityID == 10)
                    return "JPN";
                else if (NationalityID == 11)
                    return "PAK";
                else if (NationalityID == 12)
                    return "CAN";
                else if (NationalityID == 13)
                    return "CHN";
                else if (NationalityID == 14)
                    return "POL";
                else if (NationalityID == 15)
                    return "ITA";
                else if (NationalityID == 16)
                    return "RUS";
                else if (NationalityID == 17)
                    return "CHL";
                else if (NationalityID == 18)
                    return "UKR";
                else return "NA";
            }
        }
    }
}
