using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace WebDriver3
{
    [TestClass]
    public class UnitTest1
    {
        IWebDriver webDriver;
        [TestMethod]
        public void Sort_Tickets_From_Minsk_To_Molodechno_By_Price()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.ufs-online.ru/");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-from > div > div:nth-child(2) > input")).SendKeys("Минск");
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-to > div > div:nth-child(2) > input")).SendKeys("Молодечно");
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_submit > div > button")).Click();
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div.wg-block.wg-block_bordered > div.wg-block__inner.wg-block__inner_small-bottom-padding.wg-block__inner_filled-dark.wg-block__inner_found > div > div > select > option:nth-child(4)")).Click();       
            webDriver.Quit();
        }
        [TestMethod]
        public void Ordering_Ticket_From_Minsk_To_Molodechno_With_An_Email()
        {
            webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://www.ufs-online.ru/");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-from > div > div:nth-child(2) > input")).SendKeys("Минск");
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_way > div > div.wg-search__col.wg-search__col_way-to > div > div:nth-child(2) > input")).SendKeys("Молодечно");
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div > div > div.wg-search__col.wg-search__col_submit > div > button")).Click();
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(5) > div > div.wg-block__inner.wg-train-options__wagon > div > div:nth-child(3)")).Click();
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(5) > div > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(2) > div:nth-child(2) > div.wg-order-seats__scheme-wrap > div > div.wg-places-scheme__scheme > div > div > div.wg-carousel__slide.wg-carousel__slide_selected > div > div > div > span:nth-child(40)")).Click();
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(5) > div > div.wg-block__inner.wg-block__inner_border-top.wg-train-options__seats.wg-train-options__seats_visible.wg-order-seats > div:nth-child(3) > button")).Click();
            webDriver.FindElement(By.CssSelector("#ufs-railway-app > div > div.wg-layout__inner-wrap > div.wg-layout__main > div:nth-child(3) > div > div.wg-block__section.wg-block__section_noborder.wg-block__section_nopadding > div > div:nth-child(1) > input")).SendKeys("yaroshevich@gmail.com");
            webDriver.Quit();

        }
    }
}
