using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;
using SeleniumExtras.WaitHelpers;

namespace SeleniumCSharp;

[TestFixture]
public class Tests : BaseTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test,Category("Smoke Testing")]
    public void Test1()
    {
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

        // Wait until the cookies button is present and clickable, then click it
        try
        {
            IWebElement cookiesButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']")));
            cookiesButton.Click();
        }
        catch (WebDriverTimeoutException)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("console.log('Cookies1 button not found or not clickable within the timeout period.')");
        }

        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");

        // Wait until the Create Account button is present and clickable, then click it
        IWebElement createAccountButton = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[starts-with(@id, 'u_0_0_') and string-length(@id) >= 7]")));
        createAccountButton.Click();

        // Wait until the cookies button is present and clickable, then click it

        try
        {
            IWebElement cookiesButton2 = wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']")));
            cookiesButton2.Click();
        }
        catch (WebDriverTimeoutException)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript("console.log('Cookies2 button not found or not clickable within the timeout period.')");
        }

        IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
        SelectElement element = new SelectElement(monthDropdownList);
        element.SelectByValue("3");
    }

    [Test,Category("Regression Testing")]
    public void Test2()
    {
        IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        emailTextField.SendKeys("Selenium C#");
        IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']"));
        cokkies.Click();
    }

    [Test,Category("Smoke Testing")]
    public void Test3()
    {
        IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
        emailTextField.SendKeys("Selenium C#");
        Thread.Sleep(5000);
        IWebElement cokkies = driver.FindElement(By.XPath(".//*[@aria-label='Odrzuæ opcjonalne pliki cookie']"));
        cokkies.Click();
    }
}