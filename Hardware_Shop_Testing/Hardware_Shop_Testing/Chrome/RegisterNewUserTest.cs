namespace Hardware_Shop_Testing.Chrome
{
    [TestFixture]
    public class RegisterNewUserTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheRegisterNewUserTest()
        {
            driver.Navigate().GoToUrl("http://localhost/WebShop_php/");
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Register")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).SendKeys("test.man@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("email")).SendKeys("test.man@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//form[@action='login/submit']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("password")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
            Thread.Sleep(1000);
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        private string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }
    }
}
