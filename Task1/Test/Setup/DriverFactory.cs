using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Setup;
using System.IO;

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
                                    options.AddArgument("headless");
                                    options.AddArgument("disable-gpu");
                                    options.AddArgument("no-sandbox");
                                    options.BinaryLocation = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
                                    var driverPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Drivers"); // ví dụ để sẵn driver ở đây
                                    var service = EdgeDriverService.CreateDefaultService(driverPath);
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
