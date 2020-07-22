using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// represents a list of the teams in the tournament
	/// </summary>
	public class TeamModel
	{
		public int Id { get; set; }
		/// <summary>
		/// list of people in this particular team
		/// </summary>
		public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
		/// <summary>
		/// name of this particular team
		/// </summary>
		public string TeamName { get; set; }


		//this is another way of doing what was done on line 11
		//public TeamModel()
		//{
		//	TeamMembers = new List<Person>();
		//}
	}
}
