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
                                    options.AddArgument("headless"); // nếu chạy Jenkins thì nên headless
                                    options.AddArgument("disable-gpu"); // cần thiết cho chế độ headless
                                    options.AddArgument("no-sandbox"); // tránh lỗi bảo mật trong CI
                                    options.BinaryLocation = @"C:\Program Files\Microsoft\Edge\Application\msedge.exe";
                                
                                    var service = EdgeDriverService.CreateDefaultService();
                                    // ❌ KHÔNG dùng: service.UseShellExecute
                                    
                                    driver = new EdgeDriver(service, options);
                                    break;
                default:
                    {
                        Console.WriteLine("Không có browser phù hợp!");
                        return null; 
                    }
                        
            }
        }
    }
}
