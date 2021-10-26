using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.Database;
using SeleniumExtras.PageObjects;

namespace SeleniumDemo.PageObj
{
    class OnlifeLogin : BasePage
    {
        public OnlifeLogin(IWebDriver driver)
        {
            OnlifeLogin.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "login-signin")]

        private IWebElement Next;

        [FindsBy(How = How.Id, Using = "//p[@class='error-msg']")]

        private IWebElement Error;

        public string GetSignInErrorMsg()
        {
            Next.Click();
            Thread.Sleep(2000);
            String ErrorMsg = Error.Text;
            return ErrorMsg;
        }

      

    }
}