using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task_2;

namespace Task_2Test
{
    /// <summary>
    ///Class ErrorHandlingTest for check the correct operation of methods of the class ErrorHandling
    /// </summary>
    [TestClass()]
    public class ErrorHandlingTest
    {
        ErrorHandling errorHandling;
        /// <summary>
        /// Method is called before this class's method will be called. Create object classa Errorhandling
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
           errorHandling = new ErrorHandling();
        }

        /// <summary>
        /// Check method CheckEmptyString on its reaction on empty string
        /// </summary>
        [TestMethod]
        public void CheckForEmptyString_ReturnFalse()
        {
            //arange
            bool expected = false;

            //act
            bool actual = errorHandling.CheckEmptyString(null);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check method CheckEmptyString. The correctness of its reaction to the string
        /// </summary>
        [TestMethod]
        public void CheckForString_ReturnTrue()
        {
            //arange
            string[] args = new string[1];
            args[0] = "string";
            bool expected = true;

            //act
            errorHandling = new ErrorHandling();
            bool actual = errorHandling.CheckEmptyString(args);

            //assert
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Check method CheckStress. The correctness of its reaction to the string without stress
        /// </summary>
        [TestMethod]
        public void CheckForWordWithoutStress_ReturnFalse()
        {
            //arange
            string[] args = new string[1];
            args[0] = "лоло";
            bool expected = false;

            //act
            errorHandling = new ErrorHandling();
            bool actual = errorHandling.CheckStress(args);

            //assert
            Assert.AreEqual(expected, actual);
        }

        public TestContext TestContext { get; set; }
        /// <summary>
        /// Check method CheckStress. The correctness of its reaction to the string with stress or to the string that doesn't need in stress.
        /// Uses XML-file for check different words without duplication method. 
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\WordsForCheckStress.xml", "Word", DataAccessMethod.Sequential), DeploymentItem("WordsForCheckStress.xml"), TestMethod]
        public void CheckForWordWithStress_ReturnTrue()
        {
            //arange
            string[] args = new string[1];
            args[0] = Convert.ToString(TestContext.DataRow["value"]);
            bool expected = true;

            //act
            errorHandling = new ErrorHandling();
            bool actual = errorHandling.CheckStress(args);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
