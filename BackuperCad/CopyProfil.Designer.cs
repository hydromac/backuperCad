namespace BackuperCad
{
	partial class CopyProfil
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
			this.wProgram = new System.Windows.Forms.Label();
			this.sProgram = new System.Windows.Forms.ComboBox();
			this.b1 = new System.Windows.Forms.Button();
			this.Progres = new System.Windows.Forms.Label();
			this.progresMoment = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// wProgram
			// 
			this.wProgram.AutoSize = true;
			this.wProgram.Location = new System.Drawing.Point(48, 30);
			this.wProgram.Name = "wProgram";
			this.wProgram.Size = new System.Drawing.Size(281, 13);
			this.wProgram.TabIndex = 22;
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
			this.sProgram.Location = new System.Drawing.Point(28, 46);
			this.sProgram.Name = "sProgram";
			this.sProgram.Size = new System.Drawing.Size(318, 21);
			this.sProgram.TabIndex = 17;
			this.sProgram.Tag = "";
			// 
			// b1
			// 
			this.b1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.b1.Location = new System.Drawing.Point(244, 91);
			this.b1.Name = "b1";
			this.b1.Size = new System.Drawing.Size(102, 23);
			this.b1.TabIndex = 14;
			this.b1.Text = "Utwórz kopie";
			this.b1.UseVisualStyleBackColor = true;
			this.b1.Click += new System.EventHandler(this.b1_Click);
			// 
			// Progres
			// 
			this.Progres.AutoSize = true;
			this.Progres.Location = new System.Drawing.Point(28, 73);
			this.Progres.Name = "Progres";
			this.Progres.Size = new System.Drawing.Size(49, 13);
			this.Progres.TabIndex = 23;
			this.Progres.Text = "Progres: ";
			// 
			// progresMoment
			// 
			this.progresMoment.AutoSize = true;
			this.progresMoment.Location = new System.Drawing.Point(75, 73);
			this.progresMoment.Name = "progresMoment";
			this.progresMoment.Size = new System.Drawing.Size(16, 13);
			this.progresMoment.TabIndex = 24;
			this.progresMoment.Text = "...";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(384, 161);
			this.Controls.Add(this.progresMoment);
			this.Controls.Add(this.Progres);
			this.Controls.Add(this.wProgram);
			this.Controls.Add(this.sProgram);
			this.Controls.Add(this.b1);
			this.MaximumSize = new System.Drawing.Size(400, 200);
			this.MinimumSize = new System.Drawing.Size(400, 200);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tworzenie kopi profilu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label wProgram;
		private System.Windows.Forms.ComboBox sProgram;
		private System.Windows.Forms.Button b1;
		private System.Windows.Forms.Label Progres;
		private System.Windows.Forms.Label progresMoment;
	}
}