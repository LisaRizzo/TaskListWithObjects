using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List_Objects
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Task Manager!");
      TaskApp t = new TaskApp();
      t.Run();
    }
  }
}
