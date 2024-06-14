using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;

namespace SeleniumCSharp;

[TestFixture]
public class OrderSkipAttribute
{

    [Test, Order(2),Category("OrderSkipAttribute")]
    public void Test1()
    {
        Assert.Ignore("Defect 12345");
        IWebDriver driver = new ChromeDriver();
        driver.Url = "https://www.facebook.com/";

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");

        driver.Close();
    }

    [Test, Order(1), Category("OrderSkipAttribute")]
    public void Test2()
    {
        IWebDriver driverF = new FirefoxDriver();
        driverF.Url = "https://www.facebook.com/";

        WebDriverWait wait = new WebDriverWait(driverF, TimeSpan.FromSeconds(2));

        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");

        driverF.Close();
        driverF.Quit();
    }

    [Test, Order(0), Category("OrderSkipAttribute")]
    public void Test3()
    {
        IWebDriver driver = new EdgeDriver();
        driver.Url = "https://www.facebook.com/";

        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");

        driver.Close();
        driver.Quit();
    }
}