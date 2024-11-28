using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_CSharp
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello world");
            //Console.WriteLine(3 + 3);
            //Console.Write("Hello World! ");
            //Console.Write("I will print on the same line.");

            //int age = 10;
            //Console.WriteLine(age);
            //const int count = 10;
            //Console.WriteLine($"{count} {age}");

            //case : 1
            /*
            double CGPa = 3.00;
            double myCGPa = 2.98;
            bool isGAa = false;

            if(myCGPa > CGPa)
            {
                Console.WriteLine("Congratulation You have get Frist Class");
            }
            else
            {
                Console.WriteLine("You have not get Frist Class");
            }
            */


            //case: 2
            //Nullable Types (int?): Allow variables to hold null values, useful for optional data.
            /*   int? run = null;
               if(run.HasValue)
               {
                   Console.WriteLine($"Your score is :  {run}");
               }
               else
               {
                   Console.WriteLine("run is null");
               }*/

            //case: 3
 
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                default:
                    Console.WriteLine("Other day");
                    break;
            }

        }
    }
}
