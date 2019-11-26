using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    class Place
    {
        [FindsBy(How = How.XPath, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(8) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(2) > div:nth-child(2) > div.wg-order-seats__scheme-wrap > div > div > div > div > div > div > div > div:nth-child(8) > div.wg-regular__berth.wg-regular__berth_side > span:nth-child(1)")]
        private IWebElement seatSelection { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(8) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(3) > button")]
        private IWebElement indicatePassengerData { get; set; }

        public Place(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public Place ClickSetSelection()
        {
            seatSelection.Click();
            indicatePassengerData.Click();
            return this;
        }
    }
}
