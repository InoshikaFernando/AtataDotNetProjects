using AtataClassLNet.RadioGAMTesting.Common;
using NUnit.Framework;
using System;

namespace RadioGAMTesting    
{
    [TestFixture("https://www.newstalkzb.co.nz/", "window-size=638,1020", "small-only")]
    [TestFixture("https://www.newstalkzb.co.nz/", "window-size=1025,1020", "large-up")]
    //  [TestFixture("https://www.newstalkzb.co.nz/", "window-size=1300,1020", "large-only")]
    public class HomeTest : CommonTest
    {
        private string __url;
        private string _size;
        private string _resolution;
        public HomeTest(string url, string size, string resolution)
        {
            __url = url;
            _size = size;
            _resolution = resolution;
        }

        [SetUp]
        public void SetUp()
        {
            base.SetUp(__url, _size);
        }

        public override void TearDown()
        {
            base.TearDown();
        }

        [Test]
        /*
         * Step 1: Check data-mediaquery
         * Step 2: Check dfpad
         * Step 3: data-google-query-id
         * */
        public void TestDfpadCount()
        {
            var MediaqueryCount = base.MediaqueryCount(_resolution);
            var DfpadCount = base.DfpadCountCheck(_resolution);
            Assert.AreEqual(MediaqueryCount, DfpadCount);
            //base.GAMCountCheck(_resolution);
        }

    }
}
