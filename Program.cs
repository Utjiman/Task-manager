using System.Security.Cryptography.X509Certificates;

namespace TaskManager;

public class Program
{
    public static List<Tasks> tasks = new List<Tasks>();
    public static void Main(string[] args)
    {
        
        Tasks task = new Tasks ("Buy Food", false );
        tasks.Add(task);
        task = new Tasks("Refuel the car", false);
        tasks.Add(task);
        
        bool isRunning = true;
        while (isRunning)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("Welcome to the task manager. Please choose an option in the menu");
            System.Console.WriteLine("");
            System.Console.WriteLine("-------------------------");
            System.Console.WriteLine("| 1. View tasks         |");
            System.Console.WriteLine("| 2. Add task           |");
            System.Console.WriteLine("| 3. Remove task        |");
            System.Console.WriteLine("| 4. Mark tasks as done |");
            System.Console.WriteLine("| 5. Exit program       |");
            System.Console.WriteLine("-------------------------");
            System.Console.Write("Choice: ");
            int menu = int.Parse(""+ Console.ReadLine());
            switch(menu)
            {
                case 1:
                    task.ListTasks(tasks);
                    break;
                case 2:
                    task.AddTask(tasks);
                    break;
                case 3:
                    task.RemoveTask(tasks);
                    break;
                case 4:
                    break;
                case 5:
                    isRunning = false;
                    System.Console.WriteLine("Have a nice day!");
                    break;
            }
        }
        
    }
}
