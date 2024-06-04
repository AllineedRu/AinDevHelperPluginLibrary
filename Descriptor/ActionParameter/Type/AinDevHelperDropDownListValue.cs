using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor.ActionParameter.Type {
    [Serializable]
    [XmlInclude(typeof(AinDevHelperDropDownListStringValue))]
    [XmlInclude(typeof(AinDevHelperDropDownListIntegerValue))]    
    public abstract class AinDevHelperDropDownListValue {
        public string Name { get; set; }
    }
}
