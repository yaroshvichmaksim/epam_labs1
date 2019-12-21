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
    class Place
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[10]/div/div[3]/div[3]/div[2]/div[2]/div[1]/div/div[2]/div/div/div[1]/div/div/div/span[39]")]
        private IWebElement seatSelection;

        [FindsBy(How = How.XPath, Using = "//button[text()='Указать данные пассажиров']")]
        private IWebElement indicatePassengerData;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[2]/div[10]/div/div[3]/div[3]/div[1]/div[2]/div[1]/div[2]/div/span[2]")]
        public IWebElement chekNumberOfPassenger;

        private IWebDriver browser;

        public Place(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("Place Init");
        }
        public AboutPassenger ClickSetSelection()
        {
            seatSelection.Click();
            indicatePassengerData.Click();
            Logger.Log.Debug("Choise the seat");
            return new AboutPassenger(browser);
        }
        public string CheckNumberOfPassengers()
        {
            Logger.Log.Debug("Check Number ticket of Passenger");
            return chekNumberOfPassenger.Text;
        }
    }
}
