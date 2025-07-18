using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1.Model;
using Task1.Setup;
using static Task1.Helpers.WebDriverHelp;
using static Task1.Helpers.TakeScreenShot;
using static Task1.Helpers.ExtentManager;
using static Task1.Page.Locators.CartPage;
namespace Task1.Page
{
    internal class CartPage : SetUpTest
    {
        public CartPage()
        {   }

        public void GoToProductDetails()
        {
            FindElement(ProductDetails).Click();
        }

        public void ProceedCheckOut()
        {
            node = test.CreateNode("Proceed CheckOut");
            ClickBtn(ProceedToCheckout);
            AutoNoteTestCase(status, node, "Kết quả click Proceed CheckOut").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_click_proceed_checkout"));
        }
        public void Order(String comment)
        {
            node = test.CreateNode("Order");
            ScrollBotToElement(PlaceOrder);
            SendKeys(Comment, comment);
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node, "Hoàn tất Order").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("hoan_tat_order"));
            ClickBtn(PlaceOrder);
        }

        public void Payment(Card card)
        {
            FillPayment(card);
        }

        public void FillPayment(Card card)
        {
            node = test.CreateNode("Payment");
            SendKeys(NameOnCard, card.NameCard);
            SendKeys(CardNum, card.CardNum);
            SendKeys(CVC, card.CVC);
            SendKeys(ExpiryMonth, card.ExpirationMonth);
            SendKeys(ExpiryYear, card.ExpirationYear);
            Thread.Sleep(1000);
            AutoNoteTestCase(status, node, "Hoàn tất điền thông tin").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("hoan_tat_dien_thong_tin"));
            ClickBtn(PayAndConfirm);
        }

        public void CheckPaySuccess()
        {
            node = test.CreateNode("Kết quả thanh toán");
            try
            {
                String notify = wait.Until(ExpectedConditions.ElementIsVisible(NotifyPaySuccess)).Text;
                Assert.AreEqual("Congratulations! Your order has been confirmed!", notify);
                AutoNoteTestCase(status, node, "Kết quả thanh toán").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_thanh_toan"));
            }
            catch (Exception ex)
            {
                Assert.Fail("Không lấy được thông báo thanh toán thành công!");
                AutoNoteTestCase(status, node, "Kết quả thanh toán").AddScreenCaptureFromPath(ScreenShot_And_GetPathImage("ket_qua_thanh_toan"));
            }
            Thread.Sleep(2000);
            ClickBtn(ContinueBtn);
        }

        public void RemoveProduct()
        {
            ClickBtn(RemoveBtn);
            Thread.Sleep(1000);
        }
    }
}
