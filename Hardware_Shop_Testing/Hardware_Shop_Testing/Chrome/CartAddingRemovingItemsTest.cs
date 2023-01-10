namespace Hardware_Shop_Testing.Chrome
{
    [TestFixture]
    public class CartAddingRemovingItemsTest
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
        public void TheCartAddingRemovingItemsTest()
        {
            driver.Navigate().GoToUrl("http://localhost/WebShop_php/home");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@value='Add to cart']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[2]/form/input[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Cart")).Click();
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("http://localhost/WebShop_php/cart");
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("+")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("(.//*[normalize-space(text()) and normalize-space(.)='-'])[1]/following::a[1]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("-")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("-")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("-")).Click();
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
