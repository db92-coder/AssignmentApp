using System;
using System.Collections.Generic;

namespace AssignmentApp
{
    abstract class Agency
    {
        public abstract void Generate();
        private static MySqlConnection GetConnection()
        {
            if (conn == null)
            {
                string connectionString =
                    String.Format("Database = {0};Data Source={1}; User Id = {2}; Password = {3}",
                    db, server, user, pass);

                conn = new MySqlConnection(connectionString);
            }
            return conn;
        }
    }




    class newClass : Agency
    {
        public override void Generate()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee{Name = "Jane Adams", ID = 1, Gender = "Female"},
                new Employee{Name = "John Smith", ID=2, Gender = "Male"}
            };
            Console.WriteLine("");
            foreach (Employee employee in employees)
                if (employee.Gender == "Male")
                    Console.WriteLine(employee.Name + " is " + employee.Gender);

            var maleStaff = from staffMbr in employees
                            where staffMbr.Gender == Gender.M
                            orderby staffMbr.Name
                            select staffMbr;
        }
    }


}

