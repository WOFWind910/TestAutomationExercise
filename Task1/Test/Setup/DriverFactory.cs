using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Setup;

namespace Task1.Setup
{
    internal class DriverFactory
    {
        public static IWebDriver CreateDriver(Browser b)
        {
            switch (b)
            {
                case Browser.Chrome: return new ChromeDriver();
                case Browser.Edge:
                                    var options = new EdgeOptions();
                                    options.AddArgument("headless");       // Nếu chạy Jenkins thì nên dùng
                                    options.AddArgument("disable-gpu");    // Bắt buộc với headless
                                    options.AddArgument("no-sandbox");     // Tránh lỗi sandbox trong CI/CD
                                    options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                                    var service = EdgeDriverService.CreateDefaultService();
                                    return new EdgeDriver(service, options); // ✅ RETURN
                default:
                    {
                        Console.WriteLine("Không có browser phù hợp!");
                        return null; 
                    }
                        
            }
        }
    }
}
