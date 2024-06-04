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
