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
    class MainPage
    {
        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-from > div > div:nth-child(2) > input")]
        private IWebElement fromWhatCity { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-to > div > div:nth-child(2) > input")]
        private IWebElement whereTo { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_submit > div > button")]
        private IWebElement searchButton { get; set; }
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
