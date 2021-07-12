using System.Xml.Linq;
using VerifyErrorReproProjectCS;
using Xunit;
using Xunit.Abstractions;


namespace VerifyErrorReproProjectCSTest
{
    public class BasicItemTest
    {

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
        }
    }
}
