using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using RadioGAMTestingSelenium.CSVConfiguration;
using System;

namespace RadioGAMTestingSelenium
{
    class Program
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }
        [TestCaseSource(nameof(AdditionModels))]
        public void test()
        {
            driver.Url = "http://www.google.co.in";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

        public static TestCaseData[] AdditionModels =>
            CsvSource.Get<AdditionModel>("urlList.csv");

    }

    public class AdditionModel
    {
        public string url { get; set; }
    }
}
