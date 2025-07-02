// using System;
// interface Methods
// {
//     double Addition(double num1, double num2);
//     double Multiplication(double num1, double num2);
//     double Divide(double num1, double num2);
//     double Subtraction(double num1, double num2);
// }

// class Calculator : Methods
// {
//     public double Addition(double num1, double num2)
//     {
//         return num1 + num2;
//     }

//     public double Multiplication(double num1, double num2)
//     {
//         return num1 * num2;
//     }

//     public double Divide(double num1, double num2)
//     {
//         return num1 / num2;
//     }

//     public double Subtraction(double num1, double num2)
//     {
//         return num1 - num2;
//     }
// }
// class Program
// {
//     static void Main(string[] args)
//     {
//         Calculator myCalc = new Calculator();
//         Console.WriteLine("Addition: " + myCalc.Addition(10, 10));
//         Console.WriteLine("Subtraction: " + myCalc.Subtraction(10, 3));
//         Console.WriteLine("Multiplication: " + myCalc.Multiplication(10, 4.5));
//         Console.WriteLine("Division: " + myCalc.Divide(10, 5));
//     }
// }
public class TodoList : tasksInterface
{
    public List<Task> tasks = new List<Task>();

    public List<Task> getAllTasks()
    {
        return tasks;
    }

    public void createTask(string taskName)
    {
        tasks.Add(new Task(taskName));
    }

    public void deleteTask(string taskName)
    {
        Task toRemove = null;
        foreach (Task t in tasks)
        {
            if (t.Name == taskName)
            {
                toRemove = t;
                break;
            }
        }

        if (toRemove != null)
        {
            tasks.Remove(toRemove);
            Console.WriteLine($"Task '{taskName}' deleted successfully.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }
    public void updateTask(string oldName, string newName)
    {
        Task taskToUpdate = null;

        foreach (Task t in tasks)
        {
            if (t.Name == oldName)
            {
                taskToUpdate = t;
                break;
            }
        }

        if (taskToUpdate != null)
        {
            taskToUpdate.Name = newName;
            Console.WriteLine($"Task '{oldName}' updated to '{newName}'.");
        }
        else
        {
            Console.WriteLine("Task not found.");
        }
    }

    public class Program
    {
        public static void Main()
        {
            TodoList list = new TodoList();
            Console.Write("Enter number of tasks you want to start with: ");
            int taskMax = Convert.ToInt32(Console.ReadLine());

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < taskMax; i++)
            {
                Console.Write("Enter your " + (i + 1) + " task: ");
                string task = Console.ReadLine();
                list.createTask(task);
            }
            while (true)
            {
                Console.WriteLine("\nCurrent tasks:");
                List<Task> currentTasks = list.getAllTasks();
                for (int i = 0; i < currentTasks.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + currentTasks[i].Name);
                }
                Console.Write("\nWhat action do you want to perform?\n1 - Add\n2 - Delete\n3 - Update\n4 - Exit\nEnter your choice: ");
                int action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.Write("Enter new task name: ");
                        string newTask = Console.ReadLine();
                        list.createTask(newTask);
                        break;
                    case 2:
                        Console.Write("Enter task name to delete: ");
                        string delTask = Console.ReadLine();
                        list.deleteTask(delTask);
                        break;
                    case 3:
                        Console.Write("Enter task name to update: ");
                        string oldTask = Console.ReadLine();
                        Console.Write("Enter new task name: ");
                        string updatedTask = Console.ReadLine();
                        list.updateTask(oldTask, updatedTask);
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}