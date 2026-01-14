using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageComputation {
    internal interface IEmployee {
        void AddEmployee(Employee employee);
        Employee? GetEmployee(int id);
    }
}
