using Atata;
//using AtataClassLNet.Common;
using AtataClassLNet.HiddenSpyBucket.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.HiddenSpyBucket.Common
{
    public class CommonTest : BaseClass
    {

        public override void SetUp(String url)
        {
            base.SetUp(url);
        }


        public override void TearDown()
        {
            base.TearDown();
        }

        public void SpyBucketExist()
        {
            var spyPage = Go.To<SpyPage>();
            spyPage.SpyBucket.Should.Not.Exist();
        }
    }
}
