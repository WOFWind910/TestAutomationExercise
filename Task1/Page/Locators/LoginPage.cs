using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Page.Locators
{
    internal class LoginPage
    {
        public static By loginBtn = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        public static By emailField = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/input[2]");
        public static By passwordField = By.Name("password");
        public static By confirmBtn = By.XPath("//*[@id=\"form\"]/div/div/div[1]/div/form/button");
    }
}
