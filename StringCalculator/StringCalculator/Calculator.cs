/*
    Author: Srirama Murthy Tirupatipati
    Initiated Date: 19-JAN-2019
    Description: A class for used to calculate addition of various string parameters within different methods.
    Last Modified Date: 21-JAN-2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace StringCalculator
{
    #region String calculator starts
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

        #region Variable declaration
        int result; 
        #endregion

        #region Properties declaration
        public string DelimiterType { get; set; }
        #endregion

        /// <summary>
        /// Method for calucation sum of string intigers and returns int as an ouput
        /// </summary>
        
        public int AddStringNumbers(string numbers)
        {
                    
            List<int> result_List = new List<int>();
            try
            {
                if (numbers.Length < 0)
                    return 0;
                if (numbers.Contains("//") )
                {
                    numbers = Support_DifferentDelimiters(numbers, DelimiterType);
                }

                if ((numbers.IndexOf("\\n") > 0) || (numbers.IndexOf("\\r") > 0) )
                {

                    numbers = HandlingNewLine(numbers);
                }

                if (numbers.Contains(","))
                {
                    result_List = SplitStringNumbers(numbers, ",");

                    result = SumCalculation(result_List.ToArray());
                }

                if (numbers.Contains(";"))
                {
                    result_List = SplitStringNumbers(numbers, ";");
                    result = SumCalculation(result_List.ToArray());
                }
               
           

            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
            return result;
        }


        /// <summary>
        /// Method for splitting string numbers into integer numbers array
        /// </summary>
        private static List<int> SplitStringNumbers(string snumbers, String delimeter)
        {
            List<int> intNumbers = new List<int>();           
            try
            {

                var res = snumbers.Split(new char[] { ',', '.', '/', '!', '@', '#', '$', '%', '^', '&', '*',  '\'', ';', '_', '(', ')', ':', '|', '[', ']', '\n', '\r' });

                foreach (string number in res)
                {
                    intNumbers.Add(Int32.Parse(number));
                }

                return intNumbers.ToList();
            }
            catch (Exception ex)
            {


                throw new ArgumentException(ex.Message);
            }
            
        }

        /// <summary>
        /// Sum calculator for given string intigers
        /// </summary>
        public static int SumCalculation(int[] resultArray)
        {
            try
            {            
                var sumOfNumbers = resultArray.Select(x => (int)x).Sum();
                return sumOfNumbers;
            }
            catch (Exception ex)
            {   
                
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Removing New Line, Carriage return special characters
        /// </summary>
        private static string HandlingNewLine(string inputString)
        {
            try
            {
                var result = inputString.Replace("\\n", ",").Replace("\\t", ",").Replace("\\r", ",").Replace("\\r\\n", ",");
                return result;
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }


        /// <summary>
        /// Find and through out if any negative numbers found with in the string.
        /// </summary>
        public string Find_ReturnNegativeNumbers(string numbers)
        {

            StringBuilder sb = new StringBuilder();
            try
            {
                List<int> result_List = new List<int>();
                result_List = SplitStringNumbers(numbers, ",");

                for (int i = 0; i < result_List.Count; i++)
                {
                    if (result_List[i] < 0)
                        sb.Append(result_List[i] + " ");
                }
                return sb.ToString ();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        ///Supporting different delimiters from given input string 
        /// </summary>
        public static string Support_DifferentDelimiters(string inputString,string reqiredDelimiters)
        {
            try
            {
                var chars = new string[] { ",", ".", "/", "!", "@", "#", "$", "%", "^", "&", "*", "'", "\"", ";","_", "(", ")", ":", "|", "[", "]","\\n","\\r" };
                var list = new List<string>(chars);
                list.Remove(reqiredDelimiters);

                for (int i = 0; i < list.Count; i++)
                {
                    if (inputString.Contains(list[i]))
                    {
                        inputString = inputString.Replace(list[i], "");
                    }
                }
                if (inputString.Substring(0, 1).ToString() == reqiredDelimiters)
                {
                    inputString = inputString.Substring(1, inputString.Length-1);
                }
                if (inputString.Substring(inputString.Length - 1) == reqiredDelimiters)
                {
                    inputString = inputString.Substring(0, inputString.Length - 1);
                }
                return inputString.Replace(reqiredDelimiters,",");
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

    }

    
   
    #endregion
}
