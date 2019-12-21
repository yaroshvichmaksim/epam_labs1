using Framework.Services;
using log4net;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Pages
{
    class LoginPage
    {
        private static ILog Log = LogManager.GetLogger("LOGGER");

        private IWebDriver browser;

        [FindsBy(How = How.XPath, Using = "//a[@href='/profile/login/']")]
        private IWebElement comeInButon;

        [FindsBy(How = How.XPath, Using = "//input[@name='Email']")]
        private IWebElement login;

        [FindsBy(How = How.XPath, Using = "//input[@name='Password']")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//input[@type='submit'][@value='Войти']")]
        private IWebElement comeInButtonSecond;

        public LoginPage(IWebDriver browser)
        {
            Logger.InitLogger();
            this.browser = browser;
            PageFactory.InitElements(browser, this);
            Logger.Log.Debug("LoginPage init");

        }
        public MainPage ClickComeIn(string login, string password)
        {
            comeInButon.Click();
            this.login.SendKeys(login);
            this.password.SendKeys(password);
            comeInButtonSecond.Click();
            Logger.Log.Debug("Come In");
            return new MainPage(browser);
        }
    }
}
