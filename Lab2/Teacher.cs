namespace Lab2
{
    public class Teacher : Person
    {


        public Teacher(string name, int age) : base(name, age)
        {
            this.name=name;
            this.age = age;
        }

        public override string ToString()
        {
            return "Treacher: " + Name+ " (" + Age + " y.o.)" + "\n" ;
        }
    }
}