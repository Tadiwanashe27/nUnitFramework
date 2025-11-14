using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace FrameworkBuilding;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //finds out what driver I need and downloads it and tells selenium where to find it :)
       new DriverManager().SetUpDriver(new ChromeConfig());
        var _webDriver = new ChromeDriver();

        // Navigate to google
        _webDriver.Navigate().GoToUrl("https://www.google.com");

        //close browser 
        _webDriver.Quit();
        
    }

    [Test] 
    public void Test2()
    {
        Assert.Fail();
    }
}
