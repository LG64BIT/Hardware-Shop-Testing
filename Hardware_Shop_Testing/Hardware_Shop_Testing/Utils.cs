public static class Utils
{
    public static void Login(IWebDriver driver, String username, String password)
    {
        driver.Navigate().GoToUrl("http://localhost/WebShop_php/home");
        Thread.Sleep(1000);
        driver.FindElement(By.LinkText("Login")).Click();
        Thread.Sleep(1000);
        driver.Navigate().GoToUrl("http://localhost/WebShop_php/login");
        Thread.Sleep(1000);
        driver.FindElement(By.Id("email")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("email")).Clear();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("email")).SendKeys(username);
        Thread.Sleep(1000);
        driver.FindElement(By.Id("password")).Click();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("password")).Clear();
        Thread.Sleep(1000);
        driver.FindElement(By.Id("password")).SendKeys(password);
        Thread.Sleep(1000);
        driver.FindElement(By.XPath("//input[@value='Submit']")).Click();
        Thread.Sleep(1000);
        driver.Navigate().GoToUrl("http://localhost/WebShop_php/home");
        Thread.Sleep(1000);
    }
}