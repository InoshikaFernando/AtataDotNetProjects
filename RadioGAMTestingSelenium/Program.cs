﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RadioGAMTestingSelenium.CSVConfiguration;
using System;
using System.Drawing;
using System.Linq;

namespace RadioGAMTestingSelenium
{
    [TestFixture(638,1020, "small-only")]
    [TestFixture(1025,1020, "large-up")]
    class Program : CommonTest
    {
        IWebDriver driver;
        private int _sizeW;
        private int _sizeH;
        private string _resolution;
        public Program(int sizeW, int sizeH, string resolution)
        {

            _sizeW = sizeW;
            _sizeH = sizeH;
            _resolution = resolution;
        }

        [OneTimeSetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
            driver.Manage().Window.Size = new Size(_sizeW, _sizeH);
        }

        [TestCaseSource(nameof(AdditionModels))]
        public void TestAddCount(AdditionModel model)
        {
            driver.Url = model.url;
            TestDfpadCount();
            TestDataGoogleQueryCount();
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        public static TestCaseData[] AdditionModels =>
            CsvSource.Get<AdditionModel>("urlList.csv");

        public void TestDfpadCount()
        {
            var MediaqueryCount = base.Mediaquery(_resolution, driver);
            var DfpadCount = base.DfpadCountCheck(_resolution, driver);
            Assert.AreEqual(MediaqueryCount, DfpadCount);
        }


        public void TestDataGoogleQueryCount()
        {
            var DfpadCount = base.DfpadCountCheck(_resolution, driver);
            var DGQadCount = base.DGQCountCheck(driver);
            Assert.AreEqual(DGQadCount, DfpadCount);
        }

    }

    public class AdditionModel
    {
        public string url { get; set; }
    }

    public class CommonTest 
    {
        int _mediaqueryCount = 0;

        /**
         * Step 1: Check data-mediaquery
         * sum of data-mediaquery with matching size or without size
         */
        public int Mediaquery(String _resolution, IWebDriver driver)
        {
            if (_resolution.Equals("large-up"))
            {
                _mediaqueryCount = driver.FindElements(By.XPath("//*[@data-mediaquery='large-up']")).Count();
            }
            else
            {
                _mediaqueryCount = driver.FindElements(By.XPath("//*[@data-mediaquery='small-only']")).Count();
            }
            _mediaqueryCount += driver.FindElements(By.XPath("//*[@data-mediaquery='']")).Count();
            return _mediaqueryCount;
        }

        /**
         * Step 2: Check dfpad count with data-mediaquery count
         */
        public int DfpadCountCheck(String _resolution, IWebDriver driver)
        {
            return driver.FindElements(By.ClassName("dfpad")).Count();
        }

        /**
         * Step 3: data-google-query-id
         */
        public int DGQCountCheck(IWebDriver driver)
        {
            return driver.FindElements(By.XPath("//*[@data-google-query-id]")).Count();
        }
    }
}
