using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace AutomatedTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:44108/");
        }
    }
}
