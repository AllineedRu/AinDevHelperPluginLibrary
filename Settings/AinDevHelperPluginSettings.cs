/*
   Copyright 2024 Allineed.Ru, Max Damascus

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
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
