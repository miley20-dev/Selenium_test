using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;

namespace TestApp
{
    class TestingAppClass
    {
        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\Milkah.Warui\\Downloads\\chromedriver_win32 (2)");
        }


        [Test]
        public void Test()
        {
            driver.Url = "http://192.168.100.6:8057/login";
            System.Threading.Thread.Sleep(4000);
        }

        [Test]
        public void TestRefresh()
        {
            driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(4000);
        }

        [Test]
        public void TestForward()
        {
            driver.Navigate().Forward();
        }

        [Test]
        public void TestTitle()
        {
            _ = driver.Title;
            System.Threading.Thread.Sleep(4000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Close();
            System.Threading.Thread.Sleep(4000);
        }

    }
}