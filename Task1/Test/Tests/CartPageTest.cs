using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Page;
using Task1.Setup;
using Task1.TestData;
using static Task1.Test.Tests.HomePageTest;
namespace Task1.Test.Tests
{
    internal class CartPageTest : SetUpTest
    {
        private static CartPage cartPage = new CartPage();
        
        public static void Go_To_Product_Details_At_Cart()
        {
            cartPage.GoToProductDetails();
        }

        public static void Remove_Product()
        {
            cartPage.RemoveProduct();
        }
        public static void Proceed_Checkout()
        {
            cartPage.ProceedCheckOut();
        }

        public static void Order()
        {
            cartPage.Order("Thanks");
        }
        public static void Payment()
        {
            cartPage.Payment(CardData.getData());
            cartPage.CheckPaySuccess();
        }

        public static void CheckOut()
        {
            Go_To_Cart();
            Remove_Product();
            Proceed_Checkout();
            Order();
            Payment();
        }
    }
}
