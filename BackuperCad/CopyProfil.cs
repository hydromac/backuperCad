using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackuperCad
{
	public partial class CopyProfil : Form
	{

		String userName = Environment.UserName;

		public CopyProfil(StartWindow form1)
		{
			InitializeComponent();
		}

		private void b1_Click(object sender, EventArgs e)
		{
			progresMoment.ForeColor = Color.FromArgb(0, 0, 0);
			progresMoment.Text = " ";
			Refresh();
			progresMoment.Text = "Przygotowywanie składników";
			string[] programElements = new string[2];
			programElements = OperationCAD.WhatCopy(sProgram.Text);
			String program = programElements[0];
			String reg = programElements[1];


			
			String pathRoaming = "C:\\Users\\" + userName + "\\AppData\\Roaming\\" + program;
			String pathLocal = "C:\\Users\\" + userName + "\\AppData\\Local\\" + program;

			String targetPath = "C:\\Users\\" + userName + "\\Documents\\" + "backuperCad_ " + program + String.Format("_{0}_{1}_{2}", DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
			String targetRoaming = targetPath + "\\Roaming";
			String targetLocal = targetPath + "\\Local";
			String pathReg = "HKCU\\Software\\" + reg;

			if (!String.IsNullOrEmpty(sProgram.Text))
			{
				
				if (!Directory.Exists(targetPath))
				{
					progresMoment.Text = "Zaczynam prace...";
					Refresh();

					
					// sprawdza czy istnieją pliki wybranego programu 
					if (Directory.Exists(pathRoaming) && Directory.Exists(pathLocal))
					{
						
						try
						{   //Tworzy pliki docelowe kopi zapasowej 

							Directory.CreateDirectory(targetPath);
							Directory.CreateDirectory(targetRoaming);
							Directory.CreateDirectory(targetLocal);
						}
						catch
						{
							MessageBox.Show("Nie udało się utworzyć kopi :" + program);
						}


						progresMoment.Text = "Kopiowanie plików...";
						Refresh();

						try
						{

							// kopiuje pliki z Local i Roaming do folderu z backupem na C
							OperationCAD.DirectoryCopy(pathRoaming, targetRoaming, true);

							OperationCAD.DirectoryCopy(pathLocal, targetLocal, true);
							// exportuje fragment rejestru zwiazany z programem Cad 
							OperationCAD.exportRegistry(pathReg, targetPath + "\\regCopy.reg");

						}
						catch
						{
							progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
							progresMoment.Text = "Nie udało się utworzyć kopi :" + program;
							
						}
						progresMoment.ForeColor = Color.FromArgb(0, 204, 0);
						progresMoment.Text = "Skończone";
						OpenExplorer.Visible = true;
						Refresh();

					}
					else
					{
						progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
						progresMoment.Text = "Brak plików do " + program ; 
					}
				}
				else
				{
					progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
					progresMoment.Text = "Istnieje kopia z tego dnia";
				}
			}
			else
			{
				progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
				progresMoment.Text = "Wybierz program z listy";

			}
		}

		private void OpenExplorer_Click(object sender, EventArgs e)
		{
			Process.Start(@"C:\\Users\\" + userName + "\\Documents\\");
		}
	}
}
