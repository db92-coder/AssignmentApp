namespace AssignmentApp
{
    public class Employee
    {
        private string name;
        private int id;
        private string gender;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public Employee(string name, int id, string gender)
        {
            this.name = name;
            this.id = id;
            this.gender = gender;
        }
        enum Gender
        {
            Male = 'M',
            Female = 'F',
            NonBinary = 'X'

        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return "Name: " + name + ", ID: " + id + ", Gender: " + gender + ".";
        }

    }
}
