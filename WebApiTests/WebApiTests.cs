using System;
using WebApi.Controllers;
using WebApi.Models;
using Xunit;

namespace WebApiTests
{
    public class WebApiTests
    {
        [Fact]
        public void TestForHello()
        {
            HelloController helloController = new HelloController();
            Assert.Equal("Hello", helloController.Hi("hi"));
        }
        [Fact]
        public void TestForIdontKnow()
        {
            HelloController helloController = new HelloController();
            Assert.Equal("I don't know who you are", helloController.Hi("hey"));
        }
        [Fact]
        public void TestForPost()
        {
            Year year = new Year();
            year.year = 2019;
            ValuesController valuesController = new ValuesController();
            Assert.Equal(year,valuesController.Post(year));
        }
    }
}
