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
	public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
	{
		List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
		List<TeamModel> selectedTeams = new List<TeamModel>();
		List<PrizeModel> selectedPrizes = new List<PrizeModel>();
		private void InitLists()
		{
			SelectTeamDropdown.DataSource = null;
			SelectTeamDropdown.DataSource = availableTeams;
			SelectTeamDropdown.DisplayMember = "TeamName";

			TournamentTeamsListBox.DataSource = null;
			TournamentTeamsListBox.DataSource = selectedTeams;
			TournamentTeamsListBox.DisplayMember = "TeamName";

			PrizesListBox.DataSource = null;
			PrizesListBox.DataSource = selectedPrizes;
			PrizesListBox.DisplayMember = "PlaceName";
		}
		public CreateTournamentForm()
		{
			
			InitializeComponent();
			InitLists();
		}
		private void DeletePrizeButton_Click(object sender, EventArgs e)
		{
			PrizeModel p = (PrizeModel)PrizesListBox.SelectedItem;
			if (p!=null)
			{
				selectedPrizes.Remove(p);

				InitLists();
			}
		}
		private void AddTeamButton_Click_1(object sender, EventArgs e)
		{
			TeamModel p = (TeamModel)SelectTeamDropdown.SelectedItem;
			if (p != null)
			{
				availableTeams.Remove(p);
				selectedTeams.Add(p);

				InitLists();
			}
		}
		private void DeletePlayersButton_Click_1(object sender, EventArgs e)
		{
			TeamModel p = (TeamModel)TournamentTeamsListBox.SelectedItem;
			if (p != null)
			{
				selectedTeams.Remove(p);
				availableTeams.Add(p);

				InitLists();
			}
		}
		private void CreatePrizeButton_Click_1(object sender, EventArgs e)
		{
			//call the createPrizeForm
			CreatePrizeForm frm = new CreatePrizeForm(this);
			frm.Show();
		}
		public void PrizeComplete(PrizeModel model)
		{
			//take the prizemodel and put it into our list of selected prizes
			selectedPrizes.Add(model);
			InitLists();
		}
		private void CreateTeamLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
		{
			//call the createPrizeForm
			CreateTeamForm frm = new CreateTeamForm(this);
			frm.Show();
		}
		public void TeamComplete(TeamModel model)
		{
			selectedTeams.Add(model);
			InitLists();
		}
		private void CreateTournamentButton_Click_1(object sender, EventArgs e)
		{
			//Validate data
			decimal fee = 0;

			bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);
			if (fee < 0)
				feeAcceptable = false;
			if (!feeAcceptable)
			{
				MessageBox.Show("You need to enter a valid Entry Fee.",
					"Invalid Fee",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error);
				return;
			}

			// Create our Tournament
			TournamentModel tm = new TournamentModel
			{
				TournamentName = TournamentNameValue.Text,
				EntryFee = fee,
				Prizes = selectedPrizes,
				EnteredTeams = selectedTeams
			};


			//Wire up matchups
			TournamentLogic.CreateRounds(tm);

			//create tournament entry
			//create all of the prize entries
			//create all of the team entires
			GlobalConfig.Connection.CreateTournament(tm);
			//TournamentLogic.UpdateTournamentResults(tm);

			tm.AlertUsersToNewRound();

			TournamentViewerForm frm = new TournamentViewerForm(tm);
			frm.Show();
			this.Close();
		}
		
	}
}
