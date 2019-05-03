using Atata;
using AtataClassLNet.RadioGAMTesting.Common;
using NUnit.Framework;
using RadioGAMTesting.CSVConfiguration;
using System;

namespace RadioGAMTesting    
{
    [TestFixture("window-size=638,1020", "small-only")]
    [TestFixture("window-size=1025,1020", "large-up")]
    public class HomeTest : CommonTest
    {
        private string _size;
        private string _resolution;
        public HomeTest(string size, string resolution)
        {
            
            _size = size;
            _resolution = resolution;
        }

        [OneTimeSetUp]
        public void Init()
        {
            base.Init(_size);
        }
        /**
        [TestCase("http://staging.hokonui.co.nz/")]
        [TestCase("http://staging.hokonui.co.nz/shows/")]
        [TestCase("http://staging.hokonui.co.nz/shows/breakfast-southland-with-luke-howden/")]
        [TestCase("http://staging.hokonui.co.nz/win/")]
        [TestCase("http://staging.hokonui.co.nz/win/subway-shout-southland/")]
        [TestCase("https://www.newstalkzb.co.nz/")]
    */
        public static TestCaseData[] AdditionModels =>
            CsvSource.Get<AdditionModel>("urlList.csv");

        [TestCaseSource(nameof(AdditionModels))]
        public void TestAddCount(AdditionModel model)
        {
            Go.ToUrl(model.url);
            TestDfpadCount();
            TestDataGoogleQueryCount();
        }

        [OneTimeTearDown]
        public override void TearDown()
        {
            base.TearDown();
        }

        
        public void TestDfpadCount()
        {
            var MediaqueryCount = base.MediaqueryCount(_resolution);
            var DfpadCount = base.DfpadCountCheck(_resolution);
            Assert.AreEqual(MediaqueryCount, DfpadCount);
        }

       
        public void TestDataGoogleQueryCount()
        {
            var DfpadCount = base.DfpadCountCheck(_resolution);
            var DGQadCount = base.DGQCountCheck();
            Assert.AreEqual(DGQadCount, DfpadCount);
        }

    }

    public class AdditionModel
    {
        public string url { get; set; }
    }
}
