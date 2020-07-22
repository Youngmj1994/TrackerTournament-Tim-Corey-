using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// represents a list of prizes for the tournament
	/// </summary>
	public class PrizeModel
	{
		/// <summary>
		/// the place in the tounament that corresponds to this prize
		/// i.e. 1st place, 2nd place, etc.
		/// </summary>
		public int PlaceNumber { get; set; }
		/// <summary>
		/// the name that corresponds with the place the prize is associated with
		/// i.e. Champion, Runnerup, etc.
		/// </summary>
		public string PlaceName { get; set; }
		/// <summary>
		/// a flat amount of prize money
		/// </summary>
		public decimal PrizeAmount { get; set; }
		/// <summary>
		/// a percentage of the total profit of the tournament
		/// </summary>
		public double PrizePercentage { get; set; }
		/// <summary>
		/// Unique ID for the prize
		/// </summary>
		public int Id { get; set; }

		public PrizeModel()
		{

		}

		public PrizeModel(string placeName, string placeNumber, string prizeAmount, string prizePercentage)
		{
			int placenumtemp = 0; decimal prizeamounttemp = 0; double prizepercentagetemp = 0;

			PlaceName = placeName;

			int.TryParse(placeNumber, out placenumtemp);
			PlaceNumber = placenumtemp;

			decimal.TryParse(prizeAmount, out prizeamounttemp);
			PrizeAmount = prizeamounttemp;

			double.TryParse(prizePercentage, out prizepercentagetemp);
			PrizePercentage = prizepercentagetemp;
		}
	}
}
