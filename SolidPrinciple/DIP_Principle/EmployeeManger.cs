using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DIP_Principle
{
    public class EmployeeManger :IEmployeeSearchable
    {
        private readonly List<Employee> _employees;

        public EmployeeManger()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position)
            => _employees.Where(emp => emp.Gender == gender && emp.Position == position);
    }
}

