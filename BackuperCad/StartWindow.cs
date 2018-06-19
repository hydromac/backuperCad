using System;
using System.Diagnostics;
using System.Windows.Forms;


namespace BackuperCad
{
	public partial class StartWindow : Form
	{
		public StartWindow()
		{

			InitializeComponent();
			if (Process.GetProcessesByName("acad").Length > 0 || Process.GetProcessesByName("ZWCAD").Length > 0 || Process.GetProcessesByName("gcad").Length > 0 ) {
				var result = MessageBox.Show("Do poprawnego działania programu\nnależy wyłączy program Cad\n\n Wyłącz?", "Czy włączyć program...",
								 MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

				if (result == DialogResult.No) {
					System.Environment.Exit(1);
					
				}

				if (result == DialogResult.Yes)
				{
						OperationCAD.closeCAD();
				}	
			}

			
		}

		private void goToCopy_Click(object sender, EventArgs e)
		{
			CopyProfil frm = new CopyProfil(this);
			frm.Show();
			
		}

		private void goToBackup_Click(object sender, EventArgs e)
		{
			loadProfil frm = new loadProfil(this);
			frm.Show();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			migrationProfil frm = new migrationProfil(this);
			frm.Show();
		}



	}
}