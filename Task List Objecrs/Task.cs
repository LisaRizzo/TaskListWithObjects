using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_List_Objects
{
  public class Task
  {
    // Global variables
    public string TeamMemberName { get; private set; }
    public string Description { get; private set; }
    public DateTime DueDate { get; private set; }
    public bool Completed { get; private set; }

    // Constructor
    public Task(string TeamMemberName, string Description, DateTime DueDate, bool Completed)
    {
      this.TeamMemberName = TeamMemberName;
      this.Description = Description;
      this.DueDate = DueDate;
      this.Completed = Completed;
    }
    public Task(string Name, string Description, DateTime DueDate)
    {
      this.TeamMemberName = Name;
      this.Description = Description;
      this.DueDate = DueDate;
      this.Completed = false;
    }
    public void UpdateTask()
    {
      Completed = !Completed;
    }
  }
}
