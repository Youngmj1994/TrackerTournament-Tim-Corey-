using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Data_Access;

namespace TrackerLibrary
{
	public static class GlobalConfig
	{
		public const string PrizesFile = "PrizeModels.csv";
		public const string PeopleFile = "PersonModel.csv";
		public const string TeamFile = "TeamModel.csv";
		public const string TournamentFile = "TournamentModel.csv";
		public const string MatchupFile = "MatchupModels.csv";
		public const string MatchupEntryFile = "MatchupEntriesModels.csv";

		public static string AppKeyLookup(string key)
		{
			return ConfigurationManager.AppSettings[key];
		}
		public static IDataConnection Connection { get; private set; }
		public static void InitConnections(DatabaseType db)
		{
			switch (db)
			{
				case DatabaseType.SQL:
					SQLConnector sql = new SQLConnector();
					Connection = sql;
					break;
				case DatabaseType.TEXTFILE:
					TextConnector text = new TextConnector();
					Connection = text;
					break;
				default:
					break;
			}
		}
		public static string CnnString(string name)
		{
			return ConfigurationManager.ConnectionStrings[name].ConnectionString;
		}
	}
}
