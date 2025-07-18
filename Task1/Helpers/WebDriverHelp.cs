using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task1.Setup;

namespace Task1.Helpers
{
    internal class WebDriverHelp
    {
        private static IWebDriver driver;
        public static void getDriver()
        {
            driver= SetUpTest.getDriver();
        }
        public static void ScrollBotToElement(By by)
        {
            getDriver();
            IWebElement createBtn = driver.FindElement(by);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({block:'end', behavior:'smooth'});", createBtn);
        }
        public static void ScrollTopToElement(By by)
        {
            getDriver();
            IWebElement createBtn = driver.FindElement(by);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView({block:'start', behavior:'smooth'});", createBtn);
        }
        public static IWebElement FindElement( By by)
        {
            getDriver();
            return driver.FindElement(by);
        }

        public static IList<IWebElement> FindElements(By by)
        {
            getDriver();
            return driver.FindElements(by);
        }

        public static void HoverElement(By by)
        {
            getDriver();
            Actions action = new Actions(driver);
            action.MoveToElement(FindElement(by)).Perform();
        }

        public static void ClickBtn(By by)
        {
            getDriver();
            FindElement(by).Click();
        }

        public static void SendKeys(By by,String content)
        {
            getDriver();
            FindElement(by).SendKeys(content);
        }

        public static void SelectWithValue(By by,String content)
        {
            getDriver();
            SelectElement select = new SelectElement(FindElement(by));
            select.SelectByValue(content);
        }

        public static void SelectWithText(By by,String content)
        {
            getDriver();
            SelectElement select = new SelectElement(FindElement(by));
            select.SelectByText(content);
        }
    }
}
