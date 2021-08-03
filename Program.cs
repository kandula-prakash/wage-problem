using System;

namespace first_program
{
    class Program
    {
        /// <summary>
        /// check employee is present or absent
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            //daily wage = per_hour_wage * hours_worked
            //add part time and wage
            // bool isPresent = true;
            int perHourWage = 1000;
            int HOURS_WORKED = 8;
            int dailyWage = 0;
            Random rand = new Random();
           
            for (int i = 0; i < 100; i++)
            {
                int present = rand.Next(0, 4);
                Console.WriteLine(present);
            }
            
            if (true)
            {
                Console.WriteLine("employee is present");
                dailyWage = perHourWage * HOURS_WORKED;

            }
            else
            {
                Console.WriteLine("employee is absent");
                Console.WriteLine("Total daily wage earned" + dailyWage);
            }
        }
    }
}
