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
