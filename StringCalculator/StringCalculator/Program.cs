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
            Calculator objCalculator = new Calculator();
            int result; string negativeNumbers;
            Console.WriteLine("String Calculator");
           
            Console.WriteLine("Enter String Numbers");

            string numbers = Console.ReadLine();

            if (numbers.IndexOf("-") > 0)
            {
                negativeNumbers = objCalculator.Find_ReturnNegativeNumbers(numbers);
                Console.WriteLine("Negatives not allowed: " + negativeNumbers);
                Console.ReadLine();
            }
            else
            {
                result = objCalculator.AddStringNumbers(numbers);
                Console.WriteLine("Sum of String Intigers are " + result);
                Console.ReadLine();
            }

        }

    }
}
