using Investec_Assessment.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Unit_Tests
{
    [TestClass]
    public class DuplicateCheckerTests
    {
        [TestMethod]
        public void EmptyOrNullInputReturnsNoDuplicates()
        {
            //Arrange
            string emptyInput = string.Empty;
            string nullInput = null;
            string expectedReturn = @"No duplicate values were found";

            //Act
            var operationReturnOnEmpty = emptyInput.CheckDuplicates();
            var operationReturnOnNull = nullInput.CheckDuplicates();

            //Assert
            Assert.IsTrue(operationReturnOnEmpty == expectedReturn && operationReturnOnNull == expectedReturn);
        }

        [TestMethod]
        public void ValidInputReturnsDuplicates()
        {
            //Arrange
            string input = @"I like eating apples";
            string expectedReturn = @"Found the following duplicates: ileap";

            //Act
            var operationReturnOnValid = input.CheckDuplicates();

            //Assert
            Assert.IsTrue(operationReturnOnValid == expectedReturn);
        }

        [TestMethod]
        public void ValidInputIsCaseInsensitive()
        {
            //Arrange
            string input = @"I LIKe eatiNG aPples";
            string expectedReturn = @"Found the following duplicates: ileap";

            //Act
            var operationReturnOnValid = input.CheckDuplicates();

            //Assert
            Assert.IsTrue(operationReturnOnValid == expectedReturn);
        }

        [TestMethod]
        public void InvalidInputReturnsNoDuplicates()
        {
            //Arrange
            string input = @"abcd4";
            string expectedReturn = @"No duplicate values were found";

            //Act
            var operationReturnOnValid = input.CheckDuplicates();

            //Assert
            Assert.IsTrue(operationReturnOnValid == expectedReturn);
        }
    }
}
