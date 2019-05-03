using Atata;
using AtataClassLNet.RadioGAMTesting.Common;
using NUnit.Framework;
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

        [TestCase("https://www.hauraki.co.nz")]
        [TestCase("https://www.newstalkzb.co.nz/")]
        public void TestAddCount(string url)
        {
            Go.ToUrl(url);
            TestDfpadCount();
            TestDataGoogleQueryCount();
        }

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
}
