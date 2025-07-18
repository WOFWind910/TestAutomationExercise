using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Page.Locators
{
    internal class CartPage
    {
        public static By ProductDetails = By.XPath("//*[@id=\"product-18\"]/td[2]/h4/a");
        public static By ProceedToCheckout = By.XPath("//*[@id=\"do_action\"]/div[1]/div/div/a");
        public static By PlaceOrder = By.XPath("//*[@id=\"cart_items\"]/div/div[7]/a");
        public static By Comment = By.XPath("//*[@id=\"ordermsg\"]/textarea");
        public static By NameOnCard = By.Name("name_on_card");
        public static By CardNum = By.Name("card_number");
        public static By CVC = By.Name("cvc");
        public static By ExpiryMonth = By.Name("expiry_month");
        public static By ExpiryYear = By.Name("expiry_year");
        public static By PayAndConfirm = By.Id("submit");
        public static By NotifyPaySuccess = By.XPath("//*[@id=\"form\"]/div/div/div/p");
        public static By ContinueBtn = By.XPath("//*[@id=\"form\"]/div/div/div/div/a");
        public static By RemoveBtn = By.XPath("//*[@id=\"product-18\"]/td[6]/a");
    }
}
