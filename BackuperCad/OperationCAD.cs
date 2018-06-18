using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackuperCad
{
	class OperationCAD
	{

		public static String[] WhatCopy(String sProgram)
		{

			String[] returnProgramComponents = new string[2];
			String Program = sProgram;
			switch (Program)
			{


				case "Auto Cad / LT":
					returnProgramComponents[0] = "Autodesk";
					returnProgramComponents[1] = "Autodesk";
					break;

				case "ZW Cad":
					returnProgramComponents[0] = "ZWSOFT";
					returnProgramComponents[1] = "ZWSOFT";
					break;

				case "GStar CAD":
					returnProgramComponents[0] = "Gstarsoft";
					returnProgramComponents[1] = "Gstarsoft";
					break;

			}

			return returnProgramComponents;
		}

		public static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			// Get the subdirectories for the specified directory.
			DirectoryInfo dir = new DirectoryInfo(sourceDirName);

			if (!dir.Exists)
			{
				throw new DirectoryNotFoundException(
					"Source directory does not exist or could not be found: "
					+ sourceDirName);
			}

			DirectoryInfo[] dirs = dir.GetDirectories();
			// If the destination directory doesn't exist, create it.
			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			// Get the files in the directory and copy them to the new location.
			FileInfo[] files = dir.GetFiles();
			foreach (FileInfo file in files)
			{
				string temppath = Path.Combine(destDirName, file.Name);
				file.CopyTo(temppath, false);
			}

			// If copying subdirectories, copy them and their contents to new location.
			if (copySubDirs)
			{
				foreach (DirectoryInfo subdir in dirs)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, temppath, copySubDirs);
				}
			}
		}

		public static void exportRegistry(string strKey, string filepath)
		{
			try
			{
				using (Process proc = new Process())
				{
					proc.StartInfo.FileName = "reg.exe";
					proc.StartInfo.UseShellExecute = false;
					proc.StartInfo.RedirectStandardOutput = true;
					proc.StartInfo.RedirectStandardError = true;
					proc.StartInfo.CreateNoWindow = true;
					proc.StartInfo.Arguments = "export \"" + strKey + "\" \"" + filepath + "\" /y";
					proc.Start();
					string stdout = proc.StandardOutput.ReadToEnd();
					string stderr = proc.StandardError.ReadToEnd();
					proc.WaitForExit();
				}
			}
			catch (Exception ex)
			{
				// handle exception
			}
		}

		public static void importRegistry(string pathReg)
		{
			try
			{
				using (Process proc = new Process())
				{
					proc.StartInfo.FileName = "reg.exe";
					proc.StartInfo.UseShellExecute = false;
					proc.StartInfo.RedirectStandardOutput = true;
					proc.StartInfo.RedirectStandardError = true;
					proc.StartInfo.CreateNoWindow = true;
					proc.StartInfo.Arguments = "import \"" + pathReg;
					proc.Start();
					string stdout = proc.StandardOutput.ReadToEnd();
					string stderr = proc.StandardError.ReadToEnd();
					proc.WaitForExit();
				}
			}
			catch (Exception ex)
			{
				// handle exception
			}
		}
	}
}
