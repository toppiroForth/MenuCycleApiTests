using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuCycleIntegrationTests.Base
{
    public abstract class BasePage : Base
    {


      

        public BasePage()
        {
            PageFactory.InitElements(DriverContext.Driver, this);

        }




    }
}