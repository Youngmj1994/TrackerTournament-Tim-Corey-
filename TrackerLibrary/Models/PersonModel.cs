using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
	/// <summary>
	/// this class contains various information about each individual person
	/// like name, number, and email.
	/// </summary>
	public class PersonModel
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }
		public string CellphoneNumber { get; set; }
		public int Id { get; set; }
		public string FullName
		{
			get
			{
				return $"{FirstName} {LastName}";
			}
		}
	}
}
