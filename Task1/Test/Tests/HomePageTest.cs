using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Page;
using Task1.Setup;

namespace Task1.Test.Tests
{
    internal class HomePageTest : SetUpTest
    {
        private static HomePage homePage = new HomePage();

        public static void Go_To_Product_Page()
        {
            homePage.Go_To_Products();
        }
        public static void LogOut()
        {
            homePage.LogOut();
        }
        public static void Delete_Account()
        {
            homePage.Delete_Account();
        }

        public static void Go_To_Cart()
        {
            homePage.Go_Cart();
        }

        public static void Find_Women_Dress()
        {
            homePage.Filter_Category();
        }


    }
}
