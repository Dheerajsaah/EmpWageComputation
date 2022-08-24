using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpWageComputation
{
    internal class EmployeeWage
    {
        const int IS_FULL_TIME = 0, WAGE_PER_HOUR = 20, FULL_TIME_HR = 8, PART_TIME = 4;
        int totalEmpWage = 0, empHrs = 0;
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
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_FULL_TIME;
                    empHrs = FULL_TIME_HR;
                    break;
                    case PART_TIME;
                    empHrs = PART_TIME;
                    break;
                    {
                        totalEmpWage = WAGE_PER_HOUR * empHrs;
                        Console.WriteLine(totalEmpWage);

                    }
            }
        }

         
    }
}
