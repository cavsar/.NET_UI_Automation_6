using OpenQA.Selenium;

namespace NET_UI_Automation_6.scripts
{
    public class FrontendTestingPage:BaseTest

    {
        public IList<IWebElement> cards => driver.FindElements(By.CssSelector(".card"));






    }
}