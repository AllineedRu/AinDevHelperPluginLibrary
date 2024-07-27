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
using System;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor.ActionParameter.Type {
    /// <summary>
    /// [RU] Класс описывает дескриптор параметра с типом "text" для действия плагина.
    /// [EN] The class represents a "text" type parameter descriptor for the plugin action.
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginActionTextParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {
        /// <summary>
        /// [RU] Значение текста в текстовом поле для параметра плагина
        /// [EN] Text value in the text field for a plugin parameter
        /// </summary>
        [XmlAttribute]
        public string Text { get; set; }

        public AinDevHelperPluginActionTextParameterDescriptor() {

        }

        //public override string ToString() {
        //    return $"{{Имя:{Name}, Метка:{Label}, Текст: {Text}}}";
        //}
    }
}
