using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharp;

[TestFixture]
public class SeleniumCSharpTutorial04
{
    [Test]
    [Author("MichałFaber", "email@gmail.com")]
    [Description("Facebook login veify")]
    [TestCaseSource("DataDrivenTesting")]
    public void Test1(String urlName)
    {
        IWebDriver driver = null;
        try
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //driver.Url = "https://www.facebook.com/";
            driver.Url = urlName;


            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

            // Wait until the email text field is present and enter text
            //IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
            IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='abcd']")));
            emailTextField.SendKeys("Selenium C#");

            driver.Quit();
        }
        catch (Exception e)
        {
            ITakesScreenshot ts = driver as ITakesScreenshot;
            Screenshot screenshot = ts.GetScreenshot();
            screenshot.SaveAsFile("../../../Screenshots/s1.png");
            Console.WriteLine(e.StackTrace);
            throw;
        }
        finally
        {
            if(driver != null)
            {
                driver.Quit();
            }
        }
    }

    static IList DataDrivenTesting()
    {
        ArrayList list = new ArrayList();
        list.Add("https://www.facebook.com/");
        //list.Add("https://www.youtube.com/");
        //list.Add("https://www.gmail.com/");

        return list;
    }

    //[Test]
    //[Author("MichałFaber", "email@gmail.com")]
    //[Description("Facebook login veify")]
    //public void Test2()
    //{
    //    IWebDriver driver = new ChromeDriver();
    //    driver.Manage().Window.Maximize();
    //    driver.Url = "https://www.facebook.com/";

    //    WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));

    //    // Wait until the email text field is present and enter text
    //    IWebElement emailTextField = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(".//*[@id='email']")));
    //    emailTextField.SendKeys("Selenium C#");

    //    driver.Quit();
    //}
}
