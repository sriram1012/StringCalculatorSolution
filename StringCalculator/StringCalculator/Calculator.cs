/*
   Author: Srirama Murthy Tirupatipati
   Initiated Date: 19-JAN-2019
   Description: A class for used to calculate addition of various string parameters within different methods.
   Last Modified Date: 23-JAN-2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace StringCalculator
{
    #region String calculator Singleton class starts
    public sealed class Calculator
    {
        private static Calculator CalcObject = null;

        private Calculator()
        {
            //Default Private construction for single instanation purpose
        }

        public static Calculator _CalculatorInstance
        {
            get
            {
                return CalcObject = new Calculator();
            }
        }
        
        public string AddStringNumbers(string numbers)
        {
            try
            {


                string result = string.Empty;

                if (!string.IsNullOrEmpty(numbers))
                {
                    result = Extract_Integers_From_String(numbers);
                }
                else
                {
                    return "0";
                }
                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

        public static string Extract_Integers_From_String(string InputString)
        {
            try
            {


                StringBuilder sb = new StringBuilder();
                int n = 0;
                MatchCollection matches = Regex.Matches(InputString, @"[+-]?\d+(\.\d+)?");
                decimal[] NumberArray = new decimal[matches.Count];
                foreach (Match m in matches)
                {
                    NumberArray[n] = decimal.Parse(m.Value);
                    n++;
                }
                if (NumberArray.Min() < 0) //If found any negative number with in the input string
                {

                    foreach (int number in NumberArray)
                    {
                        if (number < 0)
                        {
                            sb.Append(number + ",");
                        }
                    }
                    return string.Format("Negatives not allowed {0}", sb.ToString().TrimEnd(','));
                }
                else
                {
                    var sumOfNumbers = NumberArray.Select(x => (int)x).Sum();
                    return Convert.ToString(sumOfNumbers);
                }
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }
    }
    #endregion
}
