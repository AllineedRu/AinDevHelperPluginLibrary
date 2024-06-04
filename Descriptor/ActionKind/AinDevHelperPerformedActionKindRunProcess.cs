using System.Collections.Generic;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    public class AinDevHelperPerformedActionKindRunProcess : AinDevHelperPerformedActionKind {
        //[XmlAttribute]
        public string Command { get; set; }

        //[XmlAttribute]
        public string Arguments { get; set; }

        [XmlAttribute]
        public bool ShowProcessWindow { get; set; }

        [XmlAttribute]
        public bool RedirectToFile { get; set; }
        
        [XmlAttribute]
        public string RedirectToFileName { get; set; }


        [XmlAttribute]
        public string WorkingDirectory { get; set; }

        public List<string> SubstitutionParameters { get; set; } = new List<string>();



        public AinDevHelperPerformedActionKindRunProcess() : base() {
        }
    }
}
