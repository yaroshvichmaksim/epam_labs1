using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObject
{
    public class TicketPrice
    {
        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(11) > div > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_no-padding-top > div.wg-train-options__wrap > div:nth-child(2) > div > div.wg-wagon-type__item.wg-wagon-type__item_selected")]
        private IWebElement reservedSeat;
        public TicketPrice(IWebDriver webDriver)
        {
            PageFactory.InitElements(webDriver, this);
        }
        public TicketPrice ClickReservedTicketButton()
        {
            reservedSeat.Click();
            return this;
        }
    }
}
