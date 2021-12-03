using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;

namespace TestingApp
{
    class ContactUsPage
    {
        IWebDriver m_driver;

        [Test]
        public void cssDemo()
        {
 
            m_driver = new ChromeDriver("C:\\Users\\Milkah.Warui\\Downloads\\chromedriver_win32 (2)");
            m_driver.Url = "https://reports.slafrica.net:9005/ztest/payment-gateway.html";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement LogInTextBox = m_driver.FindElement(By.XPath("./html/body/main/header/nav[1]/ul/li[5]/a"));
            LogInTextBox.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement FNameTextBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/div[1]/input"));
            FNameTextBox.SendKeys("Milkah");
            System.Threading.Thread.Sleep(1000);

            IWebElement LNameTextBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/div[2]/input"));
            LNameTextBox.SendKeys("Warui");
            System.Threading.Thread.Sleep(1000);

            IWebElement EmailTextBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/div[3]/input"));
            EmailTextBox.SendKeys("Waruimiley@gmail.com");
            System.Threading.Thread.Sleep(1000);

            IWebElement PNoTextBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/div[4]/input"));
            PNoTextBox.SendKeys("+254716911666");
            System.Threading.Thread.Sleep(1000);

            IWebElement SolutionTextBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/div[5]/div/div/ul/li[2]"));
            SolutionTextBox.SendKeys("Payment Gateway");
            System.Threading.Thread.Sleep(1000);

            IWebElement CheckBox = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/label/span"));
            CheckBox.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement signUpButton = m_driver.FindElement(By.XPath("./html/body/main/article/section/div[2]/div[1]/form/button"));
            signUpButton.Click();
            System.Threading.Thread.Sleep(1000);










        }
    }
}
