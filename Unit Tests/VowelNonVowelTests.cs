using Investec_Assessment.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class VowelNonVowelTests
    {
        [TestMethod]
        public void ReturnsDefaultOnNullOrEmptyInput()
        {
            //Arrange
            string emptyInput = string.Empty;
            string nullInput = null;
            string expectedReturn = @"The text has an equal amount of vowels and non vowels";

            //Act
            var operationReturnOnEmpty = emptyInput.EvaluateVowelNonVowel();
            var operationReturnOnNull = nullInput.EvaluateVowelNonVowel();

            //Assert
            Assert.IsTrue(operationReturnOnEmpty == expectedReturn && operationReturnOnNull == expectedReturn);
        }

        [TestMethod]
        public void ReturnsPositiveVowelNonVowelResult()
        {
            //Arrange
            string input = @"I eat";
            string expectedReturn = @"The text has more vowels than non vowels";

            //Act
            var operationReturn = input.EvaluateVowelNonVowel();

            //Assert
            Assert.IsTrue(operationReturn == expectedReturn);
        }

        [TestMethod]
        public void ReturnsNegativeVowelNonVowelResult()
        {

            //Arrange
            string input = @"that dog";
            string expectedReturn = @"The text has more non vowels than vowels";

            //Act
            var operationReturn = input.EvaluateVowelNonVowel();

            //Assert
            Assert.IsTrue(operationReturn == expectedReturn);
        }

        [TestMethod]
        public void ReturnsDefaultOnEqualInput()
        {
            //Arrange
            string input = "3 a";
            string expectedReturn = @"The text has an equal amount of vowels and non vowels";

            //Act
            var operationReturn = input.EvaluateVowelNonVowel();

            //Assert
            Assert.IsTrue(operationReturn == expectedReturn);
        }
    }
}
