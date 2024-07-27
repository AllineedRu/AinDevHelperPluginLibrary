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

namespace AinDevHelperPluginLibrary.Settings.Controls {
    [Serializable]
    public abstract class AinDevHelperSettingBaseControl {
        public string Name { get; set; }
        public int OffsetLeft { get; set; } = 10;
        public int OffsetTop { get; set; }
        public int Width { get; set; } = 550;
        public int Height { get; set; }

        public AinDevHelperSettingBaseControl() {
        }

        public AinDevHelperSettingBaseControl(string name) { 
            Name = name;
        }
    }
}
