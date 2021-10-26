using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using SeleniumDemo.PageObj;

namespace SeleniumDemo
{
    public class UnitTest1 : BasePage
    {

        OnlifeLogin onlife;

        public static void main()
        {

        }


        [SetUp]
        public void Setup()
        {
            Initialize();
            onlife = new OnlifeLogin(driver);

        }

        [Test]
        public void GetErrorMsgTest()
        {
           
        }
    }
}