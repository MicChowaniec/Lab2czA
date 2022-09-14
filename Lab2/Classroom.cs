namespace Lab2
{
    internal class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name { get { return name; } }

        public Classroom(string name, Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }

        public override string ToString()
        {
            string ptext = "Classroom: " + Name+"\n\n";
            foreach (var person in persons)
            {
                ptext += person.ToString()+"\n";
            }
            return ptext;
           
           
        }
    }
}