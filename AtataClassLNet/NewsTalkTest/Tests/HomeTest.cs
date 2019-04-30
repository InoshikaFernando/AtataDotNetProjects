using Atata;
using AtataClassLNet.Common;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtataClassLNet.NewsTalkTest
{

    [TestFixture]
    public class HomeTest : BaseClass
    {
       
        public override void SetUp()
        {
            base.SetUp();
        }

        
        public override void TearDown()
        {
            base.TearDown();
        }

        //[Test]
        //public void MenuClick()
        //{
        //    var Test = Go.To<HomePage>().
        //    Menu.DoubleClick();
        //    Console.Write(Test);
        //}


        [Test]
        public void RegionChange()
        {
            var homePage = Go.To<HomePage>();
            homePage.Region.Click().RegionList.Items.Count.Should.Equal(3);
            homePage.RegionList.Items[x => x.Name == "Christchurch"].Click();
            Assert.AreEqual("Christchurch", homePage.Region.Value);
            Console.Write("Done");
        }

        [Test]
        public void AddCount()
        {
            var homepage = Go.To<HomePage>();
            homepage.AddNoteCount.Count.Should.Equal(3);

        }
    }
}
