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
