using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class AboutPassenger
    {
        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Ваш e-mail']")]
        private IWebElement enterEmail;

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Ваш e-mail']")]
        public IWebElement chekEnterEmail;

        public AboutPassenger(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public AboutPassenger EnterEmail(string EnterEmail)
        {
            enterEmail.SendKeys(EnterEmail);
            return this;
        }
    }
}
