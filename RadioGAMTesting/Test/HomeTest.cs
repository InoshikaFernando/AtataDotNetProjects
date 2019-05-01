using AtataClassLNet.RadioGAMTesting.Common;
using NUnit.Framework;
using System;

namespace RadioGAMTesting    
{
    [TestFixture("https://www.newstalkzb.co.nz/", "window-size=640,480")]
    [TestFixture("https://www.newstalkzb.co.nz/", "start-maximized")]
    public class HomeTest : CommonTest
    {
        private string __url;
        private string _size;
        public HomeTest(string url, string size)
        {
            __url = url;
            _size = size;
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
        public void GAMCount()
        {
            base.GAMCount();
        }

    }
}
