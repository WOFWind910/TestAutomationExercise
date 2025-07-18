using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.Setup;
using static Task1.Helpers.WebDriverHelp;
using static Task1.Helpers.TakeScreenShot;
using static Task1.Helpers.ExtentManager;
using static Task1.Page.Locators.HomePage;

namespace Task1.Page
{
    internal class HomePage : SetUpTest
    {
        public HomePage()
        {
        }

        public void LogOut()
        {
            ClickBtn(logout);
        }
        
        public void Delete_Account()
        {
            node = test.CreateNode("Xóa tài khoản");
            ClickBtn(deleteAccBtn);
            ClickBtn(accept);
            AutoNoteTestCase(status, node, "Kết quả xóa tài khoản").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_xoa_tai_khoan"));
        }
        public void Go_To_Products()
        {
            ClickBtn(productsPage);
        }
        public void Go_Cart()
        {
            ClickBtn(ToCart);
        }

        public void Filter_Category()
        {
            node = test.CreateNode("Tìm theo loại sản phẩm");
            ClickBtn(Women);
            Thread.Sleep(1000);
            ClickBtn(Dress);
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node, "Kết quả tìm kiếm").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_tim_kiem"));
        }

    }
}
