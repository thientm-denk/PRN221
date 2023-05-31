
 using System;
 using Demo_DI_PropertyInjection.Model;
 namespace Demo_DI_PropertyInjection{
    class Program{
        static void Main(string[] args) {
            Console.Title = "DI-Property Injection";
            Employee emp1 = new Employee(1, "David"){
                EmployeeDept = new Engineering()
            };

            Employee emp2 = new Employee(2, "Jack") {
                EmployeeDept = new Marketing()
            };
            Console.WriteLine(emp1);
            Console.WriteLine(new string('-',20));
            Console.WriteLine(emp2);
            Console.ReadLine();
        }
    }
 }
