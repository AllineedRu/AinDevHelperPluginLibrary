using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Settings.Controls {
    /// <summary>
    /// [RU] Класс описывает элемент управления в настройках плагина в виде выбора файла на диске<br/>
    /// [EN] The class describes a control in the plugin settings in the form of selecting a file on disk
    /// </summary>
    [Serializable]
    public class AinDevHelperSettingFileSelectionControl : AinDevHelperSettingControlWithLabel {
        //[XmlAttribute]
        /// <summary>
        /// [RU] Выбранный пользователем файл в элементе управления в настройках плагина<br/>
        /// [EN] User-selected file in a control in the plugin settings
        /// </summary>
        public string SelectedFile { get; set; }

        /// <summary>
        /// [RU] Является ли текстовое поле, куда подставляется путь к выбранному файлу, неизменяемым (только для чтения)<br/>
        /// [EN] Whether the text field where the path to the selected file is inserted is immutable (read-only)
        /// </summary>
        public bool IsReadOnly { get; set; } = true;

        /// <summary>
        /// [RU] Название связанного текстового поля. Инициализируется AinDevHelper, не предполагается использование этого свойства плагином<br/>
        /// [EN] The name of the associated text field. Initialized by AinDevHelper, the plugin is not expected to use this property
        /// </summary>
        public string RelatedTextBoxName { get; set; }

        public AinDevHelperSettingFileSelectionControl() {

        }

        public AinDevHelperSettingFileSelectionControl(string name, string label) : this(name, label, null) {
        }

        public AinDevHelperSettingFileSelectionControl(string name, string label, string selectedFile) : base(name, label) {
            SelectedFile = selectedFile;
        }       
    }
}
