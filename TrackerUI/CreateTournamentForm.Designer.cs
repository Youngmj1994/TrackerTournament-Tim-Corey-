using System;

namespace TrackerUI
{
	partial class CreateTournamentForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CreateTournamentLabel = new System.Windows.Forms.Label();
			this.TournamentNameValue = new System.Windows.Forms.TextBox();
			this.TournamentNameLabel = new System.Windows.Forms.Label();
			this.EntryFeeValue = new System.Windows.Forms.TextBox();
			this.EntryFeeLabel = new System.Windows.Forms.Label();
			this.SelectTeamDropdown = new System.Windows.Forms.ComboBox();
			this.SelectTeamLabel = new System.Windows.Forms.Label();
			this.CreateTeamLinkLabel = new System.Windows.Forms.LinkLabel();
			this.AddTeamButton = new System.Windows.Forms.Button();
			this.CreatePrizeButton = new System.Windows.Forms.Button();
			this.TournamentTeamsListBox = new System.Windows.Forms.ListBox();
			this.TeamsPlayersLabel = new System.Windows.Forms.Label();
			this.DeletePlayersButton = new System.Windows.Forms.Button();
			this.DeletePrizeButton = new System.Windows.Forms.Button();
			this.PrizesLabel = new System.Windows.Forms.Label();
			this.PrizesListBox = new System.Windows.Forms.ListBox();
			this.CreateTournamentButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CreateTournamentLabel
			// 
			this.CreateTournamentLabel.AutoSize = true;
			this.CreateTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateTournamentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreateTournamentLabel.Location = new System.Drawing.Point(13, 9);
			this.CreateTournamentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.CreateTournamentLabel.Name = "CreateTournamentLabel";
			this.CreateTournamentLabel.Size = new System.Drawing.Size(190, 30);
			this.CreateTournamentLabel.TabIndex = 1;
			this.CreateTournamentLabel.Text = "Create Tournament";
			// 
			// TournamentNameValue
			// 
			this.TournamentNameValue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TournamentNameValue.Location = new System.Drawing.Point(38, 91);
			this.TournamentNameValue.Margin = new System.Windows.Forms.Padding(4);
			this.TournamentNameValue.Name = "TournamentNameValue";
			this.TournamentNameValue.Size = new System.Drawing.Size(236, 32);
			this.TournamentNameValue.TabIndex = 10;
			// 
			// TournamentNameLabel
			// 
			this.TournamentNameLabel.AutoSize = true;
			this.TournamentNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.TournamentNameLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TournamentNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TournamentNameLabel.Location = new System.Drawing.Point(24, 64);
			this.TournamentNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TournamentNameLabel.Name = "TournamentNameLabel";
			this.TournamentNameLabel.Size = new System.Drawing.Size(164, 23);
			this.TournamentNameLabel.TabIndex = 9;
			this.TournamentNameLabel.Text = "Tournament Name";
			this.TournamentNameLabel.Click += new System.EventHandler(this.TeamoneScoreLabel_Click);
			// 
			// EntryFeeValue
			// 
			this.EntryFeeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.EntryFeeValue.Location = new System.Drawing.Point(130, 143);
			this.EntryFeeValue.Name = "EntryFeeValue";
			this.EntryFeeValue.Size = new System.Drawing.Size(100, 32);
			this.EntryFeeValue.TabIndex = 12;
			this.EntryFeeValue.Text = "0";
			this.EntryFeeValue.TextChanged += new System.EventHandler(this.EntryFeeValue_TextChanged);
			// 
			// EntryFeeLabel
			// 
			this.EntryFeeLabel.AutoSize = true;
			this.EntryFeeLabel.BackColor = System.Drawing.Color.Transparent;
			this.EntryFeeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.EntryFeeLabel.Location = new System.Drawing.Point(34, 145);
			this.EntryFeeLabel.Name = "EntryFeeLabel";
			this.EntryFeeLabel.Size = new System.Drawing.Size(90, 23);
			this.EntryFeeLabel.TabIndex = 11;
			this.EntryFeeLabel.Text = "Entry Fee";
			// 
			// SelectTeamDropdown
			// 
			this.SelectTeamDropdown.FormattingEnabled = true;
			this.SelectTeamDropdown.Location = new System.Drawing.Point(40, 276);
			this.SelectTeamDropdown.Name = "SelectTeamDropdown";
			this.SelectTeamDropdown.Size = new System.Drawing.Size(341, 31);
			this.SelectTeamDropdown.TabIndex = 14;
			this.SelectTeamDropdown.SelectedIndexChanged += new System.EventHandler(this.RoundDropdown_SelectedIndexChanged);
			// 
			// SelectTeamLabel
			// 
			this.SelectTeamLabel.AutoSize = true;
			this.SelectTeamLabel.BackColor = System.Drawing.Color.Transparent;
			this.SelectTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.SelectTeamLabel.Location = new System.Drawing.Point(36, 250);
			this.SelectTeamLabel.Name = "SelectTeamLabel";
			this.SelectTeamLabel.Size = new System.Drawing.Size(110, 23);
			this.SelectTeamLabel.TabIndex = 13;
			this.SelectTeamLabel.Text = "Select Team";
			this.SelectTeamLabel.Click += new System.EventHandler(this.Round_Click);
			// 
			// CreateTeamLinkLabel
			// 
			this.CreateTeamLinkLabel.AutoSize = true;
			this.CreateTeamLinkLabel.Location = new System.Drawing.Point(152, 250);
			this.CreateTeamLinkLabel.Name = "CreateTeamLinkLabel";
			this.CreateTeamLinkLabel.Size = new System.Drawing.Size(114, 23);
			this.CreateTeamLinkLabel.TabIndex = 15;
			this.CreateTeamLinkLabel.TabStop = true;
			this.CreateTeamLinkLabel.Text = "Create Team";
			this.CreateTeamLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateTeamLinkLabel_LinkClicked_1);
			// 
			// AddTeamButton
			// 
			this.AddTeamButton.AllowDrop = true;
			this.AddTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.AddTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.AddTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddTeamButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AddTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.AddTeamButton.Location = new System.Drawing.Point(46, 319);
			this.AddTeamButton.Name = "AddTeamButton";
			this.AddTeamButton.Size = new System.Drawing.Size(160, 42);
			this.AddTeamButton.TabIndex = 16;
			this.AddTeamButton.Text = "Add Team";
			this.AddTeamButton.UseVisualStyleBackColor = true;
			this.AddTeamButton.Click += new System.EventHandler(this.AddTeamButton_Click_1);
			// 
			// CreatePrizeButton
			// 
			this.CreatePrizeButton.AllowDrop = true;
			this.CreatePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CreatePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.CreatePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.CreatePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreatePrizeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreatePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreatePrizeButton.Location = new System.Drawing.Point(46, 397);
			this.CreatePrizeButton.Name = "CreatePrizeButton";
			this.CreatePrizeButton.Size = new System.Drawing.Size(160, 42);
			this.CreatePrizeButton.TabIndex = 17;
			this.CreatePrizeButton.Text = "Create Prize";
			this.CreatePrizeButton.UseVisualStyleBackColor = true;
			this.CreatePrizeButton.Click += new System.EventHandler(this.CreatePrizeButton_Click_1);
			// 
			// TournamentTeamsListBox
			// 
			this.TournamentTeamsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TournamentTeamsListBox.FormattingEnabled = true;
			this.TournamentTeamsListBox.ItemHeight = 23;
			this.TournamentTeamsListBox.Location = new System.Drawing.Point(411, 35);
			this.TournamentTeamsListBox.Name = "TournamentTeamsListBox";
			this.TournamentTeamsListBox.Size = new System.Drawing.Size(337, 163);
			this.TournamentTeamsListBox.TabIndex = 18;
			this.TournamentTeamsListBox.SelectedIndexChanged += new System.EventHandler(this.TournamentPlayersListBox_SelectedIndexChanged);
			// 
			// TeamsPlayersLabel
			// 
			this.TeamsPlayersLabel.AllowDrop = true;
			this.TeamsPlayersLabel.AutoSize = true;
			this.TeamsPlayersLabel.BackColor = System.Drawing.Color.Transparent;
			this.TeamsPlayersLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TeamsPlayersLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TeamsPlayersLabel.Location = new System.Drawing.Point(407, 9);
			this.TeamsPlayersLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.TeamsPlayersLabel.Name = "TeamsPlayersLabel";
			this.TeamsPlayersLabel.Size = new System.Drawing.Size(139, 23);
			this.TeamsPlayersLabel.TabIndex = 19;
			this.TeamsPlayersLabel.Text = "Teams / Players";
			// 
			// DeletePlayersButton
			// 
			this.DeletePlayersButton.AllowDrop = true;
			this.DeletePlayersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.DeletePlayersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.DeletePlayersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.DeletePlayersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeletePlayersButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeletePlayersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.DeletePlayersButton.Location = new System.Drawing.Point(754, 76);
			this.DeletePlayersButton.Name = "DeletePlayersButton";
			this.DeletePlayersButton.Size = new System.Drawing.Size(128, 59);
			this.DeletePlayersButton.TabIndex = 20;
			this.DeletePlayersButton.Text = "Remove Selected";
			this.DeletePlayersButton.UseVisualStyleBackColor = true;
			this.DeletePlayersButton.Click += new System.EventHandler(this.DeletePlayersButton_Click_1);
			// 
			// DeletePrizeButton
			// 
			this.DeletePrizeButton.AllowDrop = true;
			this.DeletePrizeButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.DeletePrizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.DeletePrizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.DeletePrizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeletePrizeButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeletePrizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.DeletePrizeButton.Location = new System.Drawing.Point(754, 328);
			this.DeletePrizeButton.Name = "DeletePrizeButton";
			this.DeletePrizeButton.Size = new System.Drawing.Size(128, 59);
			this.DeletePrizeButton.TabIndex = 23;
			this.DeletePrizeButton.Text = "Remove Selected";
			this.DeletePrizeButton.UseVisualStyleBackColor = true;
			this.DeletePrizeButton.Click += new System.EventHandler(this.DeletePrizeButton_Click);
			// 
			// PrizesLabel
			// 
			this.PrizesLabel.AllowDrop = true;
			this.PrizesLabel.AutoSize = true;
			this.PrizesLabel.BackColor = System.Drawing.Color.Transparent;
			this.PrizesLabel.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PrizesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.PrizesLabel.Location = new System.Drawing.Point(407, 250);
			this.PrizesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.PrizesLabel.Name = "PrizesLabel";
			this.PrizesLabel.Size = new System.Drawing.Size(61, 23);
			this.PrizesLabel.TabIndex = 22;
			this.PrizesLabel.Text = "Prizes";
			this.PrizesLabel.Click += new System.EventHandler(this.Label1_Click);
			// 
			// PrizesListBox
			// 
			this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PrizesListBox.FormattingEnabled = true;
			this.PrizesListBox.ItemHeight = 23;
			this.PrizesListBox.Location = new System.Drawing.Point(411, 276);
			this.PrizesListBox.Name = "PrizesListBox";
			this.PrizesListBox.Size = new System.Drawing.Size(337, 163);
			this.PrizesListBox.TabIndex = 21;
			this.PrizesListBox.SelectedIndexChanged += new System.EventHandler(this.PrizesListBox_SelectedIndexChanged);
			// 
			// CreateTournamentButton
			// 
			this.CreateTournamentButton.AllowDrop = true;
			this.CreateTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CreateTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.CreateTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			this.CreateTournamentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateTournamentButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CreateTournamentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreateTournamentButton.Location = new System.Drawing.Point(293, 494);
			this.CreateTournamentButton.Name = "CreateTournamentButton";
			this.CreateTournamentButton.Size = new System.Drawing.Size(276, 83);
			this.CreateTournamentButton.TabIndex = 24;
			this.CreateTournamentButton.Text = "Create Tournament";
			this.CreateTournamentButton.UseVisualStyleBackColor = true;
			this.CreateTournamentButton.Click += new System.EventHandler(this.CreateTournamentButton_Click_1);
			// 
			// CreateTournamentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(915, 614);
			this.Controls.Add(this.CreateTournamentButton);
			this.Controls.Add(this.DeletePrizeButton);
			this.Controls.Add(this.PrizesLabel);
			this.Controls.Add(this.PrizesListBox);
			this.Controls.Add(this.DeletePlayersButton);
			this.Controls.Add(this.TeamsPlayersLabel);
			this.Controls.Add(this.TournamentTeamsListBox);
			this.Controls.Add(this.CreatePrizeButton);
			this.Controls.Add(this.AddTeamButton);
			this.Controls.Add(this.CreateTeamLinkLabel);
			this.Controls.Add(this.SelectTeamDropdown);
			this.Controls.Add(this.SelectTeamLabel);
			this.Controls.Add(this.EntryFeeValue);
			this.Controls.Add(this.EntryFeeLabel);
			this.Controls.Add(this.TournamentNameValue);
			this.Controls.Add(this.TournamentNameLabel);
			this.Controls.Add(this.CreateTournamentLabel);
			this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "CreateTournamentForm";
			this.Text = "Create Tournament";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void PrizesListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Label1_Click(object sender, EventArgs e)
		{
			
		}

		private void TournamentPlayersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void Round_Click(object sender, EventArgs e)
		{
			
		}

		private void RoundDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		private void EntryFeeValue_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void TeamoneScoreLabel_Click(object sender, EventArgs e)
		{
			
		}

		#endregion

		private System.Windows.Forms.Label CreateTournamentLabel;
		private System.Windows.Forms.TextBox TournamentNameValue;
		private System.Windows.Forms.Label TournamentNameLabel;
		private System.Windows.Forms.TextBox EntryFeeValue;
		private System.Windows.Forms.Label EntryFeeLabel;
		private System.Windows.Forms.ComboBox SelectTeamDropdown;
		private System.Windows.Forms.Label SelectTeamLabel;
		private System.Windows.Forms.LinkLabel CreateTeamLinkLabel;
		private System.Windows.Forms.Button AddTeamButton;
		private System.Windows.Forms.Button CreatePrizeButton;
		private System.Windows.Forms.ListBox TournamentTeamsListBox;
		private System.Windows.Forms.Label TeamsPlayersLabel;
		private System.Windows.Forms.Button DeletePlayersButton;
		private System.Windows.Forms.Button DeletePrizeButton;
		private System.Windows.Forms.Label PrizesLabel;
		private System.Windows.Forms.ListBox PrizesListBox;
		private System.Windows.Forms.Button CreateTournamentButton;
	}
}