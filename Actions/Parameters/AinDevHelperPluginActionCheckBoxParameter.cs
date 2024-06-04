using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    public class AinDevHelperPluginActionCheckBoxParameter : AinDevHelperPluginActionParameter {        
        public bool Checked { get; set; }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label) : this(name, label, "", false) {
        }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label, string description) : this(name, label, description, false) {
        }

        public AinDevHelperPluginActionCheckBoxParameter(string name, string label, string description, bool isInitiallyChecked) : base(name, label, description) {
            Checked = isInitiallyChecked;
        }
    }
}
