using System.Xml.Linq;

namespace VerifyErrorReproProjectCS
{
    /// <summary>
    /// Basic Item
    /// </summary>
    public class BasicItem
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="BasicItem"/> class.
        /// </summary>
        public BasicItem()
        {
            Name = string.Empty;
            Type = 0;
            Setting = new XElement("root");
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>
        /// The type.
        /// </value>
        public int Type { get; set; }
        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>
        /// The setting.
        /// </value>
        public XElement Setting { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return $"Name = \"{Name}\", Type = {Type}, Setting = {Setting}";
        }
    }
}
