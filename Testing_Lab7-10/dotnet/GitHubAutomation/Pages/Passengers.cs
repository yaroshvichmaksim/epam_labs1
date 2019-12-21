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
    class Passengers
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[10]/div/div[3]/div[3]/div[1]/div[2]/div[1]/div[2]/div/span[3]")]
        private IWebElement numberOfAdultPlaces;


        private IWebDriver browser;

        public Passengers(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("MainPassengers Init");
        }
        public Place TicketsFromTwoPeople()
        {
            numberOfAdultPlaces.Click();
            Logger.Log.Debug("Ticket from two Person");
            return new Place(browser);
        }
        public Place TicketsFromOnePerson()
        {
            Logger.Log.Debug("Ticket from one Person");
            return new Place(browser);
        }

    }
}
