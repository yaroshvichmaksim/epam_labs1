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
    class AboutPassenger
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Ваш e-mail']")]
        private IWebElement enterEmail;

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Ваш e-mail']")]
        public IWebElement chekEnterEmail;

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Введите имя']")]
        public IWebElement name;

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Введите отчество']")]
        public IWebElement lastname; 

        [FindsBy(How = How.XPath, Using = "//input[@type='text'][@placeholder='Введите фамилию']")]
        public IWebElement surname;

        [FindsBy(How = How.XPath, Using = "//select[@class='t_sex']")]
        public IWebElement genderSelect;

        [FindsBy(How = How.XPath, Using = "//select/option[2]")]
        public IWebElement gender;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='дд.мм.гггг']")]
        public IWebElement bthday;

        [FindsBy(How = How.XPath, Using = "//input[@tabindex='8']")]
        public IWebElement passportNum;

        [FindsBy(How = How.XPath, Using = "/html/body/div[3]/div[2]/div/div[2]/div[1]/div[3]/div/div[2]/div/div[2]/input")]
        public IWebElement numberPhone;

        private IWebDriver browser;

        public AboutPassenger(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("AboutPassenger Init");
        }
        public AboutPassenger EnterEmail(string EnterEmail)
        {
            enterEmail.SendKeys(EnterEmail);
            Logger.Log.Debug("Enter Email");
            return this;
        }
        public string CheckEmail()
        {
            Logger.Log.Debug("Check Email");
            return chekEnterEmail.Text;
        }
        public AboutPassenger InputPassengerData(string name,string surname, string lastname, string gender, string bthday, string passportNum)
        {
            this.name.SendKeys(name);
            this.surname.SendKeys(surname);
            this.lastname.SendKeys(lastname);
            this.genderSelect.Click();
            this.bthday.SendKeys(bthday);
            this.passportNum.SendKeys(passportNum);
            Logger.Log.Debug("Input Information by Paassengers");
            return this;
        }
        public AboutPassenger InputPassengerDataWithContactsDetails(string name, string surname, string lastname, string gender, string bthday, string passportNum,string email,string numberPhone)
        {
            this.name.SendKeys(name);
            this.surname.SendKeys(surname);
            this.lastname.SendKeys(lastname);
            this.genderSelect.Click();
            this.bthday.SendKeys(bthday);
            this.passportNum.SendKeys(passportNum);
            this.enterEmail.SendKeys(email);
            this.numberPhone.SendKeys(numberPhone);
            Logger.Log.Debug("Input Information by Paassengers");
            return this;
        }
    }
}
