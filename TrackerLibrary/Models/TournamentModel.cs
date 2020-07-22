using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// represents one tournament
	/// </summary>
	public class TournamentModel
	{
		public event EventHandler<DateTime> OnTournamentComplete;
		public int Id { get; set; }
		public string TournamentName { get; set; }
		/// <summary>
		/// amount of money that must be paid to enter the tournament
		/// </summary>
		public decimal EntryFee { get; set; }
		/// <summary>
		/// list of all the teams competeing in the tournament
		/// </summary>
		public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
		/// <summary>
		/// list of all prizes for this tournament
		/// </summary>
		public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
		/// <summary>
		/// tournament bracket, who plays who and when
		/// i.e. Round 1 (Browns, Bengals), (ravens, steelers)/ round 2 (Browns,Steelers)
		/// </summary>
		public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

		public void CompleteTournament()
		{
			OnTournamentComplete?.Invoke(this, DateTime.Now);
		}
	}
}
