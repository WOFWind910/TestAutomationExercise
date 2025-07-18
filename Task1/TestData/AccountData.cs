using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.TestData
{
    internal class AccountData
    {
       
        public static AccountInformation getAccountValid()
        {
            AccountInformation a = new AccountInformation();
            a.title = 0;
            a.name = "WOFWind";
            a.email = "ptk50@email.com";
            a.password = "123456";
            a.day = 9;
            a.month = 10;
            a.year = 2004;
            return a;
        }

        public static AccountInformation getAccount_InvalidEmail()
        {
            AccountInformation a = new AccountInformation();
            a.name = "WOFWind";
            a.email = "ptk50@";
            return a;
        }

        public static AccountInformation getAccount_ExistEmail()
        {
            AccountInformation a = new AccountInformation();
            a.name = "WOFWind";
            a.email = "ptk1@email.com";
            return a;
        }

        public static AccountInformation getAccount_WithoutEmail()
        {
            AccountInformation a = new AccountInformation();
            a.name = "WOFWind";
            a.email = "";
            return a;
        }
        public static AccountInformation getAccount_WithoutName()
        {
            AccountInformation a = new AccountInformation();
            a.name = "";
            a.email = "ptk1@email";
            return a;
        }
    }
}
