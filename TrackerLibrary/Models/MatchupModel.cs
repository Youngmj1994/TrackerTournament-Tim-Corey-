using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// represents one match in the tournament
	/// </summary>
	public class MatchupModel
	{
		public int Id { get; set; }
		/// <summary>
		/// represents a list of matchups between teams
		/// </summary>
		public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
		/// <summary>
		/// the id from the database that will be used to identify the winner
		/// </summary>
		public int WinnerId { get; set; }
		/// <summary>
		/// the team that is the winner of the mathcup
		/// </summary>
		public TeamModel Winner { get; set; }
		/// <summary>
		/// this matchup's round in the tournament
		/// </summary>
		public int MatchupRound { get; set; }

		public string DisplayName { 
			get
			{
				string output = "";
				foreach (MatchupEntryModel me in Entries)
				{
					if (me.TeamCompeting != null)
					{
						if (output.Length == 0)
							output = me.TeamCompeting.TeamName;
						else
							output += $" vs. {me.TeamCompeting.TeamName}";
					}
					else
					{
						output = "Matchup Not Yet Determined";
						break;
					}
				}
				return output;
			} 
		}
	}
}
