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
using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Класс описывает результирующее сообщение от выполнения действия плагина. Сообщение может поддерживать параметры подстановки<br/>
    /// [EN] The class describes the resulting message from the execution of the plugin action. The message can support substitution parameters
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginActionResultMessageDescriptor {
        public string Message { get; set; }

        public HashSet<AinDevHelperLocalizedMessage> LocalizedMessages { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        public List<string> SubstitutionParameters { get; set; } = new List<string>();
    }
}
