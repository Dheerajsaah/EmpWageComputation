using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HOUR = 20, FULL_TIME_HR = 8;
        public void Attendence()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
        public void CalculateEmpWage()
        {

            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                int totalEmpWage = WAGE_PER_HOUR * FULL_TIME_HR;
                Console.WriteLine(totalEmpWage);
            }
        }

         
    }
}
