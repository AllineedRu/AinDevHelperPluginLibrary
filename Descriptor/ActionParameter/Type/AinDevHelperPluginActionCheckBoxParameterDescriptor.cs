using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    [Serializable]
    public class AinDevHelperPluginActionCheckBoxParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {
        [XmlAttribute]
        public bool Checked { get; set; }

        public AinDevHelperPluginActionCheckBoxParameterDescriptor() {

        }
    }
}
