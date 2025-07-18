using AventStack.ExtentReports;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Helpers;
using static Task1.Helpers.RecordVideo;
using TestStatus = NUnit.Framework.Interfaces.TestStatus;

namespace Task1.Setup
{
    public class SetUpTest
    {
        protected static TestStatus status = TestContext.CurrentContext.Result.Outcome.Status;
        protected static IWebDriver driver;
        protected static WebDriverWait wait;
        protected static ExtentReports extent;
        protected static ExtentTest test;
        protected static ExtentTest node;
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            extent = ExtentManager.GetInstance();
            driver = DriverFactory.CreateDriver(Browser.Edge);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        [SetUp]
        public void SetUp()
        {
            string testName = TestContext.CurrentContext.Test.Name;
            test = extent.CreateTest(testName);
        }
        public void GoToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            StartRecording("RecordTest1");
        }

        public static IWebDriver getDriver()
        {
            return driver;
        }

        [TearDown]
        public void TearDown()
        {
            extent.Flush();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            StopRecording();
        }
    }
}
