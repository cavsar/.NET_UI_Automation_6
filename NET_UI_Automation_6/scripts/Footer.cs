using NET_UI_Automation_6.pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_UI_Automation_6.scripts
{
    public class Footer :BaseTest
    {
        [SetUp]
        public void SetPage()
        {
            basePage = new BasePage();
        }
        [Test]
        public void ValidateTheFooter()
        {
           
            Assert.That(basePage.addressText.Text, Is.EqualTo("2860 S River Rd Suite 480, Des Plaines, IL 60018"));
           // Assert.That(addressText.Text.Equals("2860 S River Rd Suite 480, Des Plaines, IL 60018"));
            for (int i = 0; i < basePage.socialMediaIcons.Count; i++)
            {
                Assert.That(basePage.socialMediaIcons[i].Displayed);
                Assert.That(basePage.socialMediaIcons[i].Enabled);
            }
        }
    }
    }

