using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation {
    internal class Employee {
        public int EmployeeID;
        public int Age;
        public string? EmployeeName;
        public string? Designation;
        public string? PhoneNumber;
        
        public Employee(int EmployeeID,int Age,string EmployeeName,string Designation,string PhoneNumber) {
            this.EmployeeID = EmployeeID;
            this.Age = Age;
            this.EmployeeName = EmployeeName;
            this.Designation = Designation;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
