using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTesting.Tests.Selenium
{
    [TestFixture]
    class Kevin_ExampleTest
    {
        IWebDriver driver;
        
        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
        }

        [Test]
        public void ExecuteBingTest()
        {
            driver.Navigate().GoToUrl("http://www.bing.com");
            String text = driver.Title;
            Console.WriteLine(text);
            System.Threading.Thread.Sleep(4000);
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }

}
