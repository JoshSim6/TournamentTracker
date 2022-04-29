using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Indicates the details of a tourney prize
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// The unique identifier (primary key) of the prize.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Indicates what spot a team placed in.
        /// </summary>
        public int PlaceNumber { get; set; }

        /// <summary>
        /// Can include whatever names a tourney admin considers appropriate 
        /// for each placement (e.g. 1st place could be "winner", 2nd could be
        /// "runner up."
        /// </summary>
        public string PlaceName { get; set; }

        /// <summary>
        /// The fixed amount this place earns or zero it if is not used.
        /// </summary>
        public decimal PrizeAmount { get; set; }

        /// <summary>
        /// The number that represents the percentage of
        /// the overall take or zero if it is not used.
        /// The percentage is a fraction of 1.
        /// (this likely varies for 1st, 2nd, 3rd, etc.).
        /// </summary>
        public double PrizePercentage { get; set; }

        public PrizeModel() { }

        public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
        {
            this.PlaceName = placeName;

            int placeNumberValue = 0;
            int.TryParse(placeNumber, out placeNumberValue);
            this.PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount, out prizeAmountValue);
            this.PrizeAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage, out prizePercentageValue);
            this.PrizePercentage = prizePercentageValue;
        }
    }
}
