using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PageObject
{
    [TestClass]
    public class SiteTest
    {
        IWebDriver webDriver;
        [TestMethod]
        public void Search_Tickets_For_Two_From_Minsk_To_Moskva()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.ufs-online.ru/");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            MainPage mainPage = new MainPage(webDriver).SearchTickets("Минск", "Москва");
            TicketPrice seatOnTheTrain = new TicketPrice(webDriver).ClickReservedTicketButton();
            Passengers passengers = new Passengers(webDriver).NumberOfAdultPlacesClick();
            Assert.AreEqual("2", passengers.chekNumberOfPassenger.Text);
            webDriver.Quit();
        }
        [TestMethod]
        public void Order_Ticket_From_Minsk_To_Moskva_With_An_Email()
        {
            webDriver = new ChromeDriver();
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.ufs-online.ru/");
            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            MainPage mainPage = new MainPage(webDriver).SearchTickets("Минск", "Москва");
            TicketPrice seatOnTheTrain = new TicketPrice(webDriver).ClickReservedTicketButton();
            Passengers passengers = new Passengers(webDriver).NumberOfAdultPlacesClick();
            Place place = new Place(webDriver).ClickSetSelection();
            AboutPassenger aboutPassenger = new AboutPassenger(webDriver).EnterEmail("yaroshevichmaks@gmail.com");
            Assert.AreEqual("yaroshevichmaks@gmail.com", aboutPassenger.chekEnterEmail.Text);
            webDriver.Quit();
        }
    }
}
