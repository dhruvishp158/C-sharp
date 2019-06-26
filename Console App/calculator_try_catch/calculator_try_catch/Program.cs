using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_mull
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1 = 0;
            long num2 = 0;

            do
            {
                try
                {

                    Console.Write("enter number 1:");
                    num1 = long.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    Console.WriteLine("please enter correct number");
                }
                }while (num1<0||num1> 9223372036854775807) ;
                do
                {
                    try
                    {
                        
                    Console.Write("enter number 2:");
                    num2 = long.Parse(Console.ReadLine());
                    }
                catch (System.Exception)
                {
                    Console.WriteLine("please enter correct number");
                }

            } while (num2 < 0 || num2> 9223372036854775807);


            Console.Write("\n");

            Console.WriteLine("\t\t====== RESULT OF SIMOLE CALCULATOR=======");
            Console.Write("\t\t\t Addition      : {0,20} + {1,-20} = {2,20}", num1, num2, ((Decimal)num1 + num2) + "\n");
            Console.WriteLine("\t\t=============================================================\n");
            Console.Write("\t\t\t Subtraction   : {0,20} - {1,-20} = {2,20}", num1, num2, ((Decimal)num1 - num2) + "\n");
            Console.WriteLine("\t\t=============================================================\n");
            Console.Write("\t\t\t Multiplication: {0,20} * {1,-20} = {2,20}", num1, num2, ((Decimal)num1 * num2) + "\n");
            Console.WriteLine("\t\t=============================================================\n");
            Console.Write("\t\t\t Division      : {0,20} / {1,-20} = {2,02}", num1, num2, ((Decimal)num1 / num2) + "\n");
            Console.WriteLine("\t\t=============================================================\n");

            Console.Write("press any key to exit");
            Console.ReadKey();







        }
    }
}
