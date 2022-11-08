using System;

namespace EmpWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagePerHr = 20;
            int wage = 0, empHr = 0;
            Random random = new Random();
            int check = random.Next(0, 2);
            if (check == 0)
            {
                empHr = 8;
            }
            else
            {
                empHr = 0;
            }

            wage = wagePerHr * empHr;
            Console.WriteLine("Total Wage=" + wage);
        }
    }
}