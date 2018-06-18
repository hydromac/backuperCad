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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
		private void goToCopy_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2(this);
			frm.Show();
			
		}

		private void goToBackup_Click(object sender, EventArgs e)
		{
			Form3 frm = new Form3(this);
			frm.Show();


		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form4 frm = new Form4(this);
			frm.Show();
		}

		private void goToCopy_MouseHover(object sender, EventArgs e)
		{
			//System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
			ToolTip1.SetToolTip(this.goToCopy, "Umożliwa tworzenie kopi zapasowej profilu autoCad");
		}

		
	}
}