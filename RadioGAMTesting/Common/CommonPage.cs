using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;

namespace AtataClassLNet.RadioGAMTesting.Common
{
    /**
         * use `ts-creative` to find all the possible ads that are to display
         * Then for each element look at the data attribute `data-mediaquery`
         * If nothing has been set, then it should show now matter what the screen size
         * otherwise `large-up` will only show for desktop (depending on screen size)
         * and `small-only` will only show for mobile (depending on screen size)
         * If an ad is suitable to show for the screen size, the class `dfpad` will be added to the element
         * And then the ad script will find all ad placements with `dfpad` and convert them into an ad and update the element with a new data attribute called `data-google-query-id`
         * The current testing script we have for GAM is found here
         * https://bitbucket.org/grabone/radio-gam-testing/src/master/
         * Step 1: Check data-mediaquery
         * Step 2: Check dfpad
         * Step 3: data-google-query-id
         **/
    public class CommonPage : Page<CommonPage>
    {

        /**
         * Step 1: Check data-mediaquery
         * */
        
        [ControlDefinition("aside")]
        public class MediaqueryLarge : Control<CommonPage>
        {
            [FindByAttribute("data-mediaquery", new string[] { "", "large-up" })]
            public PageObject<CommonPage> MediaqueryItem { get; private set; }
        }

        [ControlDefinition("aside")]
        public class MediaquerySmall : Control<CommonPage>
        {
            [FindByAttribute("data-mediaquery", new string[] { "", "small-only" })]
            public PageObject<CommonPage> MediaqueryItem { get; private set; }
        }

        public ControlList<MediaqueryLarge, CommonPage> MediaqueryLargeList { get; private set; }
        public ControlList<MediaquerySmall, CommonPage> MediaquerySmallList { get; private set; }


        /**
         * Check dfpad
         */

        public ControlList<DfpadItem, CommonPage> DfpadList { get; private set; }

        [ControlDefinition("div", ContainingClass = "dfpad")]
        public class DfpadItem : Control<CommonPage>
        {
            public Text<CommonPage> Dfpad { get; private set; }
        }

        /**
         * Check data-google-query-id
         */
        [ControlDefinition("aside")]
        public class DGQ:Control<CommonPage>
        {
            [FindByAttribute("data-google-query-id")]
            public PageObject<CommonPage> DGQItem { get; private set; }
        }

        public ControlList<DGQ, CommonPage> DGQItemList { get; private set; }

    }
}
