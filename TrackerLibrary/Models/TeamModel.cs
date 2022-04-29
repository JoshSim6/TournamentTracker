using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one team.
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// Represents the team (members on a team)
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        /// <summary>
        /// Represents a team name.
        /// </summary>
        public string TeamName { get; set; }
    }
}
