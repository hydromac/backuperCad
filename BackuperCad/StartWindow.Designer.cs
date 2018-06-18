namespace BackuperCad
{
	partial class StartWindow
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			this.goToCopy = new System.Windows.Forms.Button();
			this.goToBackup = new System.Windows.Forms.Button();
			this.ChangeProfil = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// goToCopy
			// 
			this.goToCopy.Location = new System.Drawing.Point(23, 31);
			this.goToCopy.Name = "goToCopy";
			this.goToCopy.Size = new System.Drawing.Size(334, 72);
			this.goToCopy.TabIndex = 0;
			this.goToCopy.Text = "Utwórz kopie profilu CAD";
			this.goToCopy.UseVisualStyleBackColor = true;
			this.goToCopy.Click += new System.EventHandler(this.goToCopy_Click);
			// 
			// goToBackup
			// 
			this.goToBackup.Location = new System.Drawing.Point(23, 109);
			this.goToBackup.Name = "goToBackup";
			this.goToBackup.Size = new System.Drawing.Size(334, 72);
			this.goToBackup.TabIndex = 1;
			this.goToBackup.Text = "Wgraj kopie profilu";
			this.goToBackup.UseVisualStyleBackColor = true;
			this.goToBackup.Click += new System.EventHandler(this.goToBackup_Click);
			// 
			// ChangeProfil
			// 
			this.ChangeProfil.Location = new System.Drawing.Point(23, 187);
			this.ChangeProfil.Name = "ChangeProfil";
			this.ChangeProfil.Size = new System.Drawing.Size(334, 72);
			this.ChangeProfil.TabIndex = 2;
			this.ChangeProfil.Text = "Przenieś profil na inneg użytkownika";
			this.ChangeProfil.UseVisualStyleBackColor = true;
			this.ChangeProfil.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(20, 339);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(143, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Autor: Tomasz Szczotkowski";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ChangeProfil);
			this.Controls.Add(this.goToBackup);
			this.Controls.Add(this.goToCopy);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 400);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(400, 400);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CAD backuper";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button goToCopy;
		private System.Windows.Forms.Button goToBackup;
		private System.Windows.Forms.Button ChangeProfil;
		private System.Windows.Forms.Label label1;
	}
}

