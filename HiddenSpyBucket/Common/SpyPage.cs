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
        [FindByClass("pod--feed")]
        public Text<SpyPage> SpyBucket { get; private set; }

    }
}
