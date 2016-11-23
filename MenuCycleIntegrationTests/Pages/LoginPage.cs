using MenuCycleIntegrationTests.Base;
using MenuCycleIntegrationTests.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;



namespace MenuCycleIntegrationTests.Pages
{
    class LoginPage : BasePage
    {

        //Objects for the Login page
       [FindsBy(How = How.XPath, Using = "//input[@id='txtUserName']")]
       IWebElement txtUsrName { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='txtPassword']")]
        public IWebElement txtPassWord { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#btnLogin")]
        IWebElement btnLogin { get; set; }

        
        public WelComePage login(string userName, string passWord)
        {

            Waits.waitForElementVisible(txtUsrName).SendKeys(userName);
            Waits.waitForElementVisible(txtPassWord).SendKeys(passWord);      
            //Waits.waitForElementVisible(txtUsrName).SendKeys(Keys.Tab);           
            //Waits.waitForElementVisible(txtPassWord).SendKeys(Keys.Enter);
            //Waits.waitForElementVisible(btnLogin).Submit();

            //Actions action = new Actions(DriverContext.Driver);
            //action.Click(btnLogin);
            //action.Perform();
            return GetInstance<WelComePage>();
        }




       


      

    }



}
