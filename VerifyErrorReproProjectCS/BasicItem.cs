using System.Xml.Linq;

namespace VerifyErrorReproProjectCS
{
    public class BasicItem
    {

        public BasicItem()
        {
            Name = string.Empty;
            Type = 0;
            Setting = new XElement("root");
        }

        public string Name { get; set; }
        public int Type { get; set; }
        public XElement Setting { get; set; }

        public override string ToString()
        {
            return $"Name = \"{Name}\", Type = {Type}, Setting = {Setting}";
        }
    }
}
