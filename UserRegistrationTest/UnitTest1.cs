using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.ComponentModel.DataAnnotations;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnTrue()
        {
            //Assert
            Validation user = new Validation();
            string name1 = "Shreya";
            //Act
            bool result = user.ValidateFirstName(name1);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Validation user = new Validation();
            string name2 = "Singh";
            //Act
            bool result = user.ValidateLastName(name2);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Validation user = new Validation();
            string name3 = "shreyasingh776@gamil.com";
            //Act
            bool result = user.ValidateEmail(name3);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Validation user = new Validation();
            string name4 = "91 7896543210";
            //Act
            bool result = user.ValidateMobileNumber(name4);
            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnTrue()
        {
            //Arrange
            Validation user = new Validation();
            string name5 = "Capgemini@123";
            //Act
            bool result = user.ValidatePassword(name5);
            //Assert
            Assert.IsTrue(result);
        }
        //Sad Test Cases(Test Cases Fail The Entry)
        [TestMethod]
        public void GivenUserFistName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Validation user = new Validation();
            string name1 = "shreya";
            //Act
            bool result = user.ValidateFirstName(name1);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenUserLastName_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Validation user = new Validation();
            string name2 = "singh";
            //Act
            bool result = user.ValidateFirstName(name2);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenEmailId_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Validation user = new Validation();
            string name3 = "shreyasingh@gmail.com";
            //Act
            bool result = user.ValidateEmail(name3);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenMobileNumber_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Validation user = new Validation();
            string name4 = "91 4569871233";
            //Act
            bool result = user.ValidateMobileNumber(name4);
            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void GivenPassword_WhenValidate_ShouldReturnFalse()
        {
            //Arrange
            Validation user = new Validation();
            string name5 = "abcde@123";
            //Act
            bool result = user.ValidatePassword(name5);
            //Assert
            Assert.IsFalse(result);
        }
    }
}
       