using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.Data_Access
{
	public class TextConnector : IDataConnection
	{
		/// <summary>
		/// Takes a prizeModel and creates a new entry in the csv database and updates the input models Id value.
		/// </summary>
		/// <param name="model">The prizeModel you want added to the csv file</param>
		/// <returns>Returns the model with the updated Id</returns>
		public void CreatePrize(PrizeModel model)
		{
			//load the text file and convert the text to list<prizemodel>
			List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

			//find the max id
			int currentMaxId = 1;
			if(prizes.Count > 0)
				currentMaxId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
			model.Id = currentMaxId;

			//add the new record with the new id (max + 1)
			prizes.Add(model);

			//convert the prizes to list<string>
			//save the list<string> to the text file
			prizes.SaveToPrizeFile();
		}
		public void CreatePerson(PersonModel model)
		{
			//load the text file and convert the text to list<prizemodel>
			List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

			//find the max id
			int currentMaxId = 1;
			if (people.Count > 0)
				currentMaxId = people.OrderByDescending(x => x.Id).First().Id + 1;
			model.Id = currentMaxId;

			//add the new record with the new id (max + 1)
			people.Add(model);

			//convert the prizes to list<string>
			//save the list<string> to the text file
			people.SaveToPersonFile();
		}
		public List<PersonModel> GetPerson_All()
		{
			return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();
		}
		public void CreateTeam(TeamModel model)
		{
			List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
			
			//find the max id
			int currentMaxId = 1;
			if (teams.Count > 0)
				currentMaxId = teams.OrderByDescending(x => x.Id).First().Id + 1;
			model.Id = currentMaxId;

			teams.Add(model);

			teams.SaveToTeamFile();
		}
		public List<TeamModel> GetTeam_All()
		{
			return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
		}
		public void CreateTournament(TournamentModel model)
		{
			//TODO - cxheck out TextConnector/CreateTournament
			List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
			int currentId = 1;
			if(tournaments.Count > 0)
			{
				currentId = tournaments.OrderByDescending(x => x.Id).First().Id + 1;
			}

			model.Id = currentId;
			model.SaveRoundsToFile();
			tournaments.Add(model);

			tournaments.SaveToTournamentFile();
			TournamentLogic.UpdateTournamentResults(model);
		}
		public List<TournamentModel> GetTournament_All()
		{
			return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
		}
		public void UpdateMatchup(MatchupModel model)
		{
			//TODO - cxheck out TextConnector/UpdateMatchup
			model.UpdateMatchupToFile();
		}
		public void CompleteTournament(TournamentModel model)
		{
			List<TournamentModel> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
			tournaments.Remove(model);
			tournaments.SaveToTournamentFile();
			TournamentLogic.UpdateTournamentResults(model);
		}
	}
}
