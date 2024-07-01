/*
Copyright 2024 Allineed.Ru, Max Damascus

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using AinDevHelperPluginLibrary.Settings.Controls;
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
    [XmlInclude(typeof(AinDevHelperSettingControlWithLabel))]    
    [XmlInclude(typeof(AinDevHelperSettingDirectorySelectionControl))]
    [XmlInclude(typeof(AinDevHelperSettingFileSelectionControl))]
    [XmlInclude(typeof(AinDevHelperSettingTextBoxControl))]
    [XmlInclude(typeof(AinDevHelperSettingCheckBoxControl))]
    [XmlInclude(typeof(AinDevHelperSettingRadioButtonGroupControl))]
    [XmlInclude(typeof(AinDevHelperRadioButtonElement))]    
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
        public IEnumerable<T> GetSettingControlsOfType<T>() where T : AinDevHelperSettingBaseControl {
            return SettingControls.OfType<T>();
        }

        /// <summary>
        /// Получить элемент управления по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public AinDevHelperSettingBaseControl GetControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }

            if (SettingControls.Any(control => name.Equals(control.Name))) {
                return SettingControls.First(control => name.Equals(control.Name));
            }

            return null;
        }

        public AinDevHelperSettingCheckBoxControl GetCheckBoxControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }
            if (SettingControls.Any(control => name.Equals(control.Name))) {
                AinDevHelperSettingBaseControl foundControl = SettingControls.First(control => name.Equals(control.Name));
                return foundControl is AinDevHelperSettingCheckBoxControl checkBoxControl ? checkBoxControl : null;
            }

            return null;
        }

        public AinDevHelperSettingFileSelectionControl GetFileSelectionControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }
            if (SettingControls.Any(control => name.Equals(control.Name))) {
                AinDevHelperSettingBaseControl foundControl = SettingControls.First(control => name.Equals(control.Name));
                return foundControl is AinDevHelperSettingFileSelectionControl fileSelectionControl ? fileSelectionControl : null;
            }

            return null;
        }

        public AinDevHelperSettingDirectorySelectionControl GetDirectorySelectionControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }
            if (SettingControls.Any(control => name.Equals(control.Name))) {
                AinDevHelperSettingBaseControl foundControl = SettingControls.First(control => name.Equals(control.Name));
                return foundControl is AinDevHelperSettingDirectorySelectionControl directorySelectionControl ? directorySelectionControl : null;
            }

            return null;
        }

        public AinDevHelperSettingTextBoxControl GetTextBoxControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }
            if (SettingControls.Any(control => name.Equals(control.Name))) {
                AinDevHelperSettingBaseControl foundControl = SettingControls.First(control => name.Equals(control.Name));
                return foundControl is AinDevHelperSettingTextBoxControl textBoxControl ? textBoxControl : null;
            }

            return null;
        }

        public AinDevHelperSettingRadioButtonGroupControl GetRadioButtonGroupControlByNameOrNull(string name) {
            if (name == null) {
                throw new ArgumentNullException("name", "Параметр не может быть равен null");
            }
            if (SettingControls.Any(control => name.Equals(control.Name))) {
                AinDevHelperSettingBaseControl foundControl = SettingControls.First(control => name.Equals(control.Name));
                return foundControl is AinDevHelperSettingRadioButtonGroupControl radioButtonGroupControl ? radioButtonGroupControl : null;
            }

            return null;
        }
    }
}
