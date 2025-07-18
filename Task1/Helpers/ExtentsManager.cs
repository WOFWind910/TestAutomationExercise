using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.IO;

namespace Task1.Helpers
{
    public class ExtentManager
    {
        private static ExtentReports extent;
        private static ExtentHtmlReporter htmlReporter;

        public static ExtentReports GetInstance()
        {
            if (extent == null)
            {
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string projectPath = Path.GetFullPath(Path.Combine(baseDir, @"..\..\.."));
                string reportsFolder = Path.Combine(projectPath, "Reports");
                Directory.CreateDirectory(reportsFolder);
                string reportPath = Path.Combine(reportsFolder, "Task1.html");
                Console.WriteLine($"📄 Report path: {reportPath}");
                htmlReporter = new ExtentHtmlReporter(reportPath);
                htmlReporter.Configuration().DocumentTitle = "Automation Test Report";
                htmlReporter.Configuration().ReportName = "Test Results";
                htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Standard;
                extent = new ExtentReports();
                extent.AttachReporter(htmlReporter);
            }
            return extent;
        }


        public static ExtentTest AutoNoteTestCase(NUnit.Framework.Interfaces.TestStatus status, ExtentTest node, string message)
        {
            switch (status)
            {
                case NUnit.Framework.Interfaces.TestStatus.Passed:
                    return node.Pass(message);
                case NUnit.Framework.Interfaces.TestStatus.Failed:
                    return node.Fail(message);
                default:
                    return node.Warning(message);
            }
        }

    }
}
