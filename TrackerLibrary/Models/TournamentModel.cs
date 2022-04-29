using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents the highest level view of the tournament details (i.e. the details
    /// involved in drawing a typical tournament board).
    /// </summary>
    public class TournamentModel
    {
        /// <summary>
        /// The tournament name (i.e. "Ping Pong Tournament").
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// Represents the dollar amount required from each team for entry
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// Represents a list of all teams competing in a given tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Represents the different prizes awarded to those who finished the 
        /// tournament in top-finishing spots
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Represents two rounds in a tournament?
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
