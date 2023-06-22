using NET_UI_Automation_6.utils;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_UI_Automation_6.pages
{
    public class MockInterviewspage:BasePage
    {
        

        public IWebElement header => driver.FindElement(By.CssSelector("div>h2"));
        public IWebElement username => driver.FindElement(By.CssSelector("input[type='email']"));
        public IWebElement password => driver.FindElement(By.CssSelector("input[type='password']"));
        public IWebElement loginButton => driver.FindElement(By.CssSelector("button[type = 'submit']"));
        public IWebElement errorMessage => driver.FindElement(By.CssSelector("div[class^='Login_err']"));

        
        
    }
}
