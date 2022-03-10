using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageProblemUsingOops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to the Employee Wage Problem");
            EmpWage employee = new EmpWage();
            employee.MonthlyEmpWage();
        }
    }
}