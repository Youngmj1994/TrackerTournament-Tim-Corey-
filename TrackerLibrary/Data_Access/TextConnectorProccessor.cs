using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextHelpers
{
	public static class TextConnectorProcessor
	{
		
		/// <summary>
		/// give you the full path of the filename you give
		/// </summary>
		/// <param name="fileName"> name of the file you want the filepath of.</param>
		/// <returns>returns a string of the filepath</returns>
		public static string FullFilePath(this string fileName) //prizeModels.csv
		{
			return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
		}
		/// <summary>
		/// loads a file and converts the contents of the .csv into a list of strings
		/// </summary>
		/// <param name="file">Must be a full filepath of the file you want to load</param>
		/// <returns>Returns a list of strings, the strings are the contents of the file.</returns>
		public static List<string> LoadFile(this string file)
		{
			if (!File.Exists(file))
			{
				return new List<string>();
			}

			return File.ReadAllLines(file).ToList();
		}
		/// <summary>
		/// converts a list of string of the contents of a csv file into the PrizeModel
		/// </summary>
		/// <param name="lines">a list of all the contents of the file</param>
		/// <returns>a list of prizemodel objects filled with the contents of the csv file</returns>
		public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
		{
			List<PrizeModel> output = new List<PrizeModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PrizeModel p = new PrizeModel
				{
					//if this data isnt correct, it will crash the program
					Id = int.Parse(cols[0]),
					PlaceNumber = int.Parse(cols[1]),
					PlaceName = cols[2],
					PrizeAmount = decimal.Parse(cols[3]),
					PrizePercentage = double.Parse(cols[4])
				};
				output.Add(p);
			}
			return output;
		}
		/// <summary>
		/// converts a list of string of the contents of a csv file into the PersonModel
		/// </summary>
		/// <param name="lines">a list of all the contents of the file</param>
		/// <returns>a list of PersonModel objects filled with the contents of the csv file</returns>
		public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
		{
			List<PersonModel> output = new List<PersonModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				PersonModel p = new PersonModel
				{
					//if this data isnt correct, it will crash the program
					Id = int.Parse(cols[0]),
					FirstName = cols[1],
					LastName = cols[2],
					EmailAddress = cols[3],
					CellphoneNumber = cols[4]
				};
				output.Add(p);
			}
			return output;

		}
		public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
		{
			//Id, Team Name, list of IDs separated by pipe
			//3, Fred's Team, 1|3|5
			List<TeamModel> output = new List<TeamModel>();
			List<PersonModel> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				TeamModel t = new TeamModel
				{
					Id = int.Parse(cols[0]),
					TeamName = cols[1],
				};

				string[] personIds = cols[2].Split('|');

				foreach (string id in personIds)
				{
					t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
				}

				output.Add(t);
			}

			return output;
		}
		/// <summary>
		/// converts a list of strings into a list of tournament models, an example of how it would look is
		/// id,TournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id - entered Prizes), (rounds - id^id^id|id^id^id|id^id^id)
		/// </summary>
		/// <param name="lines">All the info from the tournament csv file</param>
		/// <returns>Returns a list of all tournaments stored in the csv file, converted to Tournament Models</returns>
		public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
		{
			//id,TournamentName,EntryFee,(id|id|id - Entered Teams),(id|id|id - entered Prizes), (rounds - id^id^id|id^id^id|id^id^id)
			List<TournamentModel> output = new List<TournamentModel>();
			List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
			List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				TournamentModel tm = new TournamentModel
				{
					Id = int.Parse(cols[0]),
					TournamentName = cols[1],
					EntryFee = decimal.Parse(cols[2])
				};

				string[] teamIds = cols[3].Split('|');

				foreach (string Id in teamIds)
				{
					tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(Id)).First());
				}

				if (cols[4].Length > 0)
				{
					string[] prizeIds = cols[4].Split('|');

					foreach (string Id in prizeIds)
					{
						tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(Id)).First());
					}
				}

				//put rounds info into the model
				string[] rounds = cols[5].Split('|');

				foreach (string round in rounds)
				{
					string[] msText = round.Split('^');
					List<MatchupModel> ms = new List<MatchupModel>();

					foreach (string matchupModelTextId in msText)
					{
						ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
					}

					tm.Rounds.Add(ms);
				}

				output.Add(tm);
			}
			return output;
		}
		/// <summary>
		/// This writes the info from all the PrizeModel objects into the csv file
		/// </summary>
		/// <param name="models">list of all the PrizeModel objects</param>
		public static void SaveToPrizeFile(this List<PrizeModel> models)
		{
			List<string> lines = new List<string>();

			foreach (PrizeModel p in models)
			{
				lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
			}

			File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
		}
		/// <summary>
		/// This writes the info from all the PersonModel objects into the csv file
		/// </summary>
		/// <param name="models">list of all the PersonModel objects</param>
		public static void SaveToPersonFile(this List<PersonModel> models)
		{
			List<string> lines = new List<string>();

			foreach (PersonModel p in models)
			{
				lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
			}

			File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
		}
		/// <summary>
		/// Takes the converted list of Team models and saves them into the csv file
		/// </summary>
		/// <param name="models">List of Team models to be saved</param>
		public static void SaveToTeamFile(this List<TeamModel> models)
		{
			List<string> lines = new List<string>();

			foreach (TeamModel t in models)
			{
				lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
			}
			File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
		}
		/// <summary>
		/// Saves the rounds in the tournament model to the csv file
		/// </summary>
		/// <param name="model">A tournament model to be saved </param>
		public static void SaveRoundsToFile(this TournamentModel model)
		{
			//loop through each round
			foreach (List<MatchupModel> round in model.Rounds)
			{
				//loop through each matchup
				foreach (MatchupModel match in round)
				{
					match.SaveMatchupToFile();
				}
			}
		}
		/// <summary>
		/// converts a list of strings into a list of matchupEntryModels
		/// </summary>
		/// <param name="input">Data to fill in the MatchupEntryModels</param>
		/// <returns>Returns a list of matchup entry models full of data</returns>
		public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
		{
			// Id = 0, TeamCompeting = 1, Score = 2, ParentMatchup = 3
			List<MatchupEntryModel> output = new List<MatchupEntryModel>();

			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				MatchupEntryModel me = new MatchupEntryModel
				{
					Id = int.Parse(cols[0])
				};

				if (cols[1].Length == 0)
				{
					me.TeamCompeting = null;
				}
				else
				{
					me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
				}

				me.Score = int.Parse(cols[2]);

				if (int.TryParse(cols[3], out int parentId))
				{
					me.ParentMatchup = LookupMatchupById(parentId);
				}
				else
				{
					me.ParentMatchup = null;
				}

				output.Add(me);
			}

			return output;
		}
		/// <summary>
		/// converts a string of data for matchup entries into a list of matchupEntryModels populated with data
		/// </summary>
		/// <param name="input">Data to go into the matchup entry models</param>
		/// <returns>Returns a list of MatchupEntryModel populated with data from the string</returns>
		private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
		{
			string[] ids = input.Split('|');
			List<MatchupEntryModel> output = new List<MatchupEntryModel>();
			List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
			List<string> matchingEntries = new List<string>();

			foreach (string id in ids)
			{
				foreach (string entry in entries)
				{
					string[] cols = entry.Split(',');

					if (cols[0] == id)
					{
						matchingEntries.Add(entry);
					}
				}
			}
			output = matchingEntries.ConvertToMatchupEntryModels();
			return output;
		}
		/// <summary>
		/// Looks up the team in the csv file containing all teams and returns it as a model
		/// </summary>
		/// <param name="id">The id of the team you are looking for</param>
		/// <returns>A populated model of the team with the Id you are looking for</returns>
		private static TeamModel LookupTeamById(int id)
		{
			List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
			foreach (string team in teams)
			{
				string[] cols = team.Split(',');
				if (cols[0] == id.ToString())
				{
					List<string> matchingTeams = new List<string>
					{
						team
					};
					return matchingTeams.ConvertToTeamModels().First();
				}
			}
			return null;
		}
		public static void UpdateMatchupToFile(this MatchupModel matchup)
		{
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
			MatchupModel oldMatchup = new MatchupModel();
			foreach (MatchupModel m in matchups)
			{
				if (m.Id == matchup.Id)
				{
					oldMatchup = m;
				}
			}
			matchups.Remove(oldMatchup);
			matchups.Add(matchup);

			foreach (MatchupEntryModel entry in matchup.Entries)
			{
				entry.UpdateEntryToFile();
			}

			//save to file second, first is the matchupEntries
			List<string> lines = new List<string>();

			foreach (MatchupModel m in matchups)
			{
				string winner = "";
				if (m.Winner != null)
					winner = m.Winner.Id.ToString();
				lines.Add($"{m.Id},{ConvertMatchupEntriesListToString(m.Entries)},{winner},{m.MatchupRound}");
			}
			File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
		}
		public static void UpdateEntryToFile(this MatchupEntryModel entry)
		{
			List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
			MatchupEntryModel oldEntry = new MatchupEntryModel();

			foreach (MatchupEntryModel e in entries)
			{
				if (e.Id == entry.Id)
				{
					oldEntry = e;
				}
			}
			entries.Remove(oldEntry);
			entries.Add(entry);

			List<string> lines = new List<string>();

			foreach (MatchupEntryModel e in entries)
			{
				string parent = "";
				if (e.ParentMatchup != null)
				{
					parent = e.ParentMatchup.Id.ToString();
				}

				string teamCompeting = "";
				if (e.TeamCompeting != null)
				{
					teamCompeting = e.TeamCompeting.Id.ToString();
				}

				lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent }");
			}

			File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
		}
		/// <summary>
		/// Find the Matchup in the Matchup csv file matching the id given and populates the model and returns it
		/// </summary>
		/// <param name="id">The id of the matchup you want returned</param>
		/// <returns>A populated model of Matchup data</returns>
		private static MatchupModel LookupMatchupById(int id)
		{
			List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

			foreach (string matchup in matchups)
			{
				string[] cols = matchup.Split(',');

				if (cols[0] == id.ToString())
				{
					List<string> matchingMatchups = new List<string>
					{
						matchup
					};
					return matchingMatchups.ConvertToMatchupModels().First();
				}
			}

			return null;
		}
		/// <summary>
		/// Takes a list of strings and populates that data into a list of MatchupModels
		/// </summary>
		/// <param name="lines">List of all the data to be put into the MatchupModels</param>
		/// <returns>A list of MatchupModels that has been populated with data</returns>
		public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
		{
			//id = 0,entries = 1(pipe delemited by id), winner=2, matchupround = 3
			List<MatchupModel> output = new List<MatchupModel>();


			foreach (string line in lines)
			{
				string[] cols = line.Split(',');

				MatchupModel p = new MatchupModel();
				p.Id = int.Parse(cols[0]);
				p.Entries = ConvertStringToMatchupEntryModels(cols[1]);
				if (cols[2].Length == 0)
					p.Winner = null;
				else
					p.Winner = LookupTeamById(int.Parse(cols[2]));
				p.MatchupRound = int.Parse(cols[3]);

				output.Add(p);
			}
			return output;
		}
		/// <summary>
		/// Saves all the matchupModel data to the matchup csv file
		/// </summary>
		/// <param name="model">The data to be saved to the csv file</param>
		public static void SaveMatchupToFile(this MatchupModel model)
		{
			List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

			int currentId = 1;
			if (matchups.Count > 0)
			{
				currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
			}
			model.Id = currentId;

			matchups.Add(model);

			foreach (MatchupEntryModel entry in model.Entries)
			{
				entry.SaveEntryToFile();
			}

			//save to file second, first is the matchupEntries
			List<string> lines = new List<string>();

			foreach (MatchupModel m in matchups)
			{
				string winner = "";
				if (m.Winner != null)
					winner = m.Winner.Id.ToString();
				lines.Add($"{m.Id},{ConvertMatchupEntriesListToString(m.Entries)},{winner},{m.MatchupRound}");
			}
			File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
		}
		/// <summary>
	/// Saves data from the MatchupEntry Model to its csv file
	/// </summary>
	/// <param name="model">The data to be saved to the csv file</param>
		public static void SaveEntryToFile(this MatchupEntryModel entry)
		{
			List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

			int currentId = 1;

			if (entries.Count > 0)
			{
				currentId = entries.OrderByDescending(x => x.Id).First().Id + 1; ;
			}

			entry.Id = currentId;
			entries.Add(entry);

			List<string> lines = new List<string>();
			//id, teamcompeting, score, parent
			foreach (MatchupEntryModel e in entries)
			{
				string parent = "";
				if (e.ParentMatchup != null)
				{
					parent = e.ParentMatchup.Id.ToString();
				}

				string teamCompeting = "";
				if (e.TeamCompeting != null)
				{
					teamCompeting = e.TeamCompeting.Id.ToString();
				}

				lines.Add($"{ e.Id },{ teamCompeting },{ e.Score },{ parent }");
			}

			File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
		}
		/// <summary>
		/// writes all the tournament info to the tournament csv file
		/// </summary>
		/// <param name="models">A list of all the tournamentModels in the programs data</param>
		public static void SaveToTournamentFile(this List<TournamentModel> models)
		{
			List<string> lines = new List<string>();

			foreach (TournamentModel tm in models)
			{
				lines.Add($"{ tm.Id },{ tm.TournamentName },{ tm.EntryFee },{ ConvertTeamListToString(tm.EnteredTeams) },{ ConvertPrizeListToString(tm.Prizes) },{ ConvertRoundsListToString(tm.Rounds) }");
			}

			File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
		}
		/// <summary>
		/// converts a list of lists of Matchups into their ids and puts that into a string seperated by the | icon,
		/// and the individual matchups seperated by the ^ icon
		/// I.E.  Browns^Bengals|Steelers^Patriots
		/// </summary>
		/// <param name="rounds">A List of List of Matchups</param>
		/// <returns>String of |seperated matchups with the individual rounds seperated by ^ icon</returns>
		private static string ConvertRoundsListToString(List<List<MatchupModel>> rounds)
		{
			string output = string.Empty;

			if (rounds.Count == 0)
			{
				return "";
			}

			foreach (List<MatchupModel> r in rounds)
			{
				output += $"{ ConvertMatchupListToString(r) }|";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}
		/// <summary>
		/// Converts a list of Matchups into a string with each indvidual matchup seperated by ^ icon
		/// </summary>
		/// <param name="mathcups">List of matchups to be converted to string</param>
		/// <returns>Returns the converted model as a string with ^ seperating each matchup</returns>
		private static string ConvertMatchupListToString(List<MatchupModel> mathcups)
		{
			string output = string.Empty;

			if (mathcups.Count == 0)
			{
				return "";
			}

			foreach (MatchupModel m in mathcups)
			{
				output += $"{ m.Id }^";
			}

			output = output.Substring(0, output.Length - 1);

			return output.Trim('|');
		}
		/// <summary>
		/// converts a list of Prize into their ids and puts that into a string seperated by the | icon
		/// Example: id = 1,2,3 -> string = 1|2|3
		/// </summary>
		/// <param name="prizes">A list of Prizes that will have their id's converted to a | seperated string</param>
		/// <returns>String of |seperated People Id's</returns>
		private static string ConvertPrizeListToString(List<PrizeModel> prizes)
		{
			string output = "";

			if (prizes.Count == 0)
				return "";

			foreach (PrizeModel p in prizes)
			{
				output += $"{p.Id}|";
			}
			//takes off the last |
			output = output.Substring(0, output.Length - 1);
			return output;
		}
		/// <summary>
		/// takes a list of team models and converts them to one string with | delemiting each team
		/// </summary>
		/// <param name="teams">A list of all the team models you wish to be converted to string</param>
		/// <returns>Returns a | delemited list of string full of teamModel data</returns>
		private static string ConvertTeamListToString(List<TeamModel> teams)
		{
			string output = "";

			if (teams.Count == 0)
				return "";

			foreach (TeamModel p in teams)
			{
				output += $"{p.Id}|";
			}
			//takes off the last |
			output = output.Substring(0, output.Length - 1);
			return output;
		}
		/// <summary>
		/// converts a list of people into their ids and puts that into a string seperated by the | icon
		/// Example: id = 1,2,3 -> string = 1|2|3
		/// </summary>
		/// <param name="people">A list of people that will have their id's converted to a | seperated string</param>
		/// <returns>String of |seperated People Id's</returns>
		private static string ConvertPeopleListToString(List<PersonModel> people)
		{
			string output = "";

			if (people.Count == 0)
				return "";

			foreach (PersonModel p in people)
			{
				output += $"{p.Id}|";
			}
			//takes off the last |
			output = output.Substring(0, output.Length - 1);
			return output;
		}
		/// <summary>
		/// converts a list of Matchup Entries into their ids and puts that into a string seperated by the | icon
		/// Example: id = 1,2,3 -> string = 1|2|3
		/// </summary>
		/// <param name="matchupEntries">List of matchup entries you want converted to a string</param>
		/// <returns>String of matchup entries seperated by | </returns>
		private static string ConvertMatchupEntriesListToString(List<MatchupEntryModel> matchupEntries)
		{
			string output = "";

			if (matchupEntries.Count == 0)
				return "";

			foreach (MatchupEntryModel me in matchupEntries)
			{
				output += $"{me.Id}|";
			}
			//takes off the last |
			output = output.Substring(0, output.Length - 1);
			return output;
		}
	}
}