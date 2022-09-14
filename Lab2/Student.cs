using Lab2;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using Task = Lab2.Task;
using TaskStatus = Lab2.TaskStatus;

namespace Lab2
{
    public class Student : Person
    {
        protected string group;
        public string Group { get { return group; } }

        protected List<Task> tasks;

        public Student(string name, int age, string group) : base(name, age)
        {
            this.group = group;
            this.tasks = new List<Task>();
        }

        public Student(string name, int age, string group, List<Task> tasks) : base(name, age)
        {
            this.group = group;
            
            this.tasks = tasks;

        }


        public void AddTask(string taskName, TaskStatus taskStatus)
        {
            if (tasks == null)
            {
                this.tasks=new List<Task>();
            }
            tasks.Add(new Task(taskName, taskStatus));
        } 

        public void RemoveTask(int index)
        {

        }

        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            tasks[index].Status=taskStatus;
            
        }
        public void RenderTask(String prefix)
        {

        }

        public override string ToString()
        {
            string blanche="Tasks:\n";
            int i=0;
            foreach(var task in tasks)
             {
                 i++;
                 blanche += "  "+i + ". " + task.ToString()+"\n";
             }
            return "Student: " + Name + " (" + Age + " y.o.) \nGroup: " +Group +"\n" + blanche; 
        }
    }
}
