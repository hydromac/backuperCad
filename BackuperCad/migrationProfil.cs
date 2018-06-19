using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BackuperCad
{
	public partial class migrationProfil : Form
	{
		String userName = Environment.UserName;

		public migrationProfil(StartWindow form1)
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
			String changeToUserName = ChangeToUserName.Text;
			String apdataRoamin = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
			String apdataLocal = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData).ToString();
			String myDocument = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).ToString();

			String pathRoaming = apdataRoamin + "\\" + program;
			String pathLocal = apdataLocal + "\\" + program;

			String targetPath = myDocument + "\\backuperCad_ " + program + String.Format("_{0}_{1:D2}_{2:D2}_{3}", DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, changeToUserName);
			String targetRoaming = targetPath + "\\Roaming";
			String targetLocal = targetPath + "\\Local";
			String pathReg = "HKCU\\Software\\" + reg;

			if (!String.IsNullOrEmpty(sProgram.Text))
			{

				if (!Directory.Exists(targetPath))
				{
					progresMoment.ForeColor = Color.FromArgb(0, 0, 0);
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

						progresMoment.ForeColor = Color.FromArgb(0, 0, 0);
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
						progresMoment.ForeColor = Color.FromArgb(0, 0, 0);
						progresMoment.Text = "Nanoszenie zmian w kopi rejestru...";
						Refresh();
						try
						{

							string str = File.ReadAllText(targetPath + "\\regCopy.reg");
							str = str.Replace(userName, changeToUserName);
							File.WriteAllText(targetPath + "\\regCopy.reg", str);

						}
						catch {
							progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
							progresMoment.Text = "Nie udało się wprowadzić zmian w kopi rejestru" + program;
						}
						progresMoment.ForeColor = Color.FromArgb(0, 204, 0);
						progresMoment.Text = "Skończone";
						openExplorer.Visible = true;
						Refresh();


					}
					else
					{
						progresMoment.ForeColor = Color.FromArgb(255, 0, 0);
						progresMoment.Text = "Brak plików do " + program;
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

		private void openExplorer_Click(object sender, EventArgs e)
		{
			Process.Start(@"C:\\Users\\" + userName + "\\Documents\\");
		}
	}
}
