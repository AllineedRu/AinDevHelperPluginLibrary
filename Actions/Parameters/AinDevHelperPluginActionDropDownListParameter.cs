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
using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    public class AinDevHelperPluginActionDropDownListParameter : AinDevHelperPluginActionParameter {

        public AinDevHelperDropDownListValue SelectedValue { get; set; }
        public string SelectedValueName { get; set; }
        public object SelectedValueObject { get; set; }

        public HashSet<AinDevHelperDropDownListValue> Values { get; set; } = new HashSet<AinDevHelperDropDownListValue>();

        public AinDevHelperPluginActionDropDownListParameter(string name, string label) : this(name, label, "") {
        }

        public AinDevHelperPluginActionDropDownListParameter(string name, string label, string description) : base(name, label, description) {
        }
    }
}
