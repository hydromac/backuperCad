namespace BackuperCad
{
	partial class migrationProfil
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
			this.progresMoment = new System.Windows.Forms.Label();
			this.Progres = new System.Windows.Forms.Label();
			this.wProgram = new System.Windows.Forms.Label();
			this.sProgram = new System.Windows.Forms.ComboBox();
			this.b1 = new System.Windows.Forms.Button();
			this.ChangeToUserName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.openExplorer = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// progresMoment
			// 
			this.progresMoment.AutoSize = true;
			this.progresMoment.Location = new System.Drawing.Point(77, 149);
			this.progresMoment.Name = "progresMoment";
			this.progresMoment.Size = new System.Drawing.Size(16, 13);
			this.progresMoment.TabIndex = 29;
			this.progresMoment.Text = "...";
			// 
			// Progres
			// 
			this.Progres.AutoSize = true;
			this.Progres.Location = new System.Drawing.Point(30, 149);
			this.Progres.Name = "Progres";
			this.Progres.Size = new System.Drawing.Size(49, 13);
			this.Progres.TabIndex = 28;
			this.Progres.Text = "Progres: ";
			// 
			// wProgram
			// 
			this.wProgram.AutoSize = true;
			this.wProgram.Location = new System.Drawing.Point(50, 37);
			this.wProgram.Name = "wProgram";
			this.wProgram.Size = new System.Drawing.Size(281, 13);
			this.wProgram.TabIndex = 27;
			this.wProgram.Text = "Wybierz program z którego chcesz utworzyć kopie profilu: ";
			// 
			// sProgram
			// 
			this.sProgram.AccessibleRole = System.Windows.Forms.AccessibleRole.Table;
			this.sProgram.BackColor = System.Drawing.SystemColors.Info;
			this.sProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sProgram.FormattingEnabled = true;
			this.sProgram.Items.AddRange(new object[] {
            "Auto Cad / LT",
            "ZW Cad",
            "GStar CAD"});
			this.sProgram.Location = new System.Drawing.Point(30, 53);
			this.sProgram.Name = "sProgram";
			this.sProgram.Size = new System.Drawing.Size(318, 21);
			this.sProgram.TabIndex = 26;
			this.sProgram.Tag = "";
			// 
			// b1
			// 
			this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b1.Location = new System.Drawing.Point(246, 167);
			this.b1.Name = "b1";
			this.b1.Size = new System.Drawing.Size(102, 23);
			this.b1.TabIndex = 25;
			this.b1.Text = "Utwórz kopie";
			this.b1.UseVisualStyleBackColor = true;
			this.b1.Click += new System.EventHandler(this.b1_Click);
			// 
			// ChangeToUserName
			// 
			this.ChangeToUserName.Location = new System.Drawing.Point(30, 112);
			this.ChangeToUserName.Name = "ChangeToUserName";
			this.ChangeToUserName.Size = new System.Drawing.Size(318, 20);
			this.ChangeToUserName.TabIndex = 30;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 96);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "Podaj login użytkownika docelowego";
			// 
			// openExplorer
			// 
			this.openExplorer.Location = new System.Drawing.Point(30, 196);
			this.openExplorer.Name = "openExplorer";
			this.openExplorer.Size = new System.Drawing.Size(318, 28);
			this.openExplorer.TabIndex = 32;
			this.openExplorer.Text = "Otwórz miejsce docelowe";
			this.openExplorer.UseVisualStyleBackColor = true;
			this.openExplorer.Visible = false;
			this.openExplorer.Click += new System.EventHandler(this.openExplorer_Click);
			// 
			// migrationProfil
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(384, 236);
			this.Controls.Add(this.openExplorer);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChangeToUserName);
			this.Controls.Add(this.progresMoment);
			this.Controls.Add(this.Progres);
			this.Controls.Add(this.wProgram);
			this.Controls.Add(this.sProgram);
			this.Controls.Add(this.b1);
			this.MaximumSize = new System.Drawing.Size(400, 275);
			this.MinimumSize = new System.Drawing.Size(400, 275);
			this.Name = "migrationProfil";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Przenoszenie profilu...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label progresMoment;
		private System.Windows.Forms.Label Progres;
		private System.Windows.Forms.Label wProgram;
		private System.Windows.Forms.ComboBox sProgram;
		private System.Windows.Forms.Button b1;
		private System.Windows.Forms.TextBox ChangeToUserName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button openExplorer;
	}
}