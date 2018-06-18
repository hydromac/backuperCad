using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BackuperCad
{
	public partial class StartWindow : Form
	{
		public StartWindow()
		{
			InitializeComponent();
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