using System;
using System.Collections.Generic;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Действие с параметрами" для плагина
    /// [EN] Describes an action descriptor with type "Parameterized action" for a plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginParameterizedActionDescriptor : AinDevHelperPluginActionDescriptor {
        /// <summary>
        /// [RU] Список параметров действия<br/>
        /// [EN] List of action parameters
        /// </summary>
        public List<AinDevHelperPluginActionParameterDescriptor> ActionParameters { get; set; } = new List<AinDevHelperPluginActionParameterDescriptor>();

        /// <summary>
        /// [RU] Тип выполняемого действия<br/>
        /// [EN] Kind of action performed
        /// </summary>
        public AinDevHelperPerformedActionKind PerformedActionKind { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginParameterizedActionDescriptor() {

        }
    }
}
