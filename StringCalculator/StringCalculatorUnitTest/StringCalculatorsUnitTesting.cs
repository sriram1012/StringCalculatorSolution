using System;
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
        Calculator objCalc = new Calculator();


        /// <summary>
        /// Test Method for Empty string values addition
        /// </summary>
        [TestMethod]
        public void Add_EmptyStringValues()
        {
           Assert.AreEqual(0,objCalc.AddStringNumbers(""));
        }
        /// <summary>
        /// Test Method for Add one string intiger
        /// </summary>
        [TestMethod]
        [DataRow("5", 5)]
        [DataRow("10", 10)]
        public void Add_OneStringIntiger()
        {
            Assert.AreEqual(1, objCalc.AddStringNumbers("1"));
        }

        /// <summary>
        /// Test Method for Add two string intiger
        /// </summary>
        [TestMethod]
        public void Add_TwoStringIntiger()
        {
            Assert.AreEqual(11, objCalc.AddStringNumbers("5,6"));
        }

            
    }
}
