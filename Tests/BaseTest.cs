using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentTest.Entities;
using TechnicalAssesmentTest.Helpers;

namespace TechnicalAssesmentTest.Tests
{
    public class BaseTest
    {
        public IWebDriver Driver { get; private set; }
        [TestInitialize]
        public void Setup()
        {
            Driver = DriverSetup.GetDriver(Browsers.Chrome);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Constants.DEFAULT_IMPWAIT_TIMEOUT);
            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Close();
            Driver.Quit();
        }
    }
}
