using System;
using System.IO;

namespace final.App
{
	public class fileClass{
		string pathFile;
		public fileClass(){
			pathFile = "./file.txt";
			createfile();
		}
		public void createfile(){
			if (!File.Exists(pathFile)){
				using (StreamWriter sw = File.CreateText(pathFile))
				{
					sw.WriteLine("");
				}
			}
		}
		public void addTaskInFile(taskClass task){
			using (StreamWriter sw = File.CreateText(pathFile)){
				Console.WriteLine(task.getName());
				sw.Write(task.getName() + ";");
				sw.WriteLine(task.taskDate());
			}
		}
	}
}