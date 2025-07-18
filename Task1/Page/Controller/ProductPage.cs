using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.Model;
using Task1.Setup;
using Task1.TestData;
using static Task1.Helpers.WebDriverHelp;
using static Task1.Page.Locators.ProductPage;
using static Task1.Helpers.ExtentManager;
using static Task1.Helpers.TakeScreenShot;
namespace Task1.Page
{
    internal class ProductPage : SetUpTest
    {
        public ProductPage()
        {
        }


        public void Find_Product(String nameProduct)
        {
            node=test.CreateNode("Tìm kiếm sản phấm");
            IWebElement search = FindElement(searchField);
            search.Click();
            search.Clear();
            search.SendKeys(nameProduct);
            ClickBtn(searchBtn);
            AutoNoteTestCase(status, node, "Kết quả tìm kiếm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_tim_kiem"));
            node.Pass("Tìm kiếm thành công");
        }
       
        public void Add_To_Cart_At_Product_Page()
        {
            node = test.CreateNode("Thêm sản phẩm vào giỏ hàng từ trang sản phẩm");
            ScrollTopToElement(product);
            Thread.Sleep(1000);
            HoverElement(product);
            Thread.Sleep(1000);
            ClickBtn(addToCartAtHomePage);
            try
            {
                String notifyAddToCart = wait.Until(ExpectedConditions.ElementIsVisible(addSuccess)).Text;
                Assert.AreEqual("Your product has been added to cart.", notifyAddToCart, "Add không thành công");
                AutoNoteTestCase(status, node, "Kết quả thêm sản phẩm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage(notifyAddToCart));
                ClickBtn(continueBtn);
            }
            catch (Exception ex)
            {
                Assert.Fail("Không lấy được thông báo: " + ex.Message);
                AutoNoteTestCase(status, node, "Lỗi khi thêm sản phẩm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("loi_them_san_pham"));
            }
        }

        public void Go_To_Product_Details()
        {
            ScrollTopToElement(product);
            Thread.Sleep(1000);
            ClickBtn(DetailsProduct);
        }

        public void Increase_Quantity()
        {
            SendKeys(Quantity, Keys.Up);
            Thread.Sleep(1000);
        }

        public void Decrease_Quantity()
        {
            SendKeys(Quantity, Keys.Down);
            Thread.Sleep(1000);
        }
        public void Add_To_Cart_At_Product_Details()
        {
            node = test.CreateNode("Thêm sản phẩm vào giỏ hàng từ trang chi tiết");
            ClickBtn(AddProductAtDetails);
            try
            {
                String notifyAddToCart = wait.Until(ExpectedConditions.ElementIsVisible(addSuccess)).Text;
                Assert.AreEqual("Your product has been added to cart.", notifyAddToCart, "Add không thành công");
                AutoNoteTestCase(status, node, "Kết quả thêm sản phẩm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("notifyAddToCart"));
                ClickBtn(continueBtn);
            }
            catch (Exception ex)
            {
                Assert.Fail("Không lấy được thông báo: " + ex.Message);
                AutoNoteTestCase(status, node, "Lỗi khi thêm sản phẩm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("loi_them_san_pham"));
            }
        }
        
        public void Write_Review(AccountInformation a)
        {
            node = test.CreateNode("Ghi đánh giá sản phẩm");
            ScrollBotToElement(SubmitPreviewBtn);
            SendKeys(Name, a.name);
            SendKeys(Email, a.email);
            FindElement(Review).SendKeys("Good!!!");
            ClickBtn(SubmitPreviewBtn);
            AutoNoteTestCase(status, node, "Kết quả đánh giá sản phẩm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("preview_san_pham"));
        }
    }
}
