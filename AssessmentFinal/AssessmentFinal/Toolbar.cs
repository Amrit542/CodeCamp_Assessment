using OpenQA.Selenium;

namespace AssessmentFinal
{
    internal class Toolbar
    {
        private IWebDriver driver;

        public Toolbar(IWebDriver driver)
        {
            this.driver = driver;
        }

        internal void ClickBtn_Hub(string btnName)
        {
            foreach (var singleBtn in driver.FindElements(By.CssSelector("a>span")))
            {
                if (singleBtn.Text.ToLower() == btnName)
                {
                    singleBtn.Click();
                    return;
                }
            }

            throw new NotFoundException("Not Found!");
        }
    }
}