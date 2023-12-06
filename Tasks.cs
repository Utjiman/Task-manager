public class Tasks{
    public string Name {get; set;}
    public bool IsComplete {get; set;}

    public Tasks ( string name, bool isComplete)
    {
        Name = name;
        IsComplete = isComplete;
    }

    public void AddTask(List<Tasks>tasks)
    {
        System.Console.WriteLine("What is the task?");
        string task = "" + Console.ReadLine();
        Tasks taskAdd = new Tasks(task, false);
        tasks.Add(taskAdd);
    }

    public void RemoveTask(List<Tasks>tasks)
    {
        System.Console.WriteLine("Please choose which task you want to remove");
        ListTasks(tasks);
        int removeChoice;
        System.Console.Write("Choice: ");
        if (int.TryParse(Console.ReadLine(), out removeChoice))
        {
            removeChoice--; 
            if (removeChoice >= 0 && removeChoice < tasks.Count)
            {
                Tasks removedTask = tasks[removeChoice];
                tasks.RemoveAt(removeChoice);
                System.Console.WriteLine($"Task '{removedTask.Name}' removed successfully.");
            }
            else
            {
                System.Console.WriteLine("Invalid choice. Please enter a valid task number.");
            }
        }
        else
        {
            System.Console.WriteLine("Invalid input. Please enter a number.");
        }

    }
    public void ListTasks(List<Tasks>tasks)
    {
        for (int i = 0; i < tasks.Count; i++ )
        {
            System.Console.WriteLine("---------------------------------------------");
            System.Console.WriteLine($"| {i + 1} Task: {tasks[i].Name} | Status: {tasks[i].IsComplete} |");
            System.Console.WriteLine("---------------------------------------------");
        }
    }
}