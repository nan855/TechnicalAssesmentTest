using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentTest.Helpers;

namespace TechnicalAssesmentTest.Entities
{
    public class DriverSetup
    {
        public static IWebDriver GetDriver(Browsers browser)
        {
            switch (browser)
            {
                case Browsers.Chrome:
                    return GetChromeDriver();
                case Browsers.Firefox:
                    return GetFirefoxDriver();
                case Browsers.Edge:
                    return GetFirefoxDriver();
                case Browsers.IE:
                    return GetFirefoxDriver();
                default:
                    throw new ArgumentOutOfRangeException("Either the browser does not exist or driver is not addded for the given browser");

            }

        }
        public static IWebDriver GetChromeDriver()
        {
            var directoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            return new ChromeDriver(directoryPath);
        }
        public static IWebDriver GetFirefoxDriver()
        {
            throw new NotImplementedException();
        }
        public static IWebDriver GetEdgeDriver()
        {
            throw new NotImplementedException();
        }
        public static IWebDriver GetIEDriver()
        {
            throw new NotImplementedException();
        }
    }
}
