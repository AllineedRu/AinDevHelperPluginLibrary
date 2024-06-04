using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Веб-ссылка" для плагина
    /// [EN] Describes the action handle of type "Web Link" for the plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginWebLinkActionDescriptor : AinDevHelperPluginActionDescriptor {
        /// <summary>
        /// [RU] Адрес Веб-ссылки (URL), по которой можно перейти при выполнении действия<br/>
        /// [EN] The address of the web link (URL) that can be followed when performing the action
        /// </summary>
        [XmlAttribute]
        public string WebLink { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginWebLinkActionDescriptor() {

        }
    }
}
