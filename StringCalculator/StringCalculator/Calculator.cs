﻿/*
    Author: Srirama Murthy Tirupatipati
    Initiated Date: 19-JAN-2019
    Description: A class for used to calculate addition of various string parameters within different methods.
    Last Modified Date: 20-JAN-2019
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text;

namespace StringCalculator
{
    #region String calculator starts
    public class Calculator
    {
        #region Variable declaration
        int result; string negativeNumbers;
        #endregion

        /// <summary>
        /// Method for calucation sum of string intigers and returns int as an ouput
        /// </summary>
        
        public int AddStringNumbers(string numbers)
        {
            int[] resultArray = new int[100];
            try
            {
                if (numbers.Length < 0)
                    return 0;
                if (numbers.IndexOf("-") > 0)
                {
                    resultArray = SplitStringNumbers(numbers, ",");
                    negativeNumbers = ReturnNegativeNumbers(resultArray);
                }
                if ((numbers.IndexOf("\\n") > 0) || (numbers.IndexOf("\\r") > 0) )
                {
                    
                    numbers = RemoveSpecialCharacters(numbers);
                }

                if (numbers.Contains(","))
                {
                   resultArray = SplitStringNumbers(numbers, ",");
                   result = SumCalculation(resultArray);
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
        private static int[] SplitStringNumbers(string snumbers,string delimeter)
        {
            List<int> intNumbers = new List<int>();
            try
            {
                foreach (string number in snumbers.Split(','))
                    intNumbers.Add(Int32.Parse(number));
                
                return intNumbers.ToArray();
            }
            catch (Exception ex)
            {


                throw new ArgumentException(ex.Message);
            }
            
        }

        private static int SumCalculation(int[] resultArray)
        {
            try
            {
                var sumOfNumbers = resultArray.Where(x => x <= 100).Sum();
                return sumOfNumbers;
            }
            catch (Exception ex)
            {
                
                throw new ArgumentException(ex.Message);
            }
        }

        private static string RemoveSpecialCharacters(string inputString)
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

        private string ReturnNegativeNumbers(int[] resultArray)
        {
            StringBuilder sb = new StringBuilder();
            try
            {
                for (int i = 0; i < resultArray.Length; i++)
                {
                    if (resultArray[i] < 0)
                        sb.Append(resultArray[i] + " ");
                }
                return sb.ToString ();
            }
            catch (Exception ex)
            {

                throw new ArgumentException(ex.Message);
            }
        }

    }

    
   
    #endregion
}
