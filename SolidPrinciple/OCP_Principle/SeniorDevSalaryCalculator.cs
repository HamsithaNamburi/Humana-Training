using System;
using System.Collections.Generic;
using System.Text;

namespace OCP_Principle
{
    class SeniorDevSalaryCalculator:BaseSalaryCalculator
    {
        public SeniorDevSalaryCalculator(DeveloperReport report)
       : base(report)
        {
        }

        public override double CalculateSalary() => DeveloperReport.HourlyRate * DeveloperReport.WorkingHours * 1.2;
    
}
}
