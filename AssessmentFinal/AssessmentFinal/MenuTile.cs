using OpenQA.Selenium;

namespace AssessmentFinal
{
    internal class MenuTile
    {
        private IWebElement singleMenuItem;

        public MenuTile(IWebElement singleMenuItem)
        {
            this.singleMenuItem = singleMenuItem;
        }

       
    }
}