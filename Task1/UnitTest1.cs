using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using Task1.Page;
using Task1.Setup;
using Task1.TestData;
using static Task1.Test.Tests.SignUp_LoginPageTest;
using static Task1.Test.Tests.HomePageTest;
using static Task1.Test.Tests.CartPageTest;
using static Task1.Test.Tests.ProductPageTest;
namespace Task1
{
    [TestFixture]
    public class UnitTest1 : SetUpTest
    {
        [Test, Order(1)]
        public void Test_OpenWeb()
        {
            GoToURL("https://automationexercise.com/");
        }

        [Test, Order(2)]
        public void Test_SignUp_Login()
        {
            SignUp_Login_Test();
        }

        [Test, Order(3)]
        public void Test_Category()
        {
            Find_Women_Dress();
        }

        [Test, Order(4)]
        public void Test_Add_Product_From_ProductPage()
        {
            Find_Add_Product_At_Product_Page("Little");
        }

        [Test, Order(5)]
        public void Test_Add_Product_From_DetailPage()
        {
            Find_Add_Product_At_Product_Details("Premium Polo");
        }

        [Test, Order(6)]
        public void Test_Add_Product_From_Detail_With_Quantity()
        {
            Find_Add_Product_At_Product_Details_With_Quantity("Sleeves Top and short");
        }

        [Test, Order(7)]
        public void Test_Checkout()
        {
            CheckOut();
        }

        [Test, Order(8)]
        public void Test_Delete_Account()
        {
            Delete_Account();
        }
    }
}

