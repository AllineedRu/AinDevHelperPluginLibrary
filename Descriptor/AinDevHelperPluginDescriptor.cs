using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор плагина для AinDevHelper<br/>
    /// [EN] Describes the plugin descriptor for AinDevHelper
    /// </summary>    
    [Serializable]
    [XmlInclude(typeof(AinDevHelperPluginActionTextParameterDescriptor))]    
    [XmlInclude(typeof(AinDevHelperPluginActionCheckBoxParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionFileSelectionParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionDirectorySelectionParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionDropDownListParameterDescriptor))]
    

    //[XmlInclude(typeof(AinDevHelperPluginActionBoolParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginParameterizedActionDescriptor))]        
    [XmlInclude(typeof(AinDevHelperPluginNoParamsActionDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginWebLinkActionDescriptor))]
    [XmlInclude(typeof(AinDevHelperPerformedActionKindRunProcess))]
    public class AinDevHelperPluginDescriptor {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuthorSiteURL { get; set; }
        public string HelpFilePath { get; set; }
        public string PluginDirectory { get; set; }
        public bool HasHelpFile { get; set; }
        public int MajorVersion { get; set; }
        public int MinorVersion { get; set; }
        public int BuildVersion { get; set; }
        public int RevisionVersion { get; set; }
        public string Version { get; set; }

        public List<string> Tags { get; set; } = new List<string>();
        public List<string> SupportedLanguageCodes { get; set; } = new List<string>();

        public List<AinDevHelperPluginActionDescriptor> Actions { get; set; } = new List<AinDevHelperPluginActionDescriptor>();

        public AinDevHelperPluginDescriptor() {
        }
    }
}
