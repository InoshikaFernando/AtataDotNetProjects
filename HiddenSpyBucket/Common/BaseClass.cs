using Atata;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.HiddenSpyBucket.Common
{
    public class BaseClass
    {
        
        public virtual void SetUp(String url)
        {
            AtataContext.Configure().
                UseChrome().WithArguments("start-maximized").
                UseBaseUrl(url).
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
