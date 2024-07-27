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
using AinDevHelperPluginLibrary.Descriptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions {
    public class AinDevHelperPluginGenerationAction : AinDevHelperPluginAction {
        public AinDevHelperPluginGenerationAction(AinDevHelperPluginGenerationActionDescriptor generationActionDescriptor) : base(generationActionDescriptor.Name, generationActionDescriptor.ID) {
            if (generationActionDescriptor.LocalizedNames != null && generationActionDescriptor.LocalizedNames.Count > 0) {
                foreach (var localizedName in generationActionDescriptor.LocalizedNames) {
                    AddLocalizedName(localizedName.LanguageCode, localizedName.Message);
                }
            }
            if (generationActionDescriptor.Tags != null && generationActionDescriptor.Tags.Count > 0) {
                foreach (string tag in generationActionDescriptor.Tags) {
                    Tags.Add(tag);
                }
            }
        }

        public AinDevHelperPluginGenerationAction(string name, string id) : base(name, id) {
        }
    }
}
