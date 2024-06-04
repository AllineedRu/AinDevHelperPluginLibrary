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

namespace AinDevHelperPluginLibrary.IDE {
    /// <summary>
    /// [RU] Класс описывает конфигурацию AinDevHelper со списком избранных сред разработки<br/>
    /// [EN] The class describes the AinDevHelper configuration with a list of favourite development environments
    /// </summary>
    [Serializable]
    public class AinDevHelperFavouriteIDEsConfiguration {
        /// <summary>
        /// [RU] Список избранных сред разработки<br/>
        /// [EN] List of favourite integrates development environments (IDEs)
        /// </summary>
        public List<AinDevHelperFavouriteIDE> IDEs { get; set; } = new List<AinDevHelperFavouriteIDE>();

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperFavouriteIDEsConfiguration() {
        }
    }
}
