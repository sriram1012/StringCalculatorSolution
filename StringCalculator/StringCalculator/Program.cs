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

            Mainloop:                
                Console.WriteLine("String Calculator");
                Console.WriteLine("Enter String Numbers to calculate the Sum");
                string numbers = Console.ReadLine();
                Console.WriteLine(Calculator._CalculatorInstance.AddStringNumbers(numbers));
                Console.WriteLine("Enter 1 to Continue, or enter any other key for exit");
                string UserInput = Console.ReadLine();
                if (UserInput == "1")
                    goto Mainloop;
                
            }
            catch (NotSupportedException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

    }
}
