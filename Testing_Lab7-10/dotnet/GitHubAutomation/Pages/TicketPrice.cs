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
    class TicketPrice
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        private IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[10]/div/div[2]/div[1]/div[2]/div[2]/div/div[1]")]
        private IWebElement reservedSeat;

        [FindsBy(How=How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[3]/div[1]")]
        private IWebElement cityWithStation;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Обратно']")]
        private IWebElement dayBackText;

        public TicketPrice(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("TicketPrice Init");
        }
        public Passengers ClickReservedTicketButton()
        {
            reservedSeat.Click();
            Logger.Log.Debug("Reserved Seat");
            return new Passengers(browser);
        }
        public string CheckCityWithStation()
        {
            Logger.Log.Debug("Check city with station");
            return cityWithStation.Text;
        }
        public SortTickets SortTickets()
        {
            Logger.Log.Debug("Sorted Page");
            return new SortTickets(browser);
        }
        public string CheckStringEmpty()
        {
            return dayBackText.Text;
        }
    }
}
