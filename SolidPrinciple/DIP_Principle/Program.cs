using System;

namespace DIP_Principle
{
    public enum Gender
    {
        Male,
        Female
    }
    public enum Position
    {
        Administrator,
        Manager,
        Executive
    }
    class Program
    {
        static void Main(string[] args)
        {
            var empManager = new EmployeeManger();
            empManager.AddEmployee(new Employee { Name = "Leen", Gender = Gender.Female, Position = Position.Manager });
            empManager.AddEmployee(new Employee { Name = "Mike", Gender = Gender.Male, Position = Position.Administrator });

            var stats = new EmployeeStatistics(empManager);
            Console.WriteLine($"Number of female managers in our company is: {stats.CountFemaleManagers()}");
        }
    }
    
}
