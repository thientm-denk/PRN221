using System;

namespace DemoDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Department
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DepartmentID { get; set; }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string EmployeeName { get; set; }
        public Department Department { get; set; } // Property
        
        public Employee(Department de) // Constructor
        {

        }
    }
}
