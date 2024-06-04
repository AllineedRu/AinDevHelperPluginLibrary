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
    }
}
