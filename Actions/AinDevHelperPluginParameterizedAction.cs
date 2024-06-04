using AinDevHelperPluginLibrary.Descriptor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AinDevHelperPluginLibrary.Actions.Parameters;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary.Actions {
    public class AinDevHelperPluginParameterizedAction : AinDevHelperPluginAction {
        public List<AinDevHelperPluginActionParameter> Parameters { get; set; } = new List<AinDevHelperPluginActionParameter>();

        public AinDevHelperPluginParameterizedAction(string name, string id) : base(name, id) {
        }

        public AinDevHelperPluginParameterizedAction(AinDevHelperPluginParameterizedActionDescriptor parameterizedActionDescriptor) : this(parameterizedActionDescriptor.Name, parameterizedActionDescriptor.ID) {
            if (parameterizedActionDescriptor.ActionParameters != null && parameterizedActionDescriptor.ActionParameters.Count > 0) {
                foreach (AinDevHelperPluginActionParameterDescriptor actionParameterDescriptor in parameterizedActionDescriptor.ActionParameters) {
                    if (actionParameterDescriptor is AinDevHelperPluginActionTextParameterDescriptor actionTextParameterDescriptor) {
                        AddTextParameter(
                            actionTextParameterDescriptor.Name, 
                            actionTextParameterDescriptor.Label, 
                            actionTextParameterDescriptor.Description, 
                            actionTextParameterDescriptor.Text
                        );
                    } else if (actionParameterDescriptor is AinDevHelperPluginActionCheckBoxParameterDescriptor actionCheckBoxParameterDescriptor) {
                        AddCheckBoxParameter(
                            actionCheckBoxParameterDescriptor.Name,
                            actionCheckBoxParameterDescriptor.Label,
                            actionCheckBoxParameterDescriptor.Description,
                            actionCheckBoxParameterDescriptor.Checked
                        );
                    } else if (actionParameterDescriptor is AinDevHelperPluginActionDirectorySelectionParameterDescriptor actionDirectorySelectionParameterDescriptor) {
                        AddDirectorySelectionParameter(
                            actionDirectorySelectionParameterDescriptor.Name, 
                            actionDirectorySelectionParameterDescriptor.Label, 
                            actionDirectorySelectionParameterDescriptor.Description
                        );
                    } else if (actionParameterDescriptor is AinDevHelperPluginActionFileSelectionParameterDescriptor actionFileSelectionParameterDescriptor) {
                        AddFileSelectionParameter(
                            actionFileSelectionParameterDescriptor.Name,
                            actionFileSelectionParameterDescriptor.Label,
                            actionFileSelectionParameterDescriptor.Description
                        );
                    }
                    //else if (actionParameterDescriptor is AinDevHelperPluginActionBoolParameterDescriptor boolParameterDescriptor) {
                    //    //TODO: избавиться от этой развилки
                    //    AddBoolParameter(
                    //        boolParameterDescriptor.Name, 
                    //        boolParameterDescriptor.Label, 
                    //        boolParameterDescriptor.Description, 
                    //        boolParameterDescriptor.Value
                    //    );
                    //}
                }
            }
            if (parameterizedActionDescriptor.LocalizedNames != null && parameterizedActionDescriptor.LocalizedNames.Count > 0) {
                foreach (var localizedName in parameterizedActionDescriptor.LocalizedNames) {
                    AddLocalizedName(localizedName.LanguageCode, localizedName.Message);
                }
            }
            if (parameterizedActionDescriptor.Tags != null && parameterizedActionDescriptor.Tags.Count > 0) {
                foreach (string tag in parameterizedActionDescriptor.Tags) {
                    Tags.Add(tag);
                }
            }
        }

        //public void AddBoolParameter(string name, string label, string description, bool initialValue) {
        //    Parameters.Add(new AinDevHelperPluginActionBoolParameter(name, label, description, initialValue));
        //}

        public void AddTextParameter(string name, string label, string description, string initialText = "") {
            AddTextParameter(name, label, description, initialText, null);
        }

        public void AddTextParameter(string name, string label, string description, string initialText = "", params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AinDevHelperPluginActionTextParameter textParameter = new AinDevHelperPluginActionTextParameter(name, label, description, initialText);
            EnrichActionParameterWithLocalizeParams(textParameter, localizeParams);
            //if (localizeParams != null && localizeParams.Length > 0) {
            //    foreach ((string langCode, string locLabel, string locDescription) in localizeParams) {
            //        textParameter.LocalizedLabels.Add(new AinDevHelperLocalizedMessage(langCode, locLabel));
            //        textParameter.LocalizedDescriptions.Add(new AinDevHelperLocalizedMessage(langCode, locDescription));
            //    }
            //}
            Parameters.Add(textParameter);
        }

        public void AddTextParameter(string name, string label, string description, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddTextParameter(name, label, description, "", localizeParams);
        }

        public void AddTextParameter(string name, string label, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddTextParameter(name, label, string.Empty, localizeParams);
        }

        public void AddCheckBoxParameter(string name, string label) {
            AddCheckBoxParameter(name, label, string.Empty, false, null);
        }

        public void AddCheckBoxParameter(string name, string label, string description, bool isInitiallyChecked = false) {            
            AddCheckBoxParameter(name, label, description, isInitiallyChecked, null);
        }

        public void AddCheckBoxParameter(string name, string label, string description, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddCheckBoxParameter(name, label, description, false, localizeParams);
        }

        public void AddCheckBoxParameter(string name, string label, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddCheckBoxParameter(name, label, string.Empty, false, localizeParams);
        }

        public void AddCheckBoxParameter(string name, string label, string description, bool isInitiallyChecked = false, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AinDevHelperPluginActionCheckBoxParameter checkBoxParameter = new AinDevHelperPluginActionCheckBoxParameter(name, label, description, isInitiallyChecked);
            EnrichActionParameterWithLocalizeParams(checkBoxParameter, localizeParams);
            Parameters.Add(checkBoxParameter);
        }

        public void AddDirectorySelectionParameter(string name, string label) {
            AddDirectorySelectionParameter(name, label, string.Empty, "", null);
        }

        public void AddDirectorySelectionParameter(string name, string label, string description) {            
            AddDirectorySelectionParameter(name, label, description, "", null);
        }

        public void AddDirectorySelectionParameter(string name, string label, string description, string selectedDirectory) {
            AddDirectorySelectionParameter(name, label, description, selectedDirectory, null);
        }

        public void AddDirectorySelectionParameter(string name, string label, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddDirectorySelectionParameter(name, label, string.Empty, "", localizeParams);
        }

        public void AddDirectorySelectionParameter(string name, string label, string description, string selectedDirectory, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            var directorySelectionParameter = new AinDevHelperPluginActionDirectorySelectionParameter(name, label, description, selectedDirectory);
            EnrichActionParameterWithLocalizeParams(directorySelectionParameter, localizeParams);
            Parameters.Add(directorySelectionParameter);
        }

        public void AddFileSelectionParameter(string name, string label) {
            AddFileSelectionParameter(name, label, string.Empty, null);
        }

        public void AddFileSelectionParameter(string name, string label, string description) {
            AddFileSelectionParameter(name, label, description, null);
        }        

        public void AddFileSelectionParameter(string name, string label, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            AddFileSelectionParameter(name, label, string.Empty, localizeParams);
        }

        public void AddFileSelectionParameter(string name, string label, string description, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {            
            var fileSelectionParameter = new AinDevHelperPluginActionFileSelectionParameter(name, label, description);
            EnrichActionParameterWithLocalizeParams(fileSelectionParameter, localizeParams);
            Parameters.Add(fileSelectionParameter);
        }

        public void AddDropDownListParameter(AinDevHelperPluginActionDropDownListParameter dropDownListParameter) {
            //Parameters.Add(dropDownListParameter);
            AddDropDownListParameter(dropDownListParameter, null);
        }

        public void AddDropDownListParameter(AinDevHelperPluginActionDropDownListParameter dropDownListParameter, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            EnrichActionParameterWithLocalizeParams(dropDownListParameter, localizeParams);
            Parameters.Add(dropDownListParameter);
        }

        private void EnrichActionParameterWithLocalizeParams(AinDevHelperPluginActionParameter parameter, params (string languageCode, string localizedLabel, string localizedDescription)[] localizeParams) {
            if (parameter == null) {
                return;
            }
            if (localizeParams != null && localizeParams.Length > 0) {
                foreach ((string langCode, string locLabel, string locDescription) in localizeParams) {
                    parameter.LocalizedLabels.Add(new AinDevHelperLocalizedMessage(langCode, locLabel));
                    parameter.LocalizedDescriptions.Add(new AinDevHelperLocalizedMessage(langCode, locDescription));
                }
            }
        }

        public AinDevHelperDropDownListValue GetDropDownListParameterSelectedValue(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionDropDownListParameter dropDownListParameter && parameterName.Equals(p.Name)) {
                    return dropDownListParameter.SelectedValue;
                }
            }
            return null;
        }

        public object GetDropDownListParameterSelectedValueObject(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionDropDownListParameter dropDownListParameter && parameterName.Equals(p.Name)) {
                    return dropDownListParameter.SelectedValueObject;
                }
            }
            return null;
        }

        public string GetDropDownListParameterSelectedValueName(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionDropDownListParameter dropDownListParameter && parameterName.Equals(p.Name)) {
                    return dropDownListParameter.SelectedValueName;
                }
            }
            return null;
        }


        public string GetFileSelectionParameterValue(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionFileSelectionParameter fileSelectionParameter && parameterName.Equals(p.Name)) {
                    return fileSelectionParameter.SelectedFile;
                }
            }
            return null;
        }


        public string GetDirectorySelectionParameterValue(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionDirectorySelectionParameter directorySelectionParameter && parameterName.Equals(p.Name)) {
                    return directorySelectionParameter.SelectedDirectory;
                }
            }
            return null;
        }


        public string GetTextParameterValue(string parameterName) {
            if (parameterName == null) {
                return null;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionTextParameter textParameter && parameterName.Equals(p.Name)) {
                    return textParameter.Text;
                }
            }
            return null;
        }

        public bool GetCheckBoxParameterValue(string parameterName) {
            if (parameterName == null) {
                return false;
            }

            foreach (AinDevHelperPluginActionParameter p in Parameters) {
                if (p is AinDevHelperPluginActionCheckBoxParameter checkBoxParameter && parameterName.Equals(p.Name)) {
                    return checkBoxParameter.Checked;
                }
            }
            return false;
        }

        //TODO: избавиться от этого метода
        //public bool GetBoolParameterValue(string parameterName) {
        //    if (parameterName == null) {
        //        return false;
        //    }

        //    foreach (AinDevHelperPluginActionParameter p in Parameters) {
        //        if (p is AinDevHelperPluginActionBoolParameter boolParam && parameterName.Equals(p.Name)) {
        //            return boolParam.Value;
        //        }
        //    }
        //    return false;
        //}


        //public override string ToString() {
        //    return Name;
        //}

        //public override bool Equals(object obj) {
        //    return obj is AinDevHelperPluginParameterizedAction action &&
        //           base.Equals(obj) &&
        //           Name == action.Name &&
        //           Tag == action.Tag &&
        //           EqualityComparer<List<AinDevHelperPluginActionParameter>>.Default.Equals(Parameters, action.Parameters);
        //}

        //public override int GetHashCode() {
        //    int hashCode = 1253338240;
        //    hashCode = hashCode * -1521134295 + base.GetHashCode();
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Tag);
        //    hashCode = hashCode * -1521134295 + EqualityComparer<List<AinDevHelperPluginActionParameter>>.Default.GetHashCode(Parameters);
        //    return hashCode;
        //}
    }
}
