using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.Page;
using Task1.Setup;
using Task1.TestData;
using static Task1.Test.Tests.HomePageTest;

namespace Task1.Test.Tests
{
    internal class ProductPageTest : SetUpTest
    {
        private static ProductPage productPage = new ProductPage();

        public static void Find_Add_Product_At_Product_Page(String nameProduct)
        {
            Go_To_Product_Page();
            productPage.Find_Product(nameProduct);
            productPage.Add_To_Cart_At_Product_Page();
        }

        public static void Find_Add_Product_At_Product_Details(String nameProduct)
        {
            Go_To_Product_Page();
            productPage.Find_Product(nameProduct);
            productPage.Go_To_Product_Details();
            productPage.Add_To_Cart_At_Product_Details();
            productPage.Write_Review(AccountData.getAccountValid());
        }

        public static void Find_Add_Product_At_Product_Details_With_Quantity(String nameProduct)
        {
            Go_To_Product_Page();
            productPage.Find_Product(nameProduct);
            productPage.Go_To_Product_Details();
            productPage.Increase_Quantity();
            Thread.Sleep(1000);
            productPage.Increase_Quantity();
            Thread.Sleep(1000);
            productPage.Add_To_Cart_At_Product_Details();
            productPage.Write_Review(AccountData.getAccountValid());
        }


    }
}
