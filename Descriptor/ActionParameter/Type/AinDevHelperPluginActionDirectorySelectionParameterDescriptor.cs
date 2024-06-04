using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    [Serializable]
    public class AinDevHelperPluginActionDirectorySelectionParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {

        [XmlAttribute]
        public string SelectedDirectory { get; set; }

        public AinDevHelperPluginActionDirectorySelectionParameterDescriptor() {

        }
    }
}
