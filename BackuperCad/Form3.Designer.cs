

namespace BackuperCad
{
	partial class Form3
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
			this.selectedProfil = new System.Windows.Forms.ComboBox();
			this.wProgram = new System.Windows.Forms.Label();
			this.wProfil = new System.Windows.Forms.Label();
			this.sProgram = new System.Windows.Forms.ComboBox();
			this.b2 = new System.Windows.Forms.Button();
			this.progresMoment = new System.Windows.Forms.Label();
			this.Progres = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// selectedProfil
			// 
			this.selectedProfil.FormattingEnabled = true;
			this.selectedProfil.Location = new System.Drawing.Point(33, 89);
			this.selectedProfil.Name = "selectedProfil";
			this.selectedProfil.Size = new System.Drawing.Size(318, 21);
			this.selectedProfil.TabIndex = 19;
			// 
			// wProgram
			// 
			this.wProgram.AutoSize = true;
			this.wProgram.Location = new System.Drawing.Point(30, 20);
			this.wProgram.Name = "wProgram";
			this.wProgram.Size = new System.Drawing.Size(281, 13);
			this.wProgram.TabIndex = 18;
			this.wProgram.Text = "Wybierz program z którego chcesz utworzyć kopie profilu: ";
			// 
			// wProfil
			// 
			this.wProfil.AutoSize = true;
			this.wProfil.Location = new System.Drawing.Point(30, 72);
			this.wProfil.Name = "wProfil";
			this.wProfil.Size = new System.Drawing.Size(191, 13);
			this.wProfil.TabIndex = 17;
			this.wProfil.Text = "Wybierz kopie profilu do przywrócenia: ";
			// 
			// sProgram
			// 
			this.sProgram.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
			this.sProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.sProgram.FormattingEnabled = true;
			this.sProgram.Items.AddRange(new object[] {
            "Auto Cad / LT",
            "ZW Cad",
            "GStar CAD"});
			this.sProgram.Location = new System.Drawing.Point(33, 36);
			this.sProgram.Name = "sProgram";
			this.sProgram.Size = new System.Drawing.Size(318, 21);
			this.sProgram.TabIndex = 16;
			this.sProgram.Tag = "";
			// 
			// b2
			// 
			this.b2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b2.Location = new System.Drawing.Point(195, 144);
			this.b2.Name = "b2";
			this.b2.Size = new System.Drawing.Size(156, 24);
			this.b2.TabIndex = 15;
			this.b2.Text = "Wgraj Profil";
			this.b2.UseVisualStyleBackColor = true;
			this.b2.Click += new System.EventHandler(this.b2_Click);
			// 
			// progresMoment
			// 
			this.progresMoment.AutoSize = true;
			this.progresMoment.Location = new System.Drawing.Point(77, 122);
			this.progresMoment.Name = "progresMoment";
			this.progresMoment.Size = new System.Drawing.Size(16, 13);
			this.progresMoment.TabIndex = 26;
			this.progresMoment.Text = "...";
			// 
			// Progres
			// 
			this.Progres.AutoSize = true;
			this.Progres.Location = new System.Drawing.Point(30, 122);
			this.Progres.Name = "Progres";
			this.Progres.Size = new System.Drawing.Size(49, 13);
			this.Progres.TabIndex = 25;
			this.Progres.Text = "Progres: ";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(384, 211);
			this.Controls.Add(this.progresMoment);
			this.Controls.Add(this.Progres);
			this.Controls.Add(this.selectedProfil);
			this.Controls.Add(this.wProgram);
			this.Controls.Add(this.wProfil);
			this.Controls.Add(this.sProgram);
			this.Controls.Add(this.b2);
			this.MaximumSize = new System.Drawing.Size(400, 250);
			this.MinimumSize = new System.Drawing.Size(400, 250);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wgrywanie profilu...";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox selectedProfil;
		private System.Windows.Forms.Label wProgram;
		private System.Windows.Forms.Label wProfil;
		private System.Windows.Forms.ComboBox sProgram;
		private System.Windows.Forms.Button b2;
		private System.Windows.Forms.Label progresMoment;
		private System.Windows.Forms.Label Progres;


	}
}