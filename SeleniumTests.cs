using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWTesting.Tests.Selenium
{
    class SeleniumTests
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
            [Author("Kevin")]
            public void Selenium_HelloUser()
            {
                //Opens CWMT, enters user + pass.
                driver.Navigate().GoToUrl("http://localhost:52334/Account/Login?ReturnUrl=%2F");
                IWebElement uName = driver.FindElement(By.Id("UserName"));
                uName.SendKeys("olive");
                IWebElement pWord = driver.FindElement(By.Id("Password"));
                pWord.SendKeys("TestPass1" + Keys.Enter);
                System.Threading.Thread.Sleep(15000);

                //Clicks on "Hello Olive!"
                driver.FindElement(By.XPath("//*[@title='Manage']")).Click();
                System.Threading.Thread.Sleep(15000);
            }

            [Test]
            [Author("Kevin")]
            public void Selenium_LogOffButton()
            {

                //Opens CWMT, enters user + pass.
                driver.Navigate().GoToUrl("http://localhost:52334/Account/Login?ReturnUrl=%2F");
                IWebElement uName = driver.FindElement(By.Id("UserName"));
                uName.SendKeys("olive");
                IWebElement pWord = driver.FindElement(By.Id("Password"));
                pWord.SendKeys("TestPass1" + Keys.Enter);
                System.Threading.Thread.Sleep(15000);

                //Clicks on Log Off button.
                ((IJavaScriptExecutor)driver).ExecuteScript("document.getElementById('logoutForm').submit()");
                System.Threading.Thread.Sleep(15000);

            }

            [TearDown]
            public void CleanUp()
            {
                driver.Close();
            }
        }
    }
}
