using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Task1.Helpers.WebDriverHelp;
using Task1.Model;
using Task1.TestData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Task1.Page.Locators.SignUpPage;
using Task1.Setup;
using static Task1.Helpers.TakeScreenShot;
using static Task1.Helpers.ExtentManager;
using NUnit.Framework.Interfaces;
using System.Windows.Forms;
namespace Task1.Page
{
    internal class SignUpPage : SetUpTest
    {
        public SignUpPage()
        {
        }

        public void GoToSignUp()
        {
            ClickBtn(signUpBtn);
        }

        public void fillName(String name)
        {
            FindElement(nameField).Clear();
            SendKeys(nameField, name);
        }

        public void fillEmail(String email)
        {
            FindElement(emailField).Clear();
            SendKeys(emailField, email);
        }

        public void SignUpSuccess(AccountInformation a,AddressInformation b)
        {
            node = test.CreateNode("Đăng ký thành công");
            fillEmail(a.email);
            fillName(a.name);
            ClickBtn(confirmBtn);
            EnterAccountIn4(a);
            Thread.Sleep(1000);
            AddressIn4(b);
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node,"Đăng ký thành công").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("dang_ky_thanh_cong"));
            ClickBtn(continueBtn);
        }

        public void SignUpFailed_WithEmail(AccountInformation a,String note,String nameImg)
        {
            node = test.CreateNode("Đăng ký bị lỗi Email");
            fillName(a.name);
            fillEmail(a.email);
            ClickBtn(confirmBtn);
            GetNotify(emailField, "email");
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node, note).AddScreenCaptureFromPath(ScreenShot_And_GetPathImage(nameImg));
        }

        public void SignUpFailed_WithName(AccountInformation a, String note, String nameImg)
        {
            node = test.CreateNode("Đăng ký bị lỗi tên");
            fillName(a.name);
            fillEmail(a.email);
            ClickBtn(confirmBtn);
            GetNotify(nameField, "name");
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node, note).AddScreenCaptureFromPath(ScreenShot_And_GetPathImage(nameImg));
        }

        public void EnterAccountIn4(AccountInformation a)
        {
            IList<IWebElement> radioTitle = FindElements(titleRadio);
            radioTitle.ElementAt(0).Click();

            SendKeys(passwordField, a.password);

            SelectWithValue(days, a.day.ToString());
            SelectWithValue(months, a.month.ToString());
            SelectWithValue(years, a.year.ToString());

            ClickBtn(newsLetter);
        }
        
        public void AddressIn4(AddressInformation a)
        {
            ScrollBotToElement(createBtn);
            Thread.Sleep(1000);

            SendKeys(firstName, a.firstName);
            SendKeys(last_name, a.lastName);
            SendKeys(company, a.company);
            SendKeys(address1, a.address);

            SelectWithText(country, a.country);

            SendKeys(state, a.state);
            SendKeys(city, a.city);
            SendKeys(zipcode, a.Zipcode);
            SendKeys(mobile_number, a.mobileNumber);

            ClickBtn(createBtn);
        }

        public void GetNotify(By by,String field)
        {
            try
            {
                String notify = driver.FindElement(by).GetAttribute("required");
                Assert.IsNull(notify,"Bắt buộc phải có "+field);

            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi ở trường: " + field + " - " + e.Message);
            }
        }
    }
}
