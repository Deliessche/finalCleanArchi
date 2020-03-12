using System;
using System.IO;

namespace final.App
{
	public class utils{
		
		fileClass fileClass;
		public utils(){
			fileClass = new fileClass();
		}
		public string addTask(){
			taskClass task = createTaskUI();
			if (saveTaskOnFile(task)){
				return "Task succesfully created";
			}else{
				return "Error during Taks creation";
			}
		}
		private taskClass createTaskUI(){
			Console.WriteLine("Which year for this task ? ");
			string year = Console.ReadLine();
			
			Console.WriteLine("Which month for this task ? ");
			string month = Console.ReadLine();
			
			Console.WriteLine("Which day for this task ? ");
			string day = Console.ReadLine();
			
			Console.WriteLine("Which hour for this task ? in format hh:mm");
			string hour = Console.ReadLine();
			
			Console.WriteLine("Which name for this task ? ");
			string name = Console.ReadLine();
			
			taskClass tc = new taskClass(year, month, day, hour, name);
			return tc;
		}
		private bool saveTaskOnFile(taskClass tc){
			try{
				this.fileClass.addTaskInFile(tc);
				return true;
			}catch{
				return false;
			}
		}
		public void getTasksFromFile(){

		}
	}
}