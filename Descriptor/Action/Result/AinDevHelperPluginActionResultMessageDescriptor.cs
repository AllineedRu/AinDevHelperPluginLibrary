using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Класс описывает результирующее сообщение от выполнения действия плагина. Сообщение может поддерживать параметры<br/>
    /// [EN] The class describes the resulting message from the execution of the plugin action. The message can support parameters
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginActionResultMessageDescriptor {
        public string Message { get; set; }
        public List<string> SubstitutionParameters { get; set; } = new List<string>();
    }
}
