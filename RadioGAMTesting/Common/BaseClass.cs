using Atata;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.RadioGAMTesting.Common
{
    public class BaseClass
    {
        
        public virtual void Init(String size)
        {
            AtataContext.Configure().
                UseChrome().
                WithFixOfCommandExecutionDelay().
                WithLocalDriverPath().
                //WithArguments("start-maximized").
                //WithArguments("window-size=640,480").
                WithArguments(size).
                //UseBaseUrl("https://www.newstalkzb.co.nz").
                UseNUnitTestName().
                AddNUnitTestContextLogging().
                AddScreenshotFileSaving().
                LogNUnitError().
                TakeScreenshotOnNUnitError().
                Build();
        }

        //[TearDown]
        [OneTimeTearDown]
        public virtual void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }

    }
}
