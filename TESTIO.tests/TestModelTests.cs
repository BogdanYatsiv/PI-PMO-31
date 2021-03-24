using System;
using Xunit;
using TESTIO.Models;

namespace TESTIO.tests
{
    public class TestModelTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            TestModel temp = new TestModel();
            string name = "test1";
            string description = "testDescription";
            bool test_is_lock = false;
            DateTime data = DateTime.Now;

            //Act
            temp.Name = name;
            temp.Description = description;
            temp.Lock = test_is_lock;
            temp.CreatedDate = data;

            //Assert
            Assert.Equal(name, temp.Name);
            Assert.Equal(description, temp.Description);
            Assert.Equal(test_is_lock, temp.Lock);
            Assert.Equal(data, temp.CreatedDate);
        }
    }
}
