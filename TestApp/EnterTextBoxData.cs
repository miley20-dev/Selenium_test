using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingAppClass
{
    class EnterTextData
    {
        IWebDriver m_driver;

        [Test]
        public void cssDemo()
        {
            m_driver = new ChromeDriver("C:\\Users\\Milkah.Warui\\Downloads\\chromedriver_win32 (2)"); 
            m_driver.Url = "https://reports.slafrica.net:9005/ztest/payment-gateway.html";
            m_driver.Manage().Window.Maximize();


            // Store locator values of email text box and sign up button				
            IWebElement LogInTextBox = m_driver.FindElement(By.XPath("./html/body/main/header/nav[1]/div[3]/div/a[1]"));
            LogInTextBox.Click();
            IWebElement emailTextBox = m_driver.FindElement(By.XPath("./html/body/main/header/nav[1]/div[3]/div/div/div/div/div/div[2]/div[1]/form/div[1]/input"));
            IWebElement PassWordTextBox = m_driver.FindElement(By.XPath("./html/body/main/header/nav[1]/div[3]/div/div/div/div/div/div[2]/div[1]/form/div[2]/input"));
            IWebElement signUpButton = m_driver.FindElement(By.XPath("./html/body/main/header/nav[1]/div[3]/div/div/div/div/div/div[2]/div[1]/form/button"));

            emailTextBox.SendKeys("Milkah.warui@switchlinkafrica.co.ke");
            System.Threading.Thread.Sleep(4000);
            PassWordTextBox.SendKeys("Miley5132!");
            System.Threading.Thread.Sleep(4000);
            signUpButton.Click();
            System.Threading.Thread.Sleep(4000);

        }
    }
}