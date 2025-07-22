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
                                    options.AddArgument("headless"); // chạy không giao diện
                                    options.AddArgument("disable-gpu"); // bắt buộc khi headless trên Windows
                                    options.AddArgument("no-sandbox"); // tránh lỗi sandbox Jenkins
                                    options.AddArgument("disable-dev-shm-usage"); // cải thiện hiệu suất headless
                                    options.UseWebDriverManager = false; // Tắt Selenium Manager (nếu bạn dùng Selenium 4.11+)
                                    var service = EdgeDriverService.CreateDefaultService(@"C:\WebDriver");
                                    return new EdgeDriver(service, options);
                default:
                    {
                        Console.WriteLine("Không có browser phù hợp!");
                        return null; 
                    }
                        
            }
        }
    }
}
