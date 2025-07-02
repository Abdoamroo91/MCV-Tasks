using System;
using System.Collections.Generic;
using System.IO;

public class HelloWorld
{
    public static void Main(string[] args){
        List<string> tasks = new List<string>();
        string filePath = "";

        void loadTasks(string path){
            tasks.Clear();
            if (File.Exists(path)){
                tasks.AddRange(File.ReadAllLines(path));
                Console.WriteLine("Tasks loaded from " + path);
            }
            else{
                File.Create(path).Close();
                Console.WriteLine("File did not exist. A new one was created at: " + path);
            }
        }

        Console.Write("Enter the file name (ex: base.txt): ");
        string input = Console.ReadLine();
        if (input == ""){
            filePath = "base.txt";
        }
        else{
            filePath = input;
        }

        loadTasks(filePath);

        Console.Write("How many tasks do you want to enter initially? ");
        int initialCount = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < initialCount; i++)
        {
            Console.Write("Enter your " + (i + 1) + " task: ");
            string task = Console.ReadLine();

            if (tasks.Contains(task))
            {
                Console.WriteLine("This task already exists, Please enter a different task.");
                i--;
            }
            else
            {
                tasks.Add(task);
            }
        }

        while (true){
            Console.WriteLine("\nTasks:");
            if (tasks.Count > 0){
                for (int i = 0; i < tasks.Count; i++){
                    Console.WriteLine((i + 1) + ". " + tasks[i]);
                }
            }else {
                    Console.WriteLine("No tasks at the moment.");
                }

            Console.Write("\nWhat action do you want to perform?\n1 - Add\n2 - Delete\n3 - Update\n4 - Change File \n5 - Delete File \n6 - Exit \nEnter your choice: ");
            int action = Convert.ToInt32(Console.ReadLine());
            switch (action){
                case 1:
                    Console.Write("Enter a task to add: ");
                    string newTask = Console.ReadLine();
                    if (tasks.Contains(newTask)){
                        Console.WriteLine("Task already exists, You can't add duplicates.");
                    }
                    else{
                        tasks.Add(newTask);
                        File.WriteAllLines(filePath, tasks);
                    }
                    break;
                case 2:
                    Console.Write("Enter task number to delete: ");
                    int deleteIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (deleteIndex >= 0 && deleteIndex < tasks.Count){
                        tasks.RemoveAt(deleteIndex);
                        File.WriteAllLines(filePath, tasks);
                        Console.WriteLine("Task deleted.");
                    }
                    else{
                        Console.WriteLine("Invalid task number.");
                    }
                    break;
                case 3:
                    Console.Write("Enter task number to update: ");
                    int updateIndex = Convert.ToInt32(Console.ReadLine()) - 1;
                    if (updateIndex >= 0 && updateIndex < tasks.Count){
                        Console.Write("Enter the new task: ");
                        string updatedTask = Console.ReadLine();
                        if (tasks.Contains(updatedTask)){
                            Console.WriteLine("Task already exists, You can't add duplicates.");
                        }
                        else{
                            tasks[updateIndex] = updatedTask;
                            File.WriteAllLines(filePath, tasks);
                            Console.WriteLine("Task updated.");
                        }
                    }
                    else{
                        Console.WriteLine("Invalid task number.");
                    }
                    break;
                case 4:
                    Console.Write("Enter new file name (ex: tasks.txt): ");
                    filePath = Console.ReadLine();
                    loadTasks(filePath);
                    break;
                case 5:
                    Console.Write("Enter file name you want to delete (ex: tasks.txt): ");
                    filePath = Console.ReadLine();
                    File.Delete(filePath);
                    Console.WriteLine("File Deleted Successfully");
                    break;
                case 6:
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }
        }
    }
}
