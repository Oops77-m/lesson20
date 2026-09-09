using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Lesson20;

public class HeanderSection : BasePage
{
    private readonly By _btnBurgerMenu = By.Id("react-burger-menu-btn");
    private readonly By _btnLogout = By.Id("logout_sidebar_link");
    
    public HeanderSection(IWebDriver driver) : base(driver)
    {
    }

    public HeanderSection OpenSideMenu()
    {
        _driver.FindElement(_btnBurgerMenu).Click();
        WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        wait.Until(e => e.FindElement(_btnLogout).Displayed);

        return this;
    }

    public LoginPage ClickLogoutButton()
    {
        _driver.FindElement(_btnLogout).Click();
        return new LoginPage(_driver);
    }

    public LoginPage Logout()
    {
        return OpenSideMenu().ClickLogoutButton();
    }
}
