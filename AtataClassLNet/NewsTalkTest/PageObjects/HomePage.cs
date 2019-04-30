using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;

namespace AtataClassLNet.NewsTalkTest
{
    [Url("")]
    [VerifyTitle]

    public class HomePage : Page<HomePage>
    {
        [FindByClass(TermMatch.EndsWith, "js-region-current")]
        public Text<HomePage> Region { get; private set; }

        /**
         * To change the drop box
         * If the drop box contain as an unordered list, can do as follows
         * assign all items to an unordered list (RgionList)
         * Create a class with variable name. Then,
         * homePage.RegionList.Items[x => x.Name == "Christchurch"].Click();
         */
        [FindById("region")]
        public UnorderedList<Regions, HomePage> RegionList { get; private set; }
        public class Regions : ListItem<HomePage>
        {
            public Text<HomePage> Name { get; private set; }

        }

        /**
         * To Get the count of adds
         * The tag name is "aside". If it is an add, it should contain "has-ad-note" class
         * AddNoteCount is a ControlList of all ads
         * */
        [ControlDefinition("aside", ContainingClass = "has-ad-note")]
        public ControlList<AddNoteItem, HomePage> AddNoteCount { get; private set; }
        public class AddNoteItem : Control<HomePage>
        {
            [FindByClass]
            public Number<HomePage> AddNoteCount { get; private set; }
        }

        

        

        //[FindByClass(TermMatch.Equals, "left-small")]
        //public Clickable<HomePage> Menu { get; private set; }
    }
}
