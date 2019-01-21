﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringCalculator;


namespace StringCalculatorUnitTest
{
    [TestClass]
    public class StringCalculatorsUnitTesting
    {
        


        /// <summary>
        /// Test Method for Empty string values addition
        /// </summary>
        [TestMethod]
        public void Add_EmptyStringValues()
        {
           AssertTestMethod("", 0);
        }
        /// <summary>
        /// Test Method for Add one string intiger
        /// </summary>
        [TestMethod]
        
        public void Add_OneStringIntiger()
        {
            AssertTestMethod("1", 1);
        }

        /// <summary>
        /// Test Method for Add two string intiger
        /// </summary>
        [TestMethod]
        public void Add_TwoStringIntiger()
        {
            
            AssertTestMethod("5,6", 11);
        }

        /// <summary>
        /// Test Method for Add two,three,four string intigers
        /// </summary>
        [TestMethod]
        [DataRow("5,5", 10,DisplayName="Two String Intigers")]
        [DataRow("10,20,30", 60, DisplayName = "Three String Intigers")]
        [DataRow("1,2,3,4", 10, DisplayName = "Four String Intigers")]
        [DataRow("1,2,3,4,5,6,7,8,9,10", 55, DisplayName = "Unknow amount of String Intigers")]
        public void Calucator_DataRowTestMethods(string inputString, int ExpResult)
        {
            AssertTestMethod(inputString, ExpResult);
        }


        /// <summary>
        /// Common Assert Method for Tests
        /// </summary>
        private static void AssertTestMethod(string Input, int ExpResult)
        {
            Calculator objCalc = new Calculator();
            Assert.AreEqual(ExpResult,objCalc.AddStringNumbers(Input));
        }
            
    }
}
