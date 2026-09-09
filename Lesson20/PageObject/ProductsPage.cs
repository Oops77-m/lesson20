using OpenQA.Selenium;

namespace Lesson20;

public class ProductsPage : BasePage
{
    private readonly By imgCart = By.CssSelector("a[data-test='shopping-cart-link']");
    
    public HeanderSection Heander => new HeanderSection(_driver);

    
    public ProductsPage(IWebDriver driver) : base(driver)
    {
        _driver = driver;
    }

    public bool IsCartIconDisplayed()
    {
        return _driver.FindElement(imgCart)?.Displayed ?? false; // проверка
    }
}