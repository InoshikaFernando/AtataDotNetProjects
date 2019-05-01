using Atata;
//using AtataClassLNet.Common;
using AtataClassLNet.RadioGAMTesting.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.RadioGAMTesting.Common
{
    public class CommonTest : BaseClass
    {
        
        public override void SetUp(String url, String size)
        {
            base.SetUp(url, size);
        }


        public override void TearDown()
        {
            base.TearDown();
        }

        public void GAMCount()
        {
            var CommonPage = Go.To<CommonPage>();
           // spyPage.SpyBucketCount.Count.Should.Equal(0);

        }
    }
}
