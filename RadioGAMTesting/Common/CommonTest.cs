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
        int _mediaqueryCount = 0;
        
        public override void Init(String size)
        {
            base.Init(size);
        }


        public override void TearDown()
        {
            base.TearDown();
        }

        /**
         * Step 1: Check data-mediaquery
         * sum of data-mediaquery with matching size or without size
         */
         public int MediaqueryCount (String _resolution)
         {
            var CommonPage = Go.To<CommonPage>();
            if (_resolution.Equals("large-up"))
            {

                _mediaqueryCount=  CommonPage.MediaqueryLargeList.Count();
            }
            else
            {
                _mediaqueryCount = CommonPage.MediaquerySmallList.Count();
            }
            return _mediaqueryCount;
         }

        /**
         * Step 2: Check dfpad count with data-mediaquery count
         */
        public int DfpadCountCheck(String _resolution)
        {
            var CommonPage = Go.To<CommonPage>();
            return CommonPage.DfpadList.Count();


        }

        /**
         * Step 3: data-google-query-id
         */
         public int DGQCountCheck()
        {
            var CommonPage = Go.To<CommonPage>();
            return CommonPage.DGQItemList.Count();

            Go.ToUrl("");
        }
    }
}
