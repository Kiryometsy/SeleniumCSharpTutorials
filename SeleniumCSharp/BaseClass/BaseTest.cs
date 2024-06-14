using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumCSharp.BaseClass;

public class BaseTest
{
    public IWebDriver driver;

    [SetUp]
    public void Open()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Url = "https://www.facebook.com/";
    }
    [TearDown]
    public void Close()
    {
        driver.Close();
        driver.Quit();
    }
}
