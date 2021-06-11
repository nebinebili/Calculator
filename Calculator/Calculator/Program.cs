using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1=0, number2=0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\tCALCULATOR");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t+ \n\t/ \n\t- \n\t*");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Write("\n\nInclude choose : ");
                bool isOkay = char.TryParse(Console.ReadLine(), out char choose);

                Console.Write("\nEnter number1-> ");
                number1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nEnter number2-> ");
                number2 = Convert.ToDouble(Console.ReadLine());

                switch (choose)
                {
                    case '+':
                        {
                            // param keyword example
                            //var result = AddParam(2, 3.5, 45, 12);

                            var result = Add(number1, number2);
                            Console.WriteLine($"Result->{result}");
                            break;
                        }
                    case '-':
                        {
                            var result = Subtraction(number1, number2);
                            Console.WriteLine($"\nResult->{result}");
                            break;
                        }
                    case '*':
                        {
                            var result = Multiply(number1, number2);
                            Console.WriteLine($"\nResult->{result}");
                            break;
                        }
                    case '/':
                        {
                            var result = Device(number1, number2);
                            Console.WriteLine($"\nResult->{result}");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Choose is wrong");
                            break;
                        }
                }
            }
            

            Console.ReadLine();
            
        }
        static double AddParam(double [] array)
        {
            return array.Sum();
        }
       static double Add(double number1, double number2)
       {
            return number1 + number2;
       }
       
       static double Subtraction(double number1,double number2)
       {
            return number1 - number2;
       }
        static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }
        static double Device(double number1, double number2)
        {
            return number1 / number2;
        }
    }
}
