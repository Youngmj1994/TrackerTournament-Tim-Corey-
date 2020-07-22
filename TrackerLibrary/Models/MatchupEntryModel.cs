using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// represents one team in a matchup
	/// </summary>
	public class MatchupEntryModel
	{
		public int ParentMatchupId { get; set; }
		public int TeamCompetingId { get; set; }
		public int Id { get; set; }
		/// <summary>
		/// Represents one team in the matchup
		/// </summary>
		public TeamModel TeamCompeting { get; set; }
		/// <summary>
		/// represents score for this particular team
		/// </summary>
		public int Score { get; set; }
		/// <summary>
		/// represents the matchup that this
		/// team came from as the winner.
		/// </summary>
		public MatchupModel ParentMatchup { get; set; }

	}
}
