using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lesson20;

[TestFixture]
public class BaseTest
{
    protected IWebDriver driver;
      
    [SetUp]
    public void Setup()
    {
         driver = new ChromeDriver();
        //driver.Navigate().GoToUrl("https://www.saucedemo.com");
        //driver.Manage().Window.Maximize(); //увеличит окно
        //Thread.Sleep(3000);
        var basePage = new BasePage(driver);
        basePage.OpenSauceDemo();
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
        driver.Dispose();
    }

}