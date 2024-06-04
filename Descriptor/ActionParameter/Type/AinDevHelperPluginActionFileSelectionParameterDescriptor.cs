using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    [Serializable]
    public class AinDevHelperPluginActionFileSelectionParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {
        [XmlAttribute]
        public string SelectedFile { get; set; }

        public AinDevHelperPluginActionFileSelectionParameterDescriptor() {

        }
    }
}
