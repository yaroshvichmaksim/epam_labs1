using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class Place
    {
        [FindsBy(How = How.XPath, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(11) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(2) > div:nth-child(2) > div.wg-order-seats__scheme-wrap > div > div.wg-places-scheme__scheme > div > div > div.wg-carousel__slide.wg-carousel__slide_selected > div > div > div:nth-child(8) > div.wg-regular__berth.wg-regular__berth_side > span:nth-child(1)")]
        private IWebElement seatSelection;

        [FindsBy(How = How.XPath, Using = "//button[text()='Указать данные пассажиров']")]
        private IWebElement indicatePassengerData;

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
