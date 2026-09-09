using OpenQA.Selenium;

namespace Lesson20;

public class AddToCartPage
{
    public IWebDriver driver;
    public AddToCartPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public AddToCartPage ClickAddToCartButton()
    {
        driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack")).Click(); // добавить в корзину
        return this;
    }
   
}