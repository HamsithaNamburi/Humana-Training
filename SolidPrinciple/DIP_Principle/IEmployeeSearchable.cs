using System;
using System.Collections.Generic;
using System.Text;

namespace DIP_Principle
{
   public  interface IEmployeeSearchable
    {
        IEnumerable<Employee> GetEmployeesByGenderAndPosition(Gender gender, Position position);
    }
}

