using OpenQA.Selenium;

namespace AssessmentFinal
{
    internal class SidesBtn
    {
        private IWebDriver driver;

        public SidesBtn(IWebDriver driver)
        {
            this.driver = driver;
        }

        /*
        public IWebElement GetProductDetails(string item)
        {
            foreach (var singleMenuItem in driver.FindElements(By.ClassName("v-card")))
            {
                MenuTile menuTile = new MenuTile(singleMenuItem);
            }
        }
        */

    }
}