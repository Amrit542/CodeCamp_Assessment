using OpenQA.Selenium;
using System.Security.Cryptography.X509Certificates;

namespace AssessmentFinal
{
    internal class Form
    {
        private IWebDriver driver;

        public Form(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickSubmit()
        {
            driver.FindElement(By.CssSelector("[aria-label=submit]")).Click();
        }

        internal void SetEmail(string email)
        {
            driver.FindElement(By.Id("email")).SendKeys(email);
        }

        internal void SetMessage(string message)
        {
            driver.FindElement(By.Id("message")).SendKeys(message);
        }

        internal void SetName(string forename)
        {
             driver.FindElement(By.Id("forename")).SendKeys(forename);
        }
    }
}