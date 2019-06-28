using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            byte option = 0;
            double n1 = 0;

            Console.Write("Enter a value to convert :");
            try
            {
                n1 = Convert.ToDouble(Console.ReadLine());
                // ConvertArea obj1 = new ConvertArea(n1);
                ConvertArea obj1 = new ConvertArea();
                obj1.Num1 = n1;
                do
                {
                    Console.Clear();
                    Console.Write("Enter 1 to convert from cm to in \n" +
                    "Enter 2 to convert from m to yard \n" +
                    "Enter 3 to convert from yards to acres \n" +
                    "Enter 4 to convert from km to Mile \n" +
                    "Enter 5 to Quit \n");
                    option = Convert.ToByte(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            {
                                Console.WriteLine("For {0} cm. you have {1} in.", n1, obj1.cmToIn());
                                Console.ReadKey();
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("For {0} m. you have {1} yard(s)", n1, obj1.mToYd());
                                Console.ReadKey();
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("For {0} hectar(s) you have {1} acre(s)", n1, obj1.hectarToAcre());
                                Console.ReadKey();
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("For {0} km. you have {1} Mile(s)", n1, obj1.kmToMile());
                                Console.ReadKey();
                            }
                            break;
                        case 5:
                            {
                                Console.WriteLine("Now you are quitting the application.");
                                Console.ReadKey();
                            }
                            break;
                        default:
                            { }
                            break;
                    }//end switch
                } while (option != 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }//end Main
    }

    public class ConvertArea
    {
        private double num1;//private fields

        public double Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public ConvertArea() { }
        public ConvertArea(double n1)
        {
            Num1 = n1;
        }

        public double cmToIn()
        {
            return (Num1 * 0.1550);
        }

        public double mToYd()
        {
            return (Num1 * 1.1960);
        }

        public double hectarToAcre()
        {
            return (Num1 * 2.4711);
        }

        public double kmToMile()
        {
            return (Num1 * 0.3861);
        }

    }

}
