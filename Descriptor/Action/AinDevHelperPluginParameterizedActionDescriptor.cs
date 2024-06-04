﻿/*
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

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Действие с параметрами" для плагина
    /// [EN] Describes an action descriptor with type "Parameterized action" for a plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginParameterizedActionDescriptor : AinDevHelperPluginActionDescriptor {
        /// <summary>
        /// [RU] Список параметров действия<br/>
        /// [EN] List of action parameters
        /// </summary>
        public List<AinDevHelperPluginActionParameterDescriptor> ActionParameters { get; set; } = new List<AinDevHelperPluginActionParameterDescriptor>();

        /// <summary>
        /// [RU] Тип выполняемого действия<br/>
        /// [EN] Kind of action performed
        /// </summary>
        public AinDevHelperPerformedActionKind PerformedActionKind { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginParameterizedActionDescriptor() {

        }
    }
}
