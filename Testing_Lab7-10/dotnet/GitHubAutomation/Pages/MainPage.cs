using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Services;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Framework.Pages
{
    class MainPage
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        private IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Откуда'][@type='text']")]
        private IWebElement fromWhatCity;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Куда'][@type='text']")]
        private IWebElement whereTo;

        [FindsBy(How = How.XPath, Using = "//button[text()='Найти']")]
        private IWebElement searchButton;

        [FindsBy(How = How.XPath, Using = "//div[2]/span[2][text()='22.12']")]
        private IWebElement departureDay;

        [FindsBy(How = How.XPath, Using = "//div[2]/span[3][text()='23.12']")]
        private IWebElement dayBack;

        [FindsBy(How = How.CssSelector, Using = "#loginUserName")]
        private IWebElement loginUserName;
        
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[1]/div[1]/div/div[1]/noindex/a[1]")]
        private IWebElement englishLanguge;

        public MainPage(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("MainPage init");
        }

        public TicketPrice SearchTickets(string FromWhat, string Where, string TicketThere, string TicketBack)
        {
            fromWhatCity.SendKeys(FromWhat);
            whereTo.SendKeys(Where);
            searchButton.Click();
            Logger.Log.Debug("Search Tickets");
            return new TicketPrice(this.browser);
        }
        public LoginPage Login()
        {
            Logger.Log.Debug("Login Page Init");
            return new LoginPage(this.browser);
        }
        public string CheckUserName()
        {
            Logger.Log.Debug("Check UserName");
            return loginUserName.Text;
        }
        public TicketPrice SearchTicketsWithComeBack(string FromWhat, string Where, string TicketThere, string TicketBack)
        {
            fromWhatCity.SendKeys(FromWhat);
            whereTo.SendKeys(Where);
            departureDay.Click();
            dayBack.Click();
            searchButton.Click();
            Logger.Log.Debug("Search tickets with come back");
            return new TicketPrice(this.browser);
        }
        public MainPage SelectEnglishLanguage()
        {
            englishLanguge.Click();
            return new MainPage(this.browser);
        }
        public string CHeckEnglishLanguage()
        {
            return englishLanguge.Text;
        }

    }
}
