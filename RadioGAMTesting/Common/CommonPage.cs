using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atata;

namespace AtataClassLNet.RadioGAMTesting.Common
{
    public class CommonPage : Page<CommonPage>
    {
        
        /**
         * 
         * */
        
        public ControlList<GAMItem, CommonPage> GAMList { get; private set; }

        [ControlDefinition("section", ContainingClass = "pod--feed")]
        public class GAMItem : Control<CommonPage>
        {
            public Text<CommonPage> GAM { get; private set; }
        }

    }
}
