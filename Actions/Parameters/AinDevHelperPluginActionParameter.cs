using System.Collections.Generic;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    /// <summary>
    /// [RU] Представляет собой базовый класс для параметров, используемых в параметризированных действиях плагина<br/>
    /// [EN] Represents the base class for parameters used in parameterized plugin actions
    /// </summary>
    public abstract class AinDevHelperPluginActionParameter {
        /// <summary>
        /// [RU] Имя параметра. Это внутреннее имя параметра, который плагин будет использоваться в своей реализации<br/>
        /// [EN] Parameter name. This is the internal name of the parameter that the plugin will use in its implementation
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Метка для параметра (выводится на форме для параметра при вызове действия)<br/>
        /// [EN] Label for the parameter (displayed on the form for the parameter when the action is called)
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// [RU] Описание параметра<br/>
        /// [EN] Parameter description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// [RU] Локализованные тексты для метки плагина на форме<br/>
        /// [EN] Localized texts for the plugin label on the form
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedLabels { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Локализованные описания для параметра плагина<br/>
        /// [EN] Localized descriptions for a plugin parameter
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedDescriptions { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginActionParameter() {

        }

        public AinDevHelperPluginActionParameter(string name, string label) : this(name, label, "") {            
        }

        public AinDevHelperPluginActionParameter(string name, string label, string description) {
            Name = name;
            Label = label;
            Description = description;
        }
    }
}
