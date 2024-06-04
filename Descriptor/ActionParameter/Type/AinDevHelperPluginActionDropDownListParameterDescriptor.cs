using System;
using System.Collections.Generic;
using AinDevHelperPluginLibrary.Descriptor.ActionParameter.Type;

namespace AinDevHelperPluginLibrary.Descriptor {
    [Serializable]
    public class AinDevHelperPluginActionDropDownListParameterDescriptor : AinDevHelperPluginActionParameterDescriptor {
        public AinDevHelperDropDownListValue SelectedValue { get; set; }
        public HashSet<AinDevHelperDropDownListValue> Values { get; set; } = new HashSet<AinDevHelperDropDownListValue>();

        //public string SelectedValue { get; set; }
        //public string SelectedValueName { get; set; }
        //public object SelectedValueObject { get; set; }

        //public HashSet<AinDevHelperDropDownListValue> Values { get; set; } = new HashSet<AinDevHelperDropDownListValue>();

        //public AinDevHelperPluginActionDropDownListParameterDescriptor(string name, string label) : this(name, label, "") {
        //}

        //public AinDevHelperPluginActionDropDownListParameterDescriptor(string name, string label, string description) : base(name, label, description) {
        //}
        public AinDevHelperPluginActionDropDownListParameterDescriptor() {

        }
    }
}
