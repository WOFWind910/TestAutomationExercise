using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using Task1.Setup;
namespace Task1.Helpers
{
    internal class TakeScreenShot
    {
        private static string CaptureScreenshot(string screenshotName)
        {
            IWebDriver driver = SetUpTest.getDriver();
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
            string folderPath = Path.Combine(projectPath, "Reports", "ScreenShot");
            Directory.CreateDirectory(folderPath);
            string fileName = screenshotName + ".png";
            string filePath = Path.Combine(folderPath, fileName);
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            ss.SaveAsFile(filePath);
            return Path.Combine("ScreenShot", fileName).Replace("\\", "/");
        }

        public static string ScreenShot_And_GetPathImage(String screenshotName)
        {
            return CaptureScreenshot(screenshotName);
        }

    }
}
