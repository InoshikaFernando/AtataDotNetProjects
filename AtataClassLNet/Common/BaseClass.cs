using Atata;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.Common
{
    public class BaseClass
    {
        //[OneTimeSetUp]
        //public void GlobalSetUp()
        //{
        //    AtataContext.GlobalConfiguration.
        //        UseChrome().
        //            WithArguments("start-maximized", "disable-extensions").
        //       // UseInternetExplorer().
        //        // TODO: Specify Internet Explorer settings, like:
        //        // WithOptions(x => x.EnableNativeEvents = true).
        //        //UseFirefox().
        //        // TODO: You can also specify remote driver configuration(s):
        //        // UseRemoteDriver().
        //        // WithAlias("chrome_remote").
        //        // WithRemoteAddress("http://127.0.0.1:4444/wd/hub").
        //        // WithOptions(new ChromeOptions()).
        //        //UseBaseUrl("https://demo.atata.io/").
        //        AddNUnitTestContextLogging().
        //        LogNUnitError();
        //}

        [SetUp]
        public virtual  void SetUp()
        {
            AtataContext.Configure().
                UseChrome().WithArguments("start-maximized").
                UseBaseUrl("https://www.newstalkzb.co.nz/").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                AddScreenshotFileSaving().
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build()
                ;
        }

        [TearDown]
        public virtual void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

        public void testMethod()
        {

        }
    }
}
