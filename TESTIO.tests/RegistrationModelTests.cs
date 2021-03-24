using System;
using Xunit;
using TESTIO.Models;
namespace TESTIO.tests
{
    public class RegistrationModelTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            RegistrationModel temp = new RegistrationModel();
            string name = "testName";
            string surname = "testSurname";
            string email = "test@gmail.com";
            string password = "testPassword";

            //Act
            temp.Name = name;
            temp.Surname = surname;
            temp.Email = email;
            temp.Password = password;

            //Assert
            Assert.Equal(name, temp.Name);
            Assert.Equal(surname, temp.Surname);
            Assert.Equal(email, temp.Email);
            Assert.Equal(password, temp.Password);
        }
    }
}
