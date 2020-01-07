using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalAssesmentTest.Helpers;
using TechnicalAssesmentTest.Pages;

namespace TechnicalAssesmentTest.Tests
{
    [TestClass]
    public class ContactTests  : BaseTest
    {

        [TestMethod, TestCategory(TestCategory.Contact)]
        public void VerifyErrorMessages()
        {
            try
            {

                var foreName = "Nancy";
                var email = "nancy@ab.com";
                var message = "Testing";
                var homePage = new HomePage(Driver);
                homePage.HomePageNavigation();

                ContactPage contactPage = homePage.ConatctPageNavigation();
                contactPage.SubmitButtonClick();


                //Asserts on empty mandatory fields
                Assert.AreEqual("Forename is required", contactPage.FetchForeNameErrorMsg(), $" Error message on forename is different and equal to : {contactPage.FetchForeNameErrorMsg()}");
                Assert.AreEqual("Email is required", contactPage.EmailErrorMsg(), $"Error message on Email field Bis different and equals to : {contactPage.EmailErrorMsg()}");
                Assert.AreEqual("Message is required", contactPage.MessageErrorMsg(), $"Error message on message field is different and equals to: {contactPage.MessageErrorMsg()}");
               
                // Populate Mandatory Fields
                contactPage.InputMandatoryConatctDetails(foreName, email, message);


                //Asserts to validate if error message are not visible
                Assert.IsTrue(contactPage.ForeNameErrorVisible().Equals(0), "ForeName error message is visible");
                Assert.IsTrue(contactPage.EmailErrorVisible().Equals(0), "Email error message is visible");
                Assert.IsTrue(contactPage.MessageErrorVisible().Equals(0), "Message error message is visible");


            }

            catch (Exception ex)
            {
                Assert.Fail(ex.ToString());
            }
        }
    }
}
