using System.Xml.Linq;
using VerifyErrorReproProjectCS;
using VerifyTests;
using VerifyXunit;
using Xunit;
using Xunit.Abstractions;


namespace VerifyErrorReproProjectCSTest
{
    /// <summary>
    /// Test of a Basic Item
    /// </summary>
    ///// <seealso cref="VerifyBase" />
    public class BasicItemTest : VerifyBase
    {
        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        private VerifySettings Settings { get; set; }
        /// <summary>
        /// Gets or sets the output.
        /// </summary>
        /// <value>
        /// The output.
        /// </value>
        private ITestOutputHelper Output { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicItemTest"/> class.
        /// </summary>
        /// <param name="outputHelper">The output helper.</param>
        public BasicItemTest(ITestOutputHelper outputHelper) : base()
        {
            Output = outputHelper;
        }

        /// <summary>
        /// Tests the of basic item.
        /// </summary>
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

        /// <summary>
        /// Verifies the object.
        /// </summary>
        /// <param name="Item">The item.</param>
        private async void VerifyObject(object Item)
        {
            await Verify(Item, Settings);
        }
    }
}
