using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Model;

namespace Task1.TestData
{
    internal class AddressData
    {

        public static AddressInformation getAddress_Valid()
        {
            AddressInformation a= new AddressInformation();
            a.firstName = "Pham";
            a.lastName = "Kien";
            a.company = "FPT";
            a.address = "123HAHAHA";
            a.country = "Canada";
            a.state = "ha";
            a.city = "KhanhHoa";
            a.Zipcode = "12345";
            a.mobileNumber = "12345";
            return a;
        }

        public static AddressInformation getAddress_WithoutAddress()
        {
            AddressInformation a = new AddressInformation();
            a.firstName = "Pham";
            a.lastName = "Kien";
            a.company = "FPT";
            a.address = "";
            a.country = "Canada";
            a.state = "ha";
            a.city = "KhanhHoa";
            a.Zipcode = "12345";
            a.mobileNumber = "12345";
            return a;
        }
    }
}
