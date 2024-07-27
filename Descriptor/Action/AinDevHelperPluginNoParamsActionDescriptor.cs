﻿/*
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
using AinDevHelperPluginLibrary.Descriptor.ActionKind;
using System;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор действия с типом "Действие без параметров" для плагина
    /// [EN] Describes an action descriptor with type "Parameterized action" for a plugin
    /// </summary>
    [Serializable]
    public class AinDevHelperPluginNoParamsActionDescriptor : AinDevHelperPluginActionDescriptor {
        public AinDevHelperPerformedActionKind PerformedActionKind { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperPluginNoParamsActionDescriptor() {

        }
    }
}
