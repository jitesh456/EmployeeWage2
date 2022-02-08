using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int PRESENT = 0;
           
            int PARTIAL_PRESNT = 1;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == 0)
            {
                Console.WriteLine("Employee is present");
            }
            else if (empCheck == PARTIAL_PRESNT)
            {
                Console.WriteLine("Employee is partial present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}
