

using Atata;
using AtataClassLNet.HiddenSpyBucket.Common;
using NUnit.Framework;

namespace HiddenSpyBucket.Tests
{
    [TestFixture("https://staging.thehits.co.nz/")]
    [TestFixture("https://staging.flava.co.nz/")]
    [TestFixture("https://staging.zmonline.com/")]
    class SpyTest : CommonTest        
{
        private string __url;
        public SpyTest(string url)
        {
            __url = url;
        }
        [SetUp]
        public void SetUp()
        {
            base.SetUp(__url);
            //AtataContext.Configure().UseBaseUrl("https://staging.flava.co.nz/spy");
        }

        public override void TearDown()
        {
            base.TearDown();
        }

        [Test]
        public void SpyCount()
        {
            base.AddCount();
        }

    }
}
