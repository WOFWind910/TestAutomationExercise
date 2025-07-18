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
using static Task1.Page.Locators.LoginPage;
using static Task1.Helpers.WebDriverHelp;
using static Task1.Helpers.TakeScreenShot;
using static Task1.Helpers.ExtentManager;
namespace Task1.Page
{
    internal class LoginPage: SetUpTest
    {
        public LoginPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
        }

        public void GoToLogin()
        {
           ClickBtn(loginBtn);
        }

        
        public void Login(AccountInformation a)
        {
            node = test.CreateNode("Đăng nhập thành công");
            driver.FindElement(emailField).SendKeys(a.email);
            driver.FindElement(passwordField).SendKeys(a.password);
            Thread.Sleep(1000);
            ClickBtn(confirmBtn);
            AutoNoteTestCase(status, node, "Kết quả đăng nhập").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_dang_nhap"));
        }
    }
}
