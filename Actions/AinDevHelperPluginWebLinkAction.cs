using AinDevHelperPluginLibrary.Descriptor;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions {
    public class AinDevHelperPluginWebLinkAction : AinDevHelperPluginAction {
        public string WebLink { get; set; }
        public AinDevHelperPluginWebLinkAction(string name, string id) : base(name, id) {
        }

        public AinDevHelperPluginWebLinkAction(string name, string id, string webLink) : base(name, id) {
            WebLink = webLink;
        }

        public AinDevHelperPluginWebLinkAction(AinDevHelperPluginWebLinkActionDescriptor webLinkActionDescriptor) : this(webLinkActionDescriptor.Name, webLinkActionDescriptor.ID, webLinkActionDescriptor.WebLink) {
            if (webLinkActionDescriptor.LocalizedNames != null && webLinkActionDescriptor.LocalizedNames.Count > 0) {
                foreach (var localizedName in webLinkActionDescriptor.LocalizedNames) {
                    AddLocalizedName(localizedName.LanguageCode, localizedName.Message);
                }
            }
            if (webLinkActionDescriptor.Tags != null && webLinkActionDescriptor.Tags.Count > 0) {
                foreach (string tag in webLinkActionDescriptor.Tags) {
                    Tags.Add(tag);
                }
            }
        }

        public bool Navigate() {
            if (!string.IsNullOrEmpty(WebLink)) {
                Process.Start(WebLink);
                return true;
            }
            return false;
        }
    }
}
