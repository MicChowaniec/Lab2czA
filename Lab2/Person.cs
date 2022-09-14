namespace Lab2
{
    

    public class Person :IEquatable<Person>
    {
        protected string name;
        public string Name { get { return name; } }
        protected int age;
        public int Age { get { return age; } } 

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            
        }

        public bool Equals(Person? other)
        {
            if (other == null) return false;
            if (other.Name != name) return false;
            if (!age.Equals(other.age)) return false;
            return true;
        }

        public override string ToString()
        {
            return "Name (" +age+" y.o.)"+"\n";
        }
    }
}