using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_DI_MethodInjection.Model
{
    public class Employee {
        public int EmployeeId;
        public string EmployeeName;
        public IDepartment EmployeeDept; // Field

        // Default Constructor added for .NET Core DI Container.
        // So that it can automatically create the instance.
        public Employee() { }
        //---------------------------------------------
        public Employee(int id, string name){
            EmployeeId = id;
            EmployeeName = name;
        }
        //---------------------------------------------
        public void AssignDepartment(IDepartment dept){
            EmployeeDept = dept ?? throw new ArgumentNullException("Null");
            // Other business logic if required.
        }
        //---------------------------------------------
        public override string ToString(){
            return $"EmpID:{EmployeeId},Emp Name:{EmployeeName}," +
                $"Department:{EmployeeDept.DeptName}";
        }
    }
}
