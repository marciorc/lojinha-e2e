using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace lojinha_e2e.web.setup
{
    public class Setup
    {
        private IWebDriver _browser;

        [SetUp]
        public IWebDriver StartBrowser()
        {
            // System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + @"\chromedriver\chromedriver.exe");
            _browser = new ChromeDriver(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName) + @"\chromedriver\");

            _browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            _browser.Manage().Window.Maximize();
            _browser.Url = "http://165.227.93.41/lojinha-web/v2/";
            return _browser;
        }

        [OneTimeTearDown]
        public void Dispose()
        {
            _browser.Quit();
        }
    }
}
