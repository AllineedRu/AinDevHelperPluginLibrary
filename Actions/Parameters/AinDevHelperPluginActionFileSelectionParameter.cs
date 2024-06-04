using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    public class AinDevHelperPluginActionFileSelectionParameter : AinDevHelperPluginActionParameter {
        public string SelectedFile { get; set; }

        public string RelatedTextBoxName { get; set; }

        public AinDevHelperPluginActionFileSelectionParameter(string name, string label) : this(name, label, "") {
        }

        public AinDevHelperPluginActionFileSelectionParameter(string name, string label, string description) : base(name, label, description) {
        }
    }
}
