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
    internal class SignUp_LoginPageTest : SetUpTest
    {
        private static LoginPage loginPage = new LoginPage();
        private static SignUpPage signUp = new SignUpPage();

        public static void Login()
        {
            loginPage.GoToLogin();
            loginPage.Login(AccountData.getAccountValid());
        }

        public static void SignUp()
        {
            signUp.GoToSignUp();
            signUp.SignUpFailed_WithEmail(AccountData.getAccount_ExistEmail(),"Đăng ký không thành công - Email đã tồn tại","Email_da_ton_tai");

            signUp.SignUpFailed_WithEmail(AccountData.getAccount_WithoutEmail(), "Đăng ký không thành công - Thiếu email", "Thieu_Email");

            signUp.SignUpFailed_WithEmail(AccountData.getAccount_InvalidEmail(), "Đăng ký không thành công - Email không hợp lệ", "Email_khong_hop_le");

            signUp.SignUpFailed_WithName(AccountData.getAccount_WithoutName(), "Đăng ký không thành công - Chưa có tên", "Thieu_ten");

            signUp.SignUpSuccess(AccountData.getAccountValid(), AddressData.getAddress_Valid());
        }

        public static void SignUp_Login_Test()
        {
            SignUp();
            LogOut();
            Login();
        }



    }
}
