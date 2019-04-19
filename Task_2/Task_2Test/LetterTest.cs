using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Task_2.Tests
{
    /// <summary>
    /// /Class LetterTest for check the correct operation of methods of the class Letter
    /// </summary>
    [TestClass()]
    public class LetterTest
    {
        Letter letter;

        /// <summary>
        /// Method is called before this class's method will be called. Create object classa Letter
        /// </summary>
        [TestInitialize]
        public void TestInitialize()
        {
            letter = new Letter();
        }

        public TestContext TestContext { get; set; }

        /// <summary>
        ///Check method ChangeVowel_1. The correctness of its reaction to the entered letter (that this meyhod has): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.  
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataForChangeVowel_1.xml", "Letter", DataAccessMethod.Sequential), DeploymentItem("DataForChangeVowel_1.xml"), TestMethod]
        public void ChangeVowel_1TestForSpecificLetter()
        {
            //Valid letter's code
            int expected = 1; 
            char pairedLetter;

            char validPairedLetter= Convert.ToChar(TestContext.DataRow["pairedLetter"]); 
            char inputedLetter= Convert.ToChar(TestContext.DataRow["value"]);

            //Returned letter's code
            int actual = letter.ChangeVowel_1(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeVowel_1. The correctness of its reaction to the entered letter (that this meyhod doesn't have): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method. 
        /// </summary>
        [TestMethod()]
        public void ChangeVowel_1TestForOtherLetter()
        {
            //Valid letter's code
            int expected = 0;
            char pairedLetter;

            char validPairedLetter = 'н';
            char inputedLetter = 'н';

            //Returned letter's code
            int actual = letter.ChangeVowel_1(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeVowel_2. The correctness of its reaction to the entered letter (that this meyhod has): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataForChangeVowel_2.xml", "Letter", DataAccessMethod.Sequential), DeploymentItem("DataForChangeVowel_2.xml"), TestMethod]
        public void ChangeVowel_2TestForSpecificLetter()
        {
            //Valid letter's code
            int expected = 2;
            char pairedLetter;

            char validPairedLetter = Convert.ToChar(TestContext.DataRow["pairedLetter"]);
            char inputedLetter = Convert.ToChar(TestContext.DataRow["value"]);

            //Returned letter's code
            int actual = letter.ChangeVowel_2(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeVowel_2. The correctness of its reaction to the entered letter (that this meyhod doesn't have): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [TestMethod()]
        public void ChangeVowel_2TestForOtherLetter()
        {
            //Valid letter's code
            int expected = 0;
            char pairedLetter;

            char validPairedLetter = 'н';
            char inputedLetter = 'н';

            //Returned letter's code
            int actual = letter.ChangeVowel_2(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeConsonant_1. The correctness of its reaction to the entered letter (that this meyhod has): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataForChangeConsonant_1.xml", "Letter", DataAccessMethod.Sequential), DeploymentItem("DataForChangeConsonant_1.xml"), TestMethod]
        public void ChangeConsonant_1TestForSpecificLetter()
        {
            //Valid letter's code
            int expected = Convert.ToInt32(TestContext.DataRow["code"]);
            char pairedLetter;

            char validPairedLetter = Convert.ToChar(TestContext.DataRow["pairedLetter"]);
            char inputedLetter = Convert.ToChar(TestContext.DataRow["value"]);

            //Returned letter's code
            int actual = letter.ChangeConsonant_1(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeConsonant_1. The correctness of its reaction to the entered letter (that this meyhod doesen't have): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [TestMethod()]
        public void ChangeConsonant_1TestForOtherLetter()
        {
            //Valid letter's code
            int expected = 0;
            char pairedLetter;

            char validPairedLetter = 'н';
            char inputedLetter = 'н';

            //Returned letter's code
            int actual = letter.ChangeConsonant_1(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method ChangeConsonant_2. The correctness of its reaction to the entered letter (that this meyhod has): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataForChangeConsonant_2.xml", "Letter", DataAccessMethod.Sequential), DeploymentItem("DataForChangeConsonant_2.xml"), TestMethod]
        public void ChangeConsonant_2TestForSpecificLetter()
        {
            //Valid letter's code
            int expected = 4;
            char pairedLetter;

            char validPairedLetter = Convert.ToChar(TestContext.DataRow["pairedLetter"]);
            char inputedLetter = Convert.ToChar(TestContext.DataRow["value"]);

            //Returned letter's code
            int actual = letter.ChangeConsonant_2(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        ///Check method ChangeConsonant_2.The correctness of its reaction to the entered letter(that this meyhod doesen't have): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [TestMethod()]
        public void ChangeConsonant_2TestForOtherLetter()
        {
            //Valid letter's code
            int expected = 0;
            char pairedLetter;

            char validPairedLetter = 'н';
            char inputedLetter = 'н';

            //Returned letter's code
            int actual = letter.ChangeConsonant_2(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        ///Check method OtherLetters.The correctness of its reaction to the entered letter(that this meyhod hase): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\DataForOtherLetters.xml", "Letter", DataAccessMethod.Sequential), DeploymentItem("DataForOtherLetters.xml"), TestMethod]
        public void OtherLettersTestForSpecificLetter()
        {
            //Valid letter's code
            int expected = Convert.ToInt32(TestContext.DataRow["code"]);
            char pairedLetter;

            char validPairedLetter = Convert.ToChar(TestContext.DataRow["pairedLetter"]);
            char inputedLetter = Convert.ToChar(TestContext.DataRow["value"]);

            //Returned letter's code
            int actual = letter.OtherLetters(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }

        /// <summary>
        /// Check method OtherLetters.The correctness of its reaction to the entered letter(that this meyhod doesen't have): returned paired letter and returned code. 
        /// Uses XML-file for check different words without duplication method.
        /// </summary>
        [TestMethod()]
        public void OtherLettersTestForOtherLetter()
        {
            //Valid letter's code
            int expected = 0;
            char pairedLetter;

            char validPairedLetter = 'н';
            char inputedLetter = 'н';

            //Returned letter's code
            int actual = letter.OtherLetters(inputedLetter, out pairedLetter);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(validPairedLetter, pairedLetter);
        }
    }
}
