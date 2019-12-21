using Framework.Models;
using Framework.Pages;
using Framework.Services;
using log4net;
using NUnit.Framework;

namespace Framework.Tests
{
    class Tests :TestConfig
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        [Test]
        public void Search_Tickets_From_Minsk_To_Moscow()
        {

            Logger.InitLogger();
            TicketPrice ticketPrice = new MainPage(Browser).Login().ClickComeIn(new User().Login, new User().Password)
                .SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate);
            Logger.Log.Debug("End Test");
        }

        [Test]
        public void Search_Tickets_From_Minsk_To_Moscow_For_Two_Person()
        {
            Logger.InitLogger();
            Place ticketPrice = new MainPage(Browser).Login().ClickComeIn(new User().Login, new User().Password)
                .SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate)
                .ClickReservedTicketButton()
                .TicketsFromTwoPeople();
            Assert.AreEqual("2", ticketPrice.CheckNumberOfPassengers());
            Logger.Log.Debug("End Test");
        }

        [Test]
        public void Loggin_In()
        {
            Logger.InitLogger();
            MainPage mainPage = new MainPage(Browser).Login().ClickComeIn(new User().Login, new User().Password);
            Assert.AreEqual("Максим", mainPage.CheckUserName());
            Logger.Log.Debug("End Test");
        }

        [Test]
        public void Serach_For_Tickets_Indicating_The_Station()
        {
            Logger.InitLogger();
            TicketPrice ticketPrice = new MainPage(Browser).SearchTickets(new Route().DepartureCityWithStation, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate);
            Assert.AreEqual("Не найдено ни одного поезда прямого сообщения. Выберите станцию пересадки", ticketPrice.CheckCityWithStation());
            Logger.Log.Debug("End Test");

        }

        [Test]
        public void Sort_Tickets_By_Price()
        {
            Logger.InitLogger();
            SortTickets sortTickets = new MainPage(Browser).SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate)
                .SortTickets()
                .SortByPrice();
            Assert.AreEqual("по цене", sortTickets.CheckSortedTicketByPrice());
            Logger.Log.Debug("End Test");

        }

        [Test]
        public void Search_Ticket_From_Minsk_To_Moscow_With_On_Email()
        {
            Logger.InitLogger();
            AboutPassenger aboutPassenger = new MainPage(Browser).SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate)
                .ClickReservedTicketButton()
                .TicketsFromOnePerson()
                .ClickSetSelection()
                .EnterEmail(new User().Login);
            Assert.AreEqual("yaroshevichmaks@gmail.com", aboutPassenger.CheckEmail());
            Logger.Log.Debug("End Test");

        }
        [Test]
        public void Search_Ticket_From_Minsk_To_Moscow_With_Information_About_Passenger()
        {
            Logger.InitLogger();
            AboutPassenger aboutPassenger = new MainPage(Browser).SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate)
                .ClickReservedTicketButton()
                .TicketsFromOnePerson()
                .ClickSetSelection()
                .InputPassengerData(new Customer().name, new Customer().surname, new Customer().lastname, new Customer().gender, new Customer().bthday, new Customer().passport);
            Assert.AreEqual("Максим", new Customer().name);
            Logger.Log.Debug("End Test");
        }

        [Test]
        public void Search_Ticket_From_Minsk_To_Moscow_With_Come_Back()
        {
            Logger.InitLogger();
            TicketPrice ticketPrice = new MainPage(Browser).SearchTicketsWithComeBack(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate);
            Assert.AreEqual(ticketPrice.CheckStringEmpty(), string.Empty);
            Logger.Log.Debug("End Test");
        }

        [Test]
        public void Search_Ticket_From_Minsk_To_Moscow_With_Information_About_Passenger_And_Contacts_Details()
        {
            Logger.InitLogger();
            AboutPassenger aboutPassenger = new MainPage(Browser).SearchTickets(new Route().DepartureCity, new Route().ArrivalCity, new Route().DateDeparture, new Route().PastDate)
                .ClickReservedTicketButton()
                .TicketsFromOnePerson()
                .ClickSetSelection()
                .InputPassengerDataWithContactsDetails(new Customer().name, new Customer().surname, new Customer().lastname, new Customer().gender, new Customer().bthday, new Customer().passport,new User().Login,new Customer().numberPhone);
            Logger.Log.Debug("End Test");
            Assert.AreEqual("yaroshevichmaks@gmail.com", aboutPassenger.CheckEmail());
            Logger.Log.Debug("End Test");
        }
        [Test]
        public void SelectEnglishLanguage()
        {
            Logger.InitLogger();
            MainPage mainPage = new MainPage(Browser).SelectEnglishLanguage();
            Assert.AreEqual("RU", mainPage.CHeckEnglishLanguage());
            Logger.Log.Debug("End Test");
        }

    }
}
