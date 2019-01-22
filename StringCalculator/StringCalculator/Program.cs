using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    class Program
    {
        /// <summary>
        /// Instaniation for String calculator and calling default add method
        /// </summary>

        
        static void Main(string[] args)
        {
            try
            {


                
                int result; string negativeNumbers;
                Console.WriteLine("String Calculator");

                Console.WriteLine("Enter String Numbers");

                string numbers = Console.ReadLine();

                if (numbers.IndexOf("-") > 0)
                {
                    negativeNumbers = Calculator._CalculatorInstance.Find_ReturnNegativeNumbers(numbers);
                    Console.WriteLine("Negatives not allowed: " + negativeNumbers);
                    Console.ReadLine();
                }
                else if (numbers.Contains("//"))
                {
                    Console.WriteLine("Enter Delimiter Type");                   
                    Calculator._CalculatorInstance.DelimiterType = Console.ReadLine();
                    var num=Calculator.Support_DifferentDelimiters(numbers, Calculator._CalculatorInstance.DelimiterType);
                    result = Calculator._CalculatorInstance.AddStringNumbers(num);
                    Console.WriteLine("Sum of String Intigers are " + result);
                    Console.ReadLine();

                }
                else
                {
                    result = Calculator._CalculatorInstance.AddStringNumbers(numbers);
                    Console.WriteLine("Sum of String Intigers are " + result);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

    }
}
