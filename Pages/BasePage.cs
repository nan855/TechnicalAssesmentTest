using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssesmentTest.Pages
{
    public class BasePage
    {
        public IWebDriver Driver;
        public BasePage(IWebDriver dr)
        {
            Driver = dr;
        }
        public void HomePageNavigation()
        {
            Driver.Navigate().GoToUrl("https://jupiter.cloud.planittesting.com");


        }
    }
}
