using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task_2.Tests
{
    /// <summary>
    /// Class WordTest for check the correct operation of methods of the class Word
    /// </summary>
    [TestClass()]
    public class WordTest
    {
        /// <summary>
        /// Check method ChangeLetters.
        /// </summary>
        [TestMethod()]
        public void ChangeLettersTest()
        {
            //arange
            string[] args = new string[1];
            args[0] = "молоко+";
            string expected ="малако";

            //act
            Word word = new Word();
            string actual;
            actual = word.ChangeLetters(args).ToString();

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}