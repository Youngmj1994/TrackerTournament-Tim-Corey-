using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.Data_Access
{
	/// <summary>
	/// Interface to deal with data connection of any kind
	/// Whether that be sql, txt file, mysql, etc. this will handle
	/// all the stuff that has to be in the data connection.
	/// </summary>
	public interface IDataConnection
	{
		void CreatePrize(PrizeModel model);
		void CreatePerson(PersonModel model);
		void CreateTeam(TeamModel model);
		void CreateTournament(TournamentModel model);
		void UpdateMatchup(MatchupModel model);
		List<PersonModel> GetPerson_All();
		List<TeamModel> GetTeam_All();
		List<TournamentModel> GetTournament_All();
		void CompleteTournament(TournamentModel model);

	}
}
