using System;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Действие без параметров" для плагина
    /// [EN] Describes an action descriptor with type "Parameterized action" for a plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginNoParamsActionDescriptor : AinDevHelperPluginActionDescriptor {
        public AinDevHelperPerformedActionKind PerformedActionKind { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginNoParamsActionDescriptor() {

        }
    }
}
