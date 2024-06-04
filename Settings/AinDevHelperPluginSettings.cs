using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// Описывает настройки плагина
    /// </summary>
    [Serializable]
    [XmlInclude(typeof(AinDevHelperSettingBaseControl))]
    [XmlInclude(typeof(AinDevHelperSettingTextBoxControl))]
    [XmlInclude(typeof(AinDevHelperSettingCheckBoxesControl))]
    [XmlInclude(typeof(AinDevHelperSettingRadioButtonsControl))]
    [XmlInclude(typeof(AinDevHelperSettingRadioButtonGroup))]    
    public class AinDevHelperPluginSettings {
        /// <summary>
        /// Список элементов управления, которые будут отображаться на странице настроек плагина
        /// </summary>
        public List<AinDevHelperSettingBaseControl> SettingControls { get; set; } = new List<AinDevHelperSettingBaseControl>();

        /// <summary>
        /// Добавить новые элемент управления ко всем настройкам плагина
        /// </summary>
        /// <param name="settingControl"></param>
        public void AddSettingControl(AinDevHelperSettingBaseControl settingControl) {
            SettingControls.Add(settingControl);
        }

        /// <summary>
        /// Получить элементы управления заданного типа
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type"></param>
        /// <returns></returns>
        public IEnumerable<T> GetSettingControlsOfType<T>(T type) where T : AinDevHelperSettingBaseControl {
            return SettingControls.OfType<T>();
        }

        /// <summary>
        /// Получить элемент управления по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public IAinDevHelperSettingControl GetControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }

            if (SettingControls.Any(control => name.Equals(control.Name))) {
                return SettingControls.First(control => name.Equals(control.Name));
            }

            return null;
        }        
    }
}
