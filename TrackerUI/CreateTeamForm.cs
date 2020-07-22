using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
	public partial class CreateTeamForm : Form
	{
		private List<PersonModel> availableTeamMembers = new List<PersonModel>();
		private List<PersonModel> selectedTeamMembers = new List<PersonModel>();

		private ITeamRequester callingForm;
		public CreateTeamForm(ITeamRequester caller)
		{
			InitializeComponent();
			callingForm = caller;
			//CreateSampleData();
			LoadListData();
			WireUpLists();
		}
		private void LoadListData()
		{
			availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
		}
		private void WireUpLists()
		{
			SelectTeamMemberDropdown.DataSource = null;
			SelectTeamMemberDropdown.DataSource = availableTeamMembers;
			SelectTeamMemberDropdown.DisplayMember = "FullName";

			TeamMembersListBox.DataSource = null;
			TeamMembersListBox.DataSource = selectedTeamMembers;
			TeamMembersListBox.DisplayMember = "FullName";
		}
		private void AddTeamButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)SelectTeamMemberDropdown.SelectedItem;
			if (p != null)
			{
				availableTeamMembers.Remove(p);
				selectedTeamMembers.Add(p);

				WireUpLists();
			}
		}
		private void CreateMemberButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				//fill the model with data from the user
				PersonModel p = new PersonModel
				{
					FirstName = FirstNameValue.Text,
					LastName = LastNameValue.Text,
					EmailAddress = EmailValue.Text,
					CellphoneNumber = CellphoneValue.Text
				};

				//wire that data up to the list box
				GlobalConfig.Connection.CreatePerson(p);
				selectedTeamMembers.Add(p);
				WireUpLists();
				
				//clear the data the user entered
				FirstNameValue.Text = "";
				LastNameValue.Text = "";
				EmailValue.Text = "";
				CellphoneValue.Text = "";
			}
			else
				MessageBox.Show("You need to fill in all the fields dawg");
		}
		private bool ValidateForm()
		{
			bool output = true;
			if(FirstNameValue.TextLength == 0)
				output = false;

			if (LastNameValue.TextLength == 0)
				output = false;

			if (EmailValue.TextLength == 0)
				output = false;

			if (CellphoneValue.TextLength == 0)
				output = false;

			return output;
		}
		private void RemoveSelectedButton_Click(object sender, EventArgs e)
		{
			PersonModel p = (PersonModel)TeamMembersListBox.SelectedItem;
			if (p != null)
			{
				selectedTeamMembers.Remove(p);
				availableTeamMembers.Add(p);

				WireUpLists();
			}
		}
		private void CreateTeamButton_Click(object sender, EventArgs e)
		{
			TeamModel t = new TeamModel();

			t.TeamName = TeamNameValue.Text;
			t.TeamMembers = selectedTeamMembers;

			GlobalConfig.Connection.CreateTeam(t);
			callingForm.TeamComplete(t);
			this.Close();
			
		}
	}
}
