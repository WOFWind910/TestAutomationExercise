using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Page.Locators
{
    internal class SignUpPage
    {
        public static By signUpBtn = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        public static By nameField = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[2]");
        public static By emailField = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/input[3]");
        public static By confirmBtn = By.XPath("//*[@id=\"form\"]/div/div/div[3]/div/form/button");
        public static By continueBtn = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        public static By titleRadio = By.ClassName("radio-inline");
        public static By passwordField = By.Name("password");
        public static By days = By.Name("days");
        public static By months = By.Name("months");
        public static By years = By.Name("years");
        public static By newsLetter = By.Id("newsletter");
        public static By createBtn = By.XPath("//*[@id=\"form\"]/div/div/div/div[1]/form/button");
        public static By firstName = By.Name("first_name");
        public static By last_name = By.Name("last_name");
        public static By company = By.Name("company");
        public static By address1 = By.Name("address1");
        public static By country = By.Name("country");
        public static By state = By.Name("state");
        public static By city = By.Name("city");
        public static By zipcode = By.Name("zipcode");
        public static By mobile_number = By.Name("mobile_number");
    }
}
