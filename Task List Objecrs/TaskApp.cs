using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List_Objects
{
  public class TaskApp
  {
    public List<Task> Tasks = new List<Task>();
    public void Run()
    {
      bool run = true;
      while (run)
      {
        Menu();
        Console.Write("What would you like to do? ");
        int userInput = int.Parse(Console.ReadLine());
        if (userInput == 1)
        {
          ListTasks();
          Console.WriteLine("------");
          continue;
        }
        else if (userInput == 2)
        {
          AddTask();
          Console.WriteLine("------");
          continue;
        }
        else if (userInput == 3)
        {
          DeleteTask();
          Console.WriteLine("------");
          continue;
        }
        else if (userInput == 4)
        {
          MarkTaskComplete();
          Console.WriteLine("------");
          continue;
        }
        else if (userInput == 5)
        {
          Console.WriteLine("Bye!");
          break;
        }
        else
        {
          Console.WriteLine("I didn't understand. Please select 1-5.");
          Console.WriteLine("------");
          continue;
        }
      }
    }
    public void AddTask()
    {
      Console.Write("Enter your name: ");
      string Name = Console.ReadLine();
      Console.Write("Enter a task to add: ");
      string Description = Console.ReadLine();
      Console.Write("Enter Due Date: MM/DD/YYYY ");
      DateTime Date = Convert.ToDateTime(Console.ReadLine());

      Task x = new Task(Name, Description, Date, false);
      Tasks.Add(x);
    }
    public void ListTasks()
    {
      Console.WriteLine("In your task list: ");

      for (int i = 0; i < Tasks.Count; i++)
      {
        Console.WriteLine($"Task {i + 1}. {Tasks[i].Description} added by {Tasks[i].TeamMemberName} on {Tasks[i].DueDate}. Task is completed?: {Tasks[i].Completed}");
      }
      if (Tasks.Count == 0)
      {
        Console.Write("There are no tasks in list!");
      }
    }
    public void DeleteTask()
    {
      if (Tasks.Count > 0)
      {
        Console.WriteLine("Which task do you want to remove?");
        ListTasks();
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Are you sure?");
        string z = Console.ReadLine();
        bool confirmed = YesOrNo(z);
        if (confirmed)
        {

          Tasks.RemoveAt(y - 1);
        }
      }
      else
      {
        Console.WriteLine("No tasks to delete!");
        return;
      }
    }
    public bool YesOrNo(string userAnswer)
    {
      Console.WriteLine(userAnswer);
      string answer = Console.ReadLine().ToLower();
      if (answer == "y" || answer == "yes")
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public void MarkTaskComplete()
    {
      ListTasks();
      if (Tasks.Count > 0)
      {
        Console.Write("Choose a task to toggle complete: ");
        int taskNum = int.Parse(Console.ReadLine());

        bool confirmed = YesOrNo("Are you sure?");
        if (confirmed)
        {
          Tasks[taskNum - 1].UpdateTask();
        }
        else
        {
          return;
        }
      }
      else
      {
        Console.WriteLine("No tasks to mark complete!");
        return;
      }
    }
    public void Menu()
    {
      Console.WriteLine();
      Console.WriteLine("  1) List tasks");
      Console.WriteLine("  2) Add task");
      Console.WriteLine("  3) Delete task");
      Console.WriteLine("  4) Mark task complete");
      Console.WriteLine("  5) Quit");
      Console.WriteLine();
    }
  }
}
