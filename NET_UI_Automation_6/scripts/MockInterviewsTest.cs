using NET_UI_Automation_6.pages;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.DevTools.V112.DOM;

namespace NET_UI_Automation_6.scripts
{
    public class MockInterviewsTest:BaseTest
    {
        [SetUp]
        public void SetPage()
        {
           basePage = new BasePage();
            mockInterviewspage = new MockInterviewspage();
            actions.MoveToElement(basePage.practicesDropdown).Perform();
            basePage.dropdownOptions[4].Click();
        }
        [Test]
        public void ValidateTheHeader()
        {
            
            Assert.That(mockInterviewspage.header.Text,Is.EqualTo("Designed for TechGlobal Students"));
    
}
        [Test]
        [TestCase("john", "1234")]
        [TestCase("techglobal", "2020")]
        [TestCase("okan", "1234test")]

        public void ValidateLoginFormErrorMessage(string username, string password)
        {
            mockInterviewspage.username.SendKeys("john");
            mockInterviewspage.password.SendKeys("1234");
            actions.MoveToElement(mockInterviewspage.loginButton).Click().Perform();
            Assert.That(mockInterviewspage.errorMessage.Text, Is.EqualTo("Email or Password does not match!"));

        }
    }
}
