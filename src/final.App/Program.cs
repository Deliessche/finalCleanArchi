using System;

namespace final.App
{
    class Program
    {
        static void Main(string[] args)
        {
            utils util = new utils();
            Console.WriteLine("What do you want to do ?\n 1. Create new task\n 2. List all task");
            string val = Console.ReadLine();
            switch (val){
                case "1":
                    util.addTask();
                    break;
                case "2":
                    util.getTasksFromFile();
                    break;
                default :
                    Console.WriteLine("Error, renew your choice");
                    break;
            } 
        }
    }
}
