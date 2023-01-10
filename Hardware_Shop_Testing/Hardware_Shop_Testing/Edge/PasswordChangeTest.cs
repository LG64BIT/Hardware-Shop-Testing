namespace Hardware_Shop_Testing.Edge
{
    [TestFixture]
    public class PasswordChangeTest
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new EdgeDriver();
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
        public void ThePasswordChangeTest()
        {
            Utils.Login(driver, "d.ivanusic@gmail.com", "12345678");
            driver.Navigate().GoToUrl("http://localhost/WebShop_php/profile");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).SendKeys("87654321");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).SendKeys("87654321");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@value='Change password']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Logout")).Click();
            Thread.Sleep(1000); Utils.Login(driver, "d.ivanusic@gmail.com", "87654321");
            //revert password to original so other tests do not fail because its hardcoded
            driver.Navigate().GoToUrl("http://localhost/WebShop_php/profile");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("oldPassword")).SendKeys("87654321");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("newPassword")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.Id("repeat")).SendKeys("12345678");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@value='Change password']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.LinkText("Logout")).Click();
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
