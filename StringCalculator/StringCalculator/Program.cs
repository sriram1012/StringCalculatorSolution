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
            int result;
            Console.WriteLine("String Calculator");
            Console.ReadLine();
            Console.WriteLine("Enter String Numbers");

            string numbers = Console.ReadLine();

            result=objCalculator.AddStringNumbers(numbers);
            Console.WriteLine("Sum of String Intigers are "+ result);
            Console.ReadLine();

        }

    }
}
