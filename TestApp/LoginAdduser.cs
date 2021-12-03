using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp;




namespace TestApp
{
    class LoginAdduser
    {
        IWebDriver m_driver;
        
        [Test]
        public void cssDemo()
        {

            m_driver = new ChromeDriver("C:\\Users\\Milkah.Warui\\Downloads\\chromedriver_win32 (2)");
            m_driver.Url = "http://192.168.100.6:8057/login";
            System.Threading.Thread.Sleep(1000);
            m_driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(1000);


            // Store locator values of email text box and sign up button				
            IWebElement OrganisationEmail = m_driver.FindElement(By.XPath("./html/body/div/div/div/div/div[1]/div/form/div[1]/input"));
            OrganisationEmail.SendKeys("Milkah.warui@switchlinkafrica.co.ke");
            System.Threading.Thread.Sleep(1000);
            IWebElement Password = m_driver.FindElement(By.XPath("./html/body/div/div/div/div/div[1]/div/form/div[2]/input"));
            Password.SendKeys("vitamins");
            System.Threading.Thread.Sleep(1000);
            IWebElement LoginButton = m_driver.FindElement(By.XPath("./html/body/div/div/div/div/div[1]/div/form/button"));
            LoginButton.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement UserManagement = m_driver.FindElement(By.XPath("./html/body/div/div[1]/div/div[1]/nav/ul/li[2]/a/span"));
            UserManagement.Click();
            System.Threading.Thread.Sleep(1000);
       

            var navigate = m_driver.Navigate();
            navigate.GoToUrl("http://192.168.100.6:8057/system-users"); //works
            System.Threading.Thread.Sleep(1000);

            
            IWebElement AddSystemUser = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/button"));
            AddSystemUser.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement Fname = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[1]/div[1]/input"));
            Fname.SendKeys("Wafula");
            System.Threading.Thread.Sleep(1000);

            IWebElement Lname = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[1]/div[2]/input"));
            Lname.SendKeys("Barasa");
            System.Threading.Thread.Sleep(1000);

            IWebElement IdNumber = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[2]/div[1]/input"));
            IdNumber.SendKeys("38121212");
            System.Threading.Thread.Sleep(1000);

            IWebElement OrganisationName = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[2]/div[2]/input"));
            OrganisationName.SendKeys("SwitchLinkAfrica");
            System.Threading.Thread.Sleep(1000);

            IWebElement EmailAddress = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[3]/div[1]/input"));
            EmailAddress.SendKeys("wafula.wepo@switchlinkafrica.co.ke");
            System.Threading.Thread.Sleep(1000);

            IWebElement PhoneNumber = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[3]/div[2]/input"));
            PhoneNumber.SendKeys("254704577537");
            System.Threading.Thread.Sleep(1000);

            IWebElement RoleSelect = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[4]/div[1]/select"));
            RoleSelect.SendKeys("Super User");
            System.Threading.Thread.Sleep(1000);

            IWebElement CooperativeSelect = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[4]/div[2]/select"));
            CooperativeSelect.SendKeys("Juhudi");
            System.Threading.Thread.Sleep(1000);

            IWebElement ProcessorSelect = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[5]/div[1]/select"));
            ProcessorSelect.SendKeys("Kenya Cooperative Creameries");
            System.Threading.Thread.Sleep(1000);

            IWebElement Remarks = m_driver.FindElement(By.XPath("/html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[5]/div[2]/input"));
            Remarks.SendKeys("User Created");
            System.Threading.Thread.Sleep(1000);

            IWebElement PasswordUser = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[6]/div/input"));
            PasswordUser.SendKeys("vitamins");
            System.Threading.Thread.Sleep(1000);

            IWebElement CreateUser = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[2]/div[2]/div/div/form/div[7]/button"));
            CreateUser.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement SearchUsers = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[3]/div[2]/div/div/div[1]/div/div/div[1]/div[2]/div/label/input"));
            SearchUsers.SendKeys("11223344");
            System.Threading.Thread.Sleep(1000);

           
            IWebElement EditUser = m_driver.FindElement(By.Id("editSingleUserModalLink"));
            EditUser.Click();
            System.Threading.Thread.Sleep(1000);

            IWebElement EnterDets = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[5]/div[2]/input"));
            EnterDets.SendKeys("User Updated");
            System.Threading.Thread.Sleep(1000);

            IWebElement KeyPass = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[6]/div/input"));
            KeyPass.SendKeys("vitamins");
            System.Threading.Thread.Sleep(1000);

            IWebElement UpdateKey = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[7]/div/button"));
            UpdateKey.Click();
            System.Threading.Thread.Sleep(1000);

            //_ = m_driver.Navigate();
            //navigate.GoToUrl("http://192.168.100.6:8057/system-users"); //works
            //System.Threading.Thread.Sleep(1000);

             m_driver.Navigate().Refresh();
            System.Threading.Thread.Sleep(1000);

            //IWebElement ToggleUser = m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/table/tbody/tr[1]/td[12]/div/table/tbody/tr/td[3]/a"));
           // ToggleUser.Click();
           // System.Threading.Thread.Sleep(1000);

            //IWebElement AccountStatus = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[1]/div/select"));
            //AccountStatus.SendKeys("Deactivate");
            //System.Threading.Thread.Sleep(1000);

            //IWebElement ToggleRemark = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[2]/div/input"));
            //ToggleRemark.SendKeys("User deactivated");
            //System.Threading.Thread.Sleep(1000);

            //IWebElement TogglePass = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[3]/div/input"));
            //TogglePass.SendKeys("vitamins");
            //System.Threading.Thread.Sleep(1000);

            //IWebElement ToggleUpdate = m_driver.FindElement(By.XPath("./html/body/div[1]/div[4]/div/div/div[2]/div/form/div[4]/div/button"));
            //ToggleUpdate.Click();
            //System.Threading.Thread.Sleep(1000);

            IWebElement ViewUser= m_driver.FindElement(By.XPath("./html/body/div/div[2]/div/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/table/tbody/tr[1]/td[2]/a"));
            ViewUser.Click();
            System.Threading.Thread.Sleep(1000);


            _ = m_driver.Navigate();
            navigate.GoToUrl("http://192.168.100.6:8057/system-users"); //works
            System.Threading.Thread.Sleep(1000);

            IWebElement Profile = m_driver.FindElement(By.XPath("./html/body/div/nav/div[2]/div[2]/ul/li[2]/a/i"));
            Profile.Click();
            System.Threading.Thread.Sleep(1000);
            IWebElement LogOut = m_driver.FindElement(By.XPath("./html/body/div/nav/div[2]/div[2]/ul/li[2]/ul/li[3]/a/span"));
            LogOut.Click();
            System.Threading.Thread.Sleep(1000);


           

        }
    }
}

