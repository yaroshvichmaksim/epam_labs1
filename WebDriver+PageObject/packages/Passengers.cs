using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    class Passengers
    {
        [FindsBy(How=How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(7) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(1) > div.wg-order-seats__spinners > div:nth-child(1) > div.wg-order-seats__counter > div > span.wg-spinner__control.wg-spinner__control_plus")]
        private IWebElement numberOfAdultPlaces { get; set; }


        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(7) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(1) > div.wg-order-seats__spinners > div:nth-child(1) > div.wg-order-seats__counter > div > span.wg-spinner__value")]
        public IWebElement chekNumberOfPassenger { get; private set; }

        public Passengers(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public Passengers NumberOfAdultPlacesClick()
        {
            numberOfAdultPlaces.Click();
            return this;
        }

    }
}
