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
        [TestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenEmailIds_WhenValidate_ShouldReturnTrue(string name6)
        {
            //Arrange
            Validation user = new Validation();
            //Act
            bool result = user.ValidateEmailSample(name6);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
       