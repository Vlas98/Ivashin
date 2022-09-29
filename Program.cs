using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.WaitHelpers;

namespace SeleniumDocs.Hello
{
    public class HelloSelenium
    {
        public static void Main()
        {
            var driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.demoblaze.com/");
            driver.Manage().Window.Maximize();

            IWebElement logButton = driver.FindElement(By.Id("login2"));
            logButton.Click();

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("loginusername")));

            IWebElement loginEl = driver.FindElement(By.Id("loginusername"));
            loginEl.SendKeys("admin");

            IWebElement passwordEl = driver.FindElement(By.Id("loginpassword"));
            passwordEl.SendKeys("admin");

            IWebElement sub = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div[3]/button[2]"));
            sub.Click();
        }
    }
}
