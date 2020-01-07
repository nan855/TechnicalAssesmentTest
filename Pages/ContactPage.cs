using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalAssesmentTest.Pages
{
   public class ContactPage : BasePage
    {
        public ContactPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement submitButton => Driver.FindElement(By.CssSelector(".btn-contact"));

        private IWebElement foreName => Driver.FindElement(By.CssSelector("#forename"));
        private IWebElement email => Driver.FindElement(By.CssSelector("#email"));
        private IWebElement message => Driver.FindElement(By.CssSelector("#message"));
        private IEnumerable<IWebElement> foreNameError => Driver.FindElements(By.CssSelector("#forename-err"));
        private IEnumerable<IWebElement> emailError => Driver.FindElements(By.CssSelector("#email-err"));
        private IEnumerable<IWebElement> messageError => Driver.FindElements(By.CssSelector("#message-err"));

        public void SubmitButtonClick()
        {
            JavaScriptClick(submitButton);
           // submitButton.Click();
        }

        public void JavaScriptClick(IWebElement element)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)Driver;
            executor.ExecuteScript("arguments[0].click();", element);
        }

        public string  FetchForeNameErrorMsg()
        {
           var text =  foreNameError.ElementAt(0).Text;
            return text;
        }
        public string EmailErrorMsg()
        {
            var text = emailError.ElementAt(0).Text;
            return text;
        }
        public string MessageErrorMsg()
        {
            var text = messageError.ElementAt(0).Text;
            return text;
        }

        public void InputMandatoryConatctDetails(string forenameText, string emailText, string messageText)
        {
            foreName.SendKeys(forenameText);
            email.SendKeys(emailText);
            message.SendKeys(messageText);

        }

        public int ForeNameErrorVisible()
        {
            return foreNameError.Count();
        }
        public int EmailErrorVisible()
        {
            return emailError.Count();
        }
        public int MessageErrorVisible()
        {
            return messageError.Count();
        }
    }
}
