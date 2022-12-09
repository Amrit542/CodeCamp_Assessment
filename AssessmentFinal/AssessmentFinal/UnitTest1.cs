using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AssessmentFinal
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        
        [TestInitialize] 
        public void Initialize() 
        {
            driver = new ChromeDriver();
            driver.Url = "";
            driver.
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestCleanup] 
        public void CleanUp() 
        {
            driver.Quit();

        }
    }
}