using Framework.Services;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace Framework.Driver
{
    class DriverSingleton
    {
        static IWebDriver driver;

        private static ILog Log = LogManager.GetLogger("LOGGER");
        private DriverSingleton() { }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                switch (TestContext.Parameters.Get("browser"))
                {
                    case "Edge":
                        new DriverManager().SetUpDriver(new EdgeConfig());
                        driver = new EdgeDriver();
                        break;
                    default:
                        new DriverManager().SetUpDriver(new ChromeConfig());
                        driver = new ChromeDriver();
                        break;
                }
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            }
            Logger.InitLogger();
            Logger.Log.Debug("Browser create");
            return driver;
        }

        public static void CloseDriver()
        {
            driver.Quit();
            Logger.Log.Debug("Browser close");
            driver = null;
        }
    }
}
