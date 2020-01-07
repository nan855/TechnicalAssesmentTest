using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssesmentTest.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement ShopMenu => Driver.FindElement(By.Id("nav-shop"));

        private IWebElement ContactMenu => Driver.FindElement(By.Id("nav-contact"));

        public ContactPage ConatctPageNavigation()
        {
            ContactMenu.Click();
            return new ContactPage(Driver);

        }

    }
}
