using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;

namespace AtataClassLNet.HiddenSpyBucket.Common
{
    [Url("spy")]
    

    public class SpyPage : Page<SpyPage>
    {
        
        /**
         * To make sure that spy bucket had removed
         * The tag name is "section". and class name is "pod--feed"
         * SpyBucketCount is a ControlList for spybucket
         * */
        
        public ControlList<SpyBucketItem, SpyPage> SpyBucketCount { get; private set; }

        [ControlDefinition("section", ContainingClass = "pod--feed")]
        public class SpyBucketItem : Control<SpyPage>
        {
            public Text<SpyPage> SpyBucket { get; private set; }
        }

    }
}
