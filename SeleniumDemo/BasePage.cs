using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo
{


   public class BasePage
    {

        public static IWebDriver driver = new ChromeDriver();
        private readonly string GetUrl;

        public void Initialize()
        {
           driver.Url = "https://login.onlifehealth.com/Home/Login/?ReturnUrl=%2F";
        }

        public void TearDown()
        {
            driver.Close();
        }
    }
}
