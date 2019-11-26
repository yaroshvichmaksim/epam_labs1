using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    class AboutPassenger
    {
        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(3) > div > div.wg-block__section.wg-block__section_noborder.wg-block__section_nopadding > div > div:nth-child(1) > input")]
        private IWebElement enterEmail { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(3) > div > div.wg-block__section.wg-block__section_noborder.wg-block__section_nopadding > div > div:nth-child(1) > input")]
        public IWebElement chekEnterEmail { get; private set; }

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
