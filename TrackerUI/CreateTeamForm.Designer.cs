using System;

namespace TrackerUI
{
	partial class CreateTeamForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
			this.TeamNameValue = new System.Windows.Forms.TextBox();
			this.TeamNameLabel = new System.Windows.Forms.Label();
			this.CreateTeamLabel = new System.Windows.Forms.Label();
			this.AddMemberButton = new System.Windows.Forms.Button();
			this.SelectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
			this.SelectTeamMemberLabel = new System.Windows.Forms.Label();
			this.AddNewMemberBox = new System.Windows.Forms.GroupBox();
			this.CreateMemberButton = new System.Windows.Forms.Button();
			this.CellphoneValue = new System.Windows.Forms.TextBox();
			this.CellphoneLabel = new System.Windows.Forms.Label();
			this.EmailValue = new System.Windows.Forms.TextBox();
			this.EmailLabel = new System.Windows.Forms.Label();
			this.LastNameValue = new System.Windows.Forms.TextBox();
			this.LastNameLabel = new System.Windows.Forms.Label();
			this.FirstNameValue = new System.Windows.Forms.TextBox();
			this.FirstNameLabel = new System.Windows.Forms.Label();
			this.TeamMembersListBox = new System.Windows.Forms.ListBox();
			this.RemoveSelectedButton = new System.Windows.Forms.Button();
			this.CreateTeamButton = new System.Windows.Forms.Button();
			this.AddNewMemberBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// TeamNameValue
			// 
			resources.ApplyResources(this.TeamNameValue, "TeamNameValue");
			this.TeamNameValue.Name = "TeamNameValue";
			this.TeamNameValue.TextChanged += new System.EventHandler(this.TeamNameValue_TextChanged);
			// 
			// TeamNameLabel
			// 
			resources.ApplyResources(this.TeamNameLabel, "TeamNameLabel");
			this.TeamNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.TeamNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TeamNameLabel.Name = "TeamNameLabel";
			// 
			// CreateTeamLabel
			// 
			resources.ApplyResources(this.CreateTeamLabel, "CreateTeamLabel");
			this.CreateTeamLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreateTeamLabel.Name = "CreateTeamLabel";
			// 
			// AddMemberButton
			// 
			this.AddMemberButton.AllowDrop = true;
			this.AddMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.AddMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			resources.ApplyResources(this.AddMemberButton, "AddMemberButton");
			this.AddMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.AddMemberButton.Name = "AddMemberButton";
			this.AddMemberButton.UseVisualStyleBackColor = true;
			this.AddMemberButton.Click += new System.EventHandler(this.AddTeamButton_Click);
			// 
			// SelectTeamMemberDropdown
			// 
			this.SelectTeamMemberDropdown.FormattingEnabled = true;
			resources.ApplyResources(this.SelectTeamMemberDropdown, "SelectTeamMemberDropdown");
			this.SelectTeamMemberDropdown.Name = "SelectTeamMemberDropdown";
			this.SelectTeamMemberDropdown.SelectedIndexChanged += new System.EventHandler(this.SelectTeamDropdown_SelectedIndexChanged);
			// 
			// SelectTeamMemberLabel
			// 
			resources.ApplyResources(this.SelectTeamMemberLabel, "SelectTeamMemberLabel");
			this.SelectTeamMemberLabel.BackColor = System.Drawing.Color.Transparent;
			this.SelectTeamMemberLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.SelectTeamMemberLabel.Name = "SelectTeamMemberLabel";
			this.SelectTeamMemberLabel.Click += new System.EventHandler(this.SelectTeamLabel_Click);
			// 
			// AddNewMemberBox
			// 
			this.AddNewMemberBox.Controls.Add(this.CreateMemberButton);
			this.AddNewMemberBox.Controls.Add(this.CellphoneValue);
			this.AddNewMemberBox.Controls.Add(this.CellphoneLabel);
			this.AddNewMemberBox.Controls.Add(this.EmailValue);
			this.AddNewMemberBox.Controls.Add(this.EmailLabel);
			this.AddNewMemberBox.Controls.Add(this.LastNameValue);
			this.AddNewMemberBox.Controls.Add(this.LastNameLabel);
			this.AddNewMemberBox.Controls.Add(this.FirstNameValue);
			this.AddNewMemberBox.Controls.Add(this.FirstNameLabel);
			this.AddNewMemberBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			resources.ApplyResources(this.AddNewMemberBox, "AddNewMemberBox");
			this.AddNewMemberBox.Name = "AddNewMemberBox";
			this.AddNewMemberBox.TabStop = false;
			// 
			// CreateMemberButton
			// 
			this.CreateMemberButton.AllowDrop = true;
			this.CreateMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CreateMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.CreateMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			resources.ApplyResources(this.CreateMemberButton, "CreateMemberButton");
			this.CreateMemberButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreateMemberButton.Name = "CreateMemberButton";
			this.CreateMemberButton.UseVisualStyleBackColor = true;
			this.CreateMemberButton.Click += new System.EventHandler(this.CreateMemberButton_Click);
			// 
			// CellphoneValue
			// 
			resources.ApplyResources(this.CellphoneValue, "CellphoneValue");
			this.CellphoneValue.Name = "CellphoneValue";
			// 
			// CellphoneLabel
			// 
			resources.ApplyResources(this.CellphoneLabel, "CellphoneLabel");
			this.CellphoneLabel.BackColor = System.Drawing.Color.Transparent;
			this.CellphoneLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CellphoneLabel.Name = "CellphoneLabel";
			// 
			// EmailValue
			// 
			resources.ApplyResources(this.EmailValue, "EmailValue");
			this.EmailValue.Name = "EmailValue";
			// 
			// EmailLabel
			// 
			resources.ApplyResources(this.EmailLabel, "EmailLabel");
			this.EmailLabel.BackColor = System.Drawing.Color.Transparent;
			this.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.EmailLabel.Name = "EmailLabel";
			// 
			// LastNameValue
			// 
			resources.ApplyResources(this.LastNameValue, "LastNameValue");
			this.LastNameValue.Name = "LastNameValue";
			// 
			// LastNameLabel
			// 
			resources.ApplyResources(this.LastNameLabel, "LastNameLabel");
			this.LastNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.LastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.LastNameLabel.Name = "LastNameLabel";
			// 
			// FirstNameValue
			// 
			resources.ApplyResources(this.FirstNameValue, "FirstNameValue");
			this.FirstNameValue.Name = "FirstNameValue";
			// 
			// FirstNameLabel
			// 
			resources.ApplyResources(this.FirstNameLabel, "FirstNameLabel");
			this.FirstNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.FirstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.FirstNameLabel.Name = "FirstNameLabel";
			// 
			// TeamMembersListBox
			// 
			this.TeamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TeamMembersListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.TeamMembersListBox.FormattingEnabled = true;
			resources.ApplyResources(this.TeamMembersListBox, "TeamMembersListBox");
			this.TeamMembersListBox.Name = "TeamMembersListBox";
			this.TeamMembersListBox.SelectedIndexChanged += new System.EventHandler(this.TeamMembersListBox_SelectedIndexChanged);
			// 
			// RemoveSelectedButton
			// 
			this.RemoveSelectedButton.AllowDrop = true;
			this.RemoveSelectedButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.RemoveSelectedButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.RemoveSelectedButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			resources.ApplyResources(this.RemoveSelectedButton, "RemoveSelectedButton");
			this.RemoveSelectedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.RemoveSelectedButton.Name = "RemoveSelectedButton";
			this.RemoveSelectedButton.UseVisualStyleBackColor = true;
			this.RemoveSelectedButton.Click += new System.EventHandler(this.RemoveSelectedButton_Click);
			// 
			// CreateTeamButton
			// 
			this.CreateTeamButton.AllowDrop = true;
			this.CreateTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CreateTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
			this.CreateTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
			resources.ApplyResources(this.CreateTeamButton, "CreateTeamButton");
			this.CreateTeamButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
			this.CreateTeamButton.Name = "CreateTeamButton";
			this.CreateTeamButton.UseVisualStyleBackColor = true;
			this.CreateTeamButton.Click += new System.EventHandler(this.CreateTeamButton_Click);
			// 
			// CreateTeamForm
			// 
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.CreateTeamButton);
			this.Controls.Add(this.RemoveSelectedButton);
			this.Controls.Add(this.TeamMembersListBox);
			this.Controls.Add(this.AddNewMemberBox);
			this.Controls.Add(this.AddMemberButton);
			this.Controls.Add(this.SelectTeamMemberDropdown);
			this.Controls.Add(this.SelectTeamMemberLabel);
			this.Controls.Add(this.CreateTeamLabel);
			this.Controls.Add(this.TeamNameValue);
			this.Controls.Add(this.TeamNameLabel);
			this.Name = "CreateTeamForm";
			this.AddNewMemberBox.ResumeLayout(false);
			this.AddNewMemberBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private void TeamNameValue_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void SelectTeamDropdown_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void TeamMembersListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void SelectTeamLabel_Click(object sender, EventArgs e)
		{
			
		}

		#endregion

		private System.Windows.Forms.TextBox TeamNameValue;
		private System.Windows.Forms.Label TeamNameLabel;
		private System.Windows.Forms.Label CreateTeamLabel;
		private System.Windows.Forms.Button AddMemberButton;
		private System.Windows.Forms.ComboBox SelectTeamMemberDropdown;
		private System.Windows.Forms.Label SelectTeamMemberLabel;
		private System.Windows.Forms.GroupBox AddNewMemberBox;
		private System.Windows.Forms.Button CreateMemberButton;
		private System.Windows.Forms.TextBox CellphoneValue;
		private System.Windows.Forms.Label CellphoneLabel;
		private System.Windows.Forms.TextBox EmailValue;
		private System.Windows.Forms.Label EmailLabel;
		private System.Windows.Forms.TextBox LastNameValue;
		private System.Windows.Forms.Label LastNameLabel;
		private System.Windows.Forms.TextBox FirstNameValue;
		private System.Windows.Forms.Label FirstNameLabel;
		private System.Windows.Forms.ListBox TeamMembersListBox;
		private System.Windows.Forms.Button RemoveSelectedButton;
		private System.Windows.Forms.Button CreateTeamButton;
	}
}