using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    public class AinDevHelperPluginActionDirectorySelectionParameter : AinDevHelperPluginActionParameter {

        public string SelectedDirectory { get; set; }

        public string RelatedTextBoxName { get; set; }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label) : this(name, label, "") {
        }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label, string description) : this(name, label, description, "") {
        }

        public AinDevHelperPluginActionDirectorySelectionParameter(string name, string label, string description, string selectedDirectory) : base(name, label, description) {
            SelectedDirectory = selectedDirectory;
        }
    }
}
