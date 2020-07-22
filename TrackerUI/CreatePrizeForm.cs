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
using TrackerLibrary.Data_Access;
using TrackerLibrary.Models;

namespace TrackerUI
{
	
	public partial class CreatePrizeForm : Form
	{
		IPrizeRequester callingForm;
		public CreatePrizeForm(IPrizeRequester caller)
		{
			InitializeComponent();

			callingForm = caller;
		}
		private void CreatePrizeButton_Click(object sender, EventArgs e)
		{
			if (ValidateForm())
			{
				PrizeModel model = new PrizeModel(
					PlaceNameValue.Text,
					PlaceNumberValue.Text,
					PrizeAmountValue.Text,
					PrizePercentageValue.Text);

				
				GlobalConfig.Connection.CreatePrize(model);

				callingForm.PrizeComplete(model);

				this.Close();
				

				//PlaceNameValue.Text = "";
				//PlaceNumberValue.Text = "";
				//PrizeAmountValue.Text = "0";
				//PrizePercentageValue.Text = "0";
			}
			else
			{
				MessageBox.Show("This form has invalid information, please try again.");
			}

		}
		private bool ValidateForm()
		{
			bool output = true;
			int placenumber = 0; decimal prizeamount = 0; double prizepercentage = 0.00;

			//checking place num
			bool placeNumberValid = int.TryParse(PlaceNumberValue.Text, out placenumber);
			if(!placeNumberValid)
				output = false;
			if(placenumber<1)
				output = false;

			//checking place name
			if (PlaceNameValue.Text.Length == 0)
				output = false;

			//checking prize amount and prize percentage
			bool prizeAmountValid = decimal.TryParse(PrizeAmountValue.Text, out prizeamount);
			bool prizePercentageValid = double.TryParse(PrizePercentageValue.Text, out prizepercentage);
			if (!prizeAmountValid || !prizePercentageValid)
				output = false;
			if(prizeamount <= 0 && prizepercentage <=0)
				output = false;
			if (prizepercentage < 0 || prizepercentage > 100)
				output = false;

			return output;
		}
	}
}
