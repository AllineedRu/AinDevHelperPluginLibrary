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
