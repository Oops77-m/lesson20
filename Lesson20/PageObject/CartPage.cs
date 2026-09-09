using OpenQA.Selenium;

namespace Lesson20;
/*
• !Открыть корзину. 
• !Проверить отображение страницы Cart.
• !Проверить отображение добавленного товара в корзине.
• !Проверить название товара в корзине.
• !Проверить количество товара.
• !Проверить цену товара.
• !Проверить удаление товара из корзины.
• !Проверить корзину после удаления товара.
• !Проверить переход к Checkout.
 */

public class CartPage
{
    private readonly By titleCart = By.CssSelector("[data-test='title']");
    public IWebDriver driver;
    public CartPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void ClickCartButton()
    {
        driver.FindElement(By.CssSelector("a[data-test='shopping-cart-link']")).Click(); //клинкуть на корзину
    }
    public bool YourCartDisplayed()
    {
        return driver.FindElement(titleCart)?.Displayed ?? false; // проверка
    }

    public bool SelectedItem() 
    {
        return driver.FindElement(By.XPath("//div[contains(text(),'sleek, streamlined')]"))?.Displayed ?? false; 
    }

    public bool NameItem()
    {
        return driver.FindElement(By.XPath("//div[text()='Sauce Labs Backpack']"))?.Displayed ?? false; 
    }

    public int CountItems()
    {
        return driver.FindElements(By.CssSelector("div[data-test='inventory-item-name']")).Count;
    }

    public bool PriceItem()
    {
        return driver.FindElement(By.XPath("//div[text()='29.99']"))?.Displayed ?? false;
    }
    public CartPage ClickDeleteItemButton()
    {
        driver.FindElement(By.Id("remove-sauce-labs-backpack")).Click(); // удалить из корзины
        return this;
    }

    public CartPage ClickCheckoutButton()
    {
        driver.FindElement(By.Id("checkout")).Click(); // перейти в чекаут
        return this;
    }

    public bool Checkout()
    {
        return driver.FindElement(By.Id("first-name"))?.Displayed ?? false;
    }
    
}