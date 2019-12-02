using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Откуда'][@type='text']")]
        private IWebElement fromWhatCity;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Куда'][@type='text']")]
        private IWebElement whereTo;
        [FindsBy(How = How.XPath, Using = "//button[text()='Найти']")]
        private IWebElement searchButton;
        public MainPage(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public MainPage SearchTickets(string FromWhat, string Where)
        {
            fromWhatCity.SendKeys(FromWhat);
            whereTo.SendKeys(Where);
            searchButton.Click();
            return this;
        }

    }
}
