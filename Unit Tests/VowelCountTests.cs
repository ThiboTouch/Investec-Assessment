using Investec_Assessment.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class VowelCountTests
    {
        [TestMethod]
        public void EmptyOrNullInputReturnsNoVowels()
        {
            //Arrange
            string emptyInput = string.Empty;
            string nullInput = null;
            string expectedReturn = @"No vowels were found";

            //Act
            var operationReturnOnEmpty = emptyInput.CountUniqueVowels();
            var operationReturnOnNull = nullInput.CountUniqueVowels();

            //Assert
            Assert.IsTrue(operationReturnOnEmpty == expectedReturn && operationReturnOnNull == expectedReturn);
        }

        [TestMethod]
        public void ValidInputReturnsUniqueVowelCount()
        {
            //Arrange
            string input = @"I like eating apples";
            string expectedReturn = @"The number of vowels is 3";

            //Act
            var operationReturn = input.CountUniqueVowels();

            //Assert
            Assert.IsTrue(operationReturn == expectedReturn);
        }

        [TestMethod]
        public void InvalidInputReturnsNoVowels()
        {
            //Arrange
            string input = @"jkl kkjh";
            string expectedReturn = @"No vowels were found";

            //Act
            var operationReturn = input.CountUniqueVowels();

            //Assert
            Assert.IsTrue(operationReturn == expectedReturn);
        }
    }
}
