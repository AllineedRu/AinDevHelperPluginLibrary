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
namespace AinDevHelperPluginLibrary.Language {
    /// <summary>
    /// [RU] Класс содержит список констант для обозначения кодов языков, поддерживаемых AinDevHelper официально. 
    /// Пользователи AinDevHelper могут добавлять и свои языки, т.е. величина данного списка констант не означает, 
    /// что это единственные языки, которые способен поддержать AinDevHelper<br/>
    /// [EN] The class contains a list of constants to denote language codes that are officially supported by AinDevHelper. 
    /// AinDevHelper users can add their own languages, i.e. The size of this list of constants does not mean 
    /// that these are the only languages that AinDevHelper can support
    /// </summary>
    public static class AinDevHelperLanguageCodeConstants {
        /// <summary>
        /// [RU] Код русского языка
        /// [EN] Russian language code
        /// </summary>
        public static readonly string RU = "ru";

        /// <summary>
        /// [RU] Код английского языка
        /// [EN] English language code
        /// </summary>
        public static readonly string EN = "en";

        /// <summary>
        /// [RU] Код немецкого языка
        /// [EN] German language code
        /// </summary>
        public static readonly string DE = "de";
    }
}
