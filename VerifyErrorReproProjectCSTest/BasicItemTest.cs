using System.Xml.Linq;
using VerifyErrorReproProjectCS;
using VerifyTests;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;


namespace VerifyErrorReproProjectCSTest
{
    public class BasicItemTest : VerifyBase
    {
        private VerifySettings Settings { get; set; }
        private ITestOutputHelper Output { get; set; }

        public BasicItemTest(ITestOutputHelper outputHelper) : base()
        {
            Output = outputHelper;
        }

        [Fact]
        public void TestOfBasicItem()
        {
            var obj = new BasicItem
            {
                Name = "TestItem",
                Type = 55
            };
            obj.Setting.Add(new XElement("TestItem"));
            Output.WriteLine("obj: " + obj.ToString());
            VerifyObject(obj);
        }
        private async void VerifyObject(object Item)
        {
            await Verify(Item, Settings);
        }
    }
}
