using Task = Lab2.Task;

namespace Lab2
    
{
    public class Task : IEquatable<Task>
    {
        private string name;
        private TaskStatus status;
        public string Name { get { return name; } }
        public TaskStatus Status { get { return status; }  set { status = value; } }

        public Task(string name, TaskStatus status)
        {
            this.name = name;
            this.status = status;
        }

        bool IEquatable<Task>.Equals(Task? other)
        {
            if (other == null) return false;
            if ((other.Name == this.Name)&&(other.Status == this.Status)) return true;  
            return false;
        }

        public override string ToString()
        {
            return Name + "[" + Status + "]"; 
        }
    }
}
