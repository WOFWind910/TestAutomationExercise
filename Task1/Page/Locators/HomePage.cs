using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Page.Locators
{
    internal class HomePage
    {
        public static By logout = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[4]/a");
        public static By deleteAccBtn = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[5]/a");
        public static By accept = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        public static By productsPage = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[2]/a");
        public static By ToCart = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[3]/a");
        public static By Women = By.XPath("//*[@id=\"accordian\"]/div[1]/div[1]/h4/a");
        public static By Dress = By.XPath("//*[@id=\"Women\"]/div/ul/li[1]/a");
        public static By ContactUs = By.XPath("//*[@id=\"header\"]/div/div/div/div[2]/div/ul/li[9]/a");
    }
}
