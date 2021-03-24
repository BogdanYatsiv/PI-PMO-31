using System;
using Xunit;
using TESTIO.Models;
namespace TESTIO.tests
{
    public class LoginModelTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            LoginModel temp = new LoginModel();
            string email = "test@gmail.com";
            string password = "testPassword";

            //Act
            temp.Email = email;
            temp.Password = password;

            //Assert
            Assert.Equal(email, temp.Email);
            Assert.Equal(password, temp.Password);
        }
    }
}
