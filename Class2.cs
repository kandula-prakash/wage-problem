using System;
using System.Collections.Generic;
using System.Text;

namespace line_comarision
{
    class Class2
    {
        public static void thirdproblem()
        {


            Console.WriteLine("welcome to line  comparision computtation");
            // uc -2 equality of two lines
            double x1, x2, y1, y2;
            double a1, a2, b1, b2;
            Console.WriteLine("enter the co-ordinates of line1");
            Console.WriteLine("enter co-ordinates(x1,y1): ");
            x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter co-ordinates(x2,y2): ");
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the co-ordinates of line2");
            Console.WriteLine("enter co-ordinates(a1,b1): ");
            a1 = double.Parse(Console.ReadLine());
            b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter co-ordinates(a2,b2): ");
            a2 = double.Parse(Console.ReadLine());
            b2 = double.Parse(Console.ReadLine());
            double lentgh1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double lentgh2 = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((a2 - b1), 2));
            if (lentgh1 == lentgh2)
            {
                Console.WriteLine("the lentgh of two lines is equal.");


            }
            else if (lentgh1> lentgh2)
            {
                Console.WriteLine("the length of line is greater than line2.");

            }
            else if (lentgh1<lentgh2)
            {

                Console.WriteLine("the length of line is less than line2.");
            }
         
            }
        }
    }

