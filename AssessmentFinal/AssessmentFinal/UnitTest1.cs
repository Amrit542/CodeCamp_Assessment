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
            driver.Url = "https://d3nay7txmslpgb.cloudfront.net/#/";
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(7);
        }
        [TestMethod]
        public void ErrorMessages_check()
        {
            const string forename = "Dan";
            const string email = "dan@abc.com";
            const string message = "Nice Pizza";

            //Arrange

            new Toolbar(driver).ClickBtn_Hub("contact");
            Form form = new Form(driver);

            form.ClickSubmit();
            form.SetName(forename);
            form.SetEmail(email);
            form.SetMessage(message);

            //Act

            //Assert
            
            var existsOrNot = driver.FindElements(By.Id("forename")).Count;
            if (existsOrNot == 0)
            {
                Assert.AreEqual(null, driver.FindElement(By.Id("forename-err")));
            }
            
        }

        [TestMethod]
        public void ClickMenu_ClickSides_Compare() 
        {
            const string prodName = "Chunky Chips and Aioli";
            const double price = 9.99;
            const int kilojoules = 3273;
            //Arrange

            new Toolbar(driver).ClickBtn_Hub("menu");
            SidesBtn sideBtn = new SidesBtn(driver);
            SidesBtn.ClickSidesBtn();

            //Act
            SidesBtn.GetKilojoules(prodName);
            SidesBtn.GetPrice(prodName);
            
            //Comments-- Couldn't finish it
            /*
             I try to structure the code so I pass the menu item name
            so I get the price and kilojoules info. So, I compare it.
            I couldn't able to structure the code I want.

         
             */

            //Assert
            //Assert.AreEqual(expected: price , actual: );
            
        }

        [TestCleanup] 
        public void CleanUp() 
        {
            driver.Quit();

        }
    }
}