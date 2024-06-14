using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;
using SeleniumCSharp.Utilities;
using SeleniumExtras.WaitHelpers;

//[assembly: LevelOfParallelism(10)]

namespace SeleniumCSharp;

[TestFixture]
[Parallelizable(ParallelScope.Children)]
public class ParallelTesting
{

    IWebDriver driver;

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test1()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test2()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test3()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test4()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test5()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test6()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test7()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test8()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test9()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }

    [Test, Category("UAT Testing"), Category("Module1")]
    public void Test10()
    {
        var Driver = new BrowserUtility().Init(driver);

        WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(2));


        // Wait until the email text field is present and enter text
        IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
        emailTextField.SendKeys("Selenium C#");


        Driver.Close();
    }
}