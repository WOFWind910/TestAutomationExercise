using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Page.Locators
{
    internal class ProductPage
    {
        public static By searchField = By.Name("search");
        public static By searchBtn = By.XPath("//*[@id=\"submit_search\"]");
        public static By product = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[1]");
        public static By addToCartAtHomePage = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[1]/div[2]/div/a");
        public static By addSuccess = By.XPath("//*[@id=\"cartModal\"]/div/div/div[2]/p[1]");
        public static By continueBtn = By.XPath("//*[@id=\"cartModal\"]/div/div/div[3]/button");
        public static By SubmitPreviewBtn = By.XPath("//*[@id=\"button-review\"]");
        public static By Name = By.Id("name");
        public static By Email = By.Id("email");
        public static By Review = By.Id("review");
        public static By subcribe = By.Id("subscribe");
        public static By DetailsProduct = By.XPath("/html/body/section[2]/div/div/div[2]/div/div[2]/div/div[2]/ul/li/a");
        public static By AddProductAtDetails = By.XPath("/html/body/section/div/div/div[2]/div[2]/div[2]/div/span/button");
        public static By Quantity = By.Name("quantity");
    }
}
