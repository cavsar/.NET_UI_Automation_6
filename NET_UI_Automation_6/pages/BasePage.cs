using NET_UI_Automation_6.scripts;
using NET_UI_Automation_6.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_UI_Automation_6.pages
{
    public class BasePage : BaseTest
    {

        public IWebElement logo => driver.FindElement(By.Id("logo"));
        public IWebElement practicesDropdown => driver.FindElement(By.Id("dropdown-button"));
        public IList<IWebElement> dropdownOptions => driver.FindElements(By.CssSelector("#dropdown-menu a"));
        public IWebElement addressText => driver.FindElement(By.XPath("(//div[@class='has-text-centered']//p)[1]"));
        public IList<IWebElement> socialMediaIcons => driver.FindElements(By.CssSelector(".Footer_socials__7h4n1 a"));
        public IWebElement frontEndOption => driver.FindElement(By.Id("frontend-option"));
        public IList<WebElement> cards =>(IList<WebElement>) driver.FindElements(By.CssSelector("div[class*='card']>a"));

    }   

   
}
