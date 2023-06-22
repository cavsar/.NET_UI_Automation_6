using NET_UI_Automation_6.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_UI_Automation_6.pages
{
    public class FrontendTestinPage:BasePage
    {
        public IList<IWebElement> cards => driver.FindElements(By.CssSelector(".card"));
    }
}
