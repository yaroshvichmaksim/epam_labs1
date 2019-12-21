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
    class SortTickets
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        private IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[1]/div[1]/div/div/select/option[4]")]
        private IWebElement selectByPrice;

        public SortTickets(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("TicketPrice Init");
        }
        public SortTickets SortByPrice()
        {
            Logger.Log.Debug("Sort Ticket By Price");
            return this;
        }
        public string CheckSortedTicketByPrice()
        {
            Logger.Log.Debug("Check Sorted Ticket");
            return selectByPrice.Text;
        }
    }
}
