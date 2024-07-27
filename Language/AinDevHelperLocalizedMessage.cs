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
using System.Collections.Generic;

namespace AinDevHelperPluginLibrary.Language {
    /// <summary>
    /// [RU] Описывает локализованное сообщение в интерфейсе AinDevHelper. Это может быть названием действия плагина или сообщением от плагина<br/>
    /// [EN] Describes a localized message in the AinDevHelper interface. This can be the name of the plugin action or a message from the plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperLocalizedMessage {
        /// <summary>
        /// [RU] Код языка, в котором представлено локализованное сообщение<br/>
        /// [EN] Code of the language in which the localized message is presented
        /// </summary>
        public string LanguageCode { get; set; }

        /// <summary>
        /// [RU] Текст сообщения в соответствии с кодом языка для сообщения<br/>
        /// [EN] Message text according to the language code for the message
        /// </summary>
        public string Message { get; set; }

        public override bool Equals(object obj) {
            return obj is AinDevHelperLocalizedMessage message &&
                   LanguageCode == message.LanguageCode &&
                   Message == message.Message;
        }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperLocalizedMessage() {

        }

        public AinDevHelperLocalizedMessage(string languageCode, string message) {
            LanguageCode = languageCode;
            Message = message;
        }

        public override int GetHashCode() {
            int hashCode = -987561002;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LanguageCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            return hashCode;
        }

        public override string ToString() {
            if (LanguageCode != null && Message != null) {
                return $"[{LanguageCode}]:{Message}";
            } else if (LanguageCode != null && string.IsNullOrEmpty(Message)) {
                return $"[{LanguageCode}]";
            }
            return string.Empty;
        }
    }
}
