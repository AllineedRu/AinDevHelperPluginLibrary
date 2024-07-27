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
using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions {
    /// <summary>
    /// [RU] Класс описывает обычное действие плагина (непараметризованное)<br/>
    /// [EN] The class describes the normal action of the plugin (non-parameterized)
    /// </summary>
    public class AinDevHelperPluginAction {
        public virtual string Name { get; set; }
        public virtual string ID { get; set; }

        public virtual List<string> Tags { get; set; } = new List<string>();

        public virtual HashSet<AinDevHelperLocalizedMessage> LocalizedNames { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        private AinDevHelperLanguage currentLanguage;

        public void SetCurrentLanguage(AinDevHelperLanguage currentLanguage) {
            this.currentLanguage = currentLanguage;
        }

        public AinDevHelperPluginAction(string name, string id) {
            Name = name;
            ID = id;
        }        

        public void AddLocalizedName(string languageCode, string localizedActionName) {
            LocalizedNames.Add(new AinDevHelperLocalizedMessage(languageCode, localizedActionName));
        }


        public AinDevHelperPluginAction(AinDevHelperPluginNoParamsActionDescriptor noParamsActionDescriptor) : this(noParamsActionDescriptor.Name, noParamsActionDescriptor.ID) {
            if (noParamsActionDescriptor.LocalizedNames != null && noParamsActionDescriptor.LocalizedNames.Count > 0) {
                foreach (var localizedName in noParamsActionDescriptor.LocalizedNames) {
                    AddLocalizedName(localizedName.LanguageCode, localizedName.Message);
                }
            }
            if (noParamsActionDescriptor.Tags != null && noParamsActionDescriptor.Tags.Count > 0) {
                foreach (string tag in noParamsActionDescriptor.Tags) {
                    Tags.Add(tag);
                }
            }
        }

        public static IEnumerable<AinDevHelperPluginAction> FromStrings(params string[] actionNames) {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (actionNames == null || actionNames.Length == 0) {
                return pluginActions;
            }
            
            foreach (string actionName in actionNames) {
                pluginActions.Add(new AinDevHelperPluginAction(actionName, actionName));
            }

            return pluginActions;
        }

        /// <summary>
        /// [RU] Возвращает коллекцию действий без параметров, создаваемых из входных кортежей, содержащих имя действия и ID действия<br/>
        /// [EN] Returns a collection of actions without parameters, created from input tuples containing the action name and action ID
        /// </summary>
        /// <param name="actions"></param>
        /// <returns></returns>

        public static IEnumerable<AinDevHelperPluginAction> FromTuples(params (string actionName, string actionId)[] actions) {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (actions == null || actions.Length == 0) {
                return pluginActions;
            }

            foreach ((string actionName, string actionId) in actions) {
                pluginActions.Add(new AinDevHelperPluginAction(actionName, actionId));
            }

            return pluginActions;
        }

        public static AinDevHelperPluginAction ActionFrom(string actionName, string actionId, params (string languageCode, string actionLocalizedName)[] actionLocalizedNames) {            
            AinDevHelperPluginAction newNoParamsPluginAction = new AinDevHelperPluginAction(actionName, actionId);
            if (actionLocalizedNames == null || actionLocalizedNames.Length == 0) {
                return newNoParamsPluginAction;
            }

            foreach ((string langCode, string localizedName) in actionLocalizedNames) {
                newNoParamsPluginAction.LocalizedNames.Add(new AinDevHelperLocalizedMessage(langCode, localizedName));                
            }

            return newNoParamsPluginAction;
        }



        [Obsolete]
        public static IEnumerable<AinDevHelperPluginAction> WebLinkActionsFromTuples(params (string actionName, string webLink)[] actionNamesAndLinksTuples) {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (actionNamesAndLinksTuples == null || actionNamesAndLinksTuples.Length == 0) {
                return pluginActions;
            }

            foreach ((string actionName, string webLink) in actionNamesAndLinksTuples) {
                pluginActions.Add(new AinDevHelperPluginWebLinkAction(actionName, actionName, webLink));
            }

            return pluginActions;
        }


        public static IEnumerable<AinDevHelperPluginAction> CombineFrom(params IEnumerable<AinDevHelperPluginAction>[] actionSets) {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (actionSets != null && actionSets.Length > 0) {                
                foreach (IEnumerable<AinDevHelperPluginAction> actionSet in actionSets) {
                    foreach (AinDevHelperPluginAction action in actionSet) {
                        pluginActions.Add(action);
                    }
                }
            }
            return pluginActions;
        }

        /// <summary>
        /// [RU] Возвращает коллекцию действий плагина по входному списку экземпляров парамтеров<br/>
        /// [EN] Returns a collection of plugin actions given an input list of parameter instances
        /// </summary>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static IEnumerable<AinDevHelperPluginAction> From(params AinDevHelperPluginAction[] actions) {
            List<AinDevHelperPluginAction> pluginActions = new List<AinDevHelperPluginAction>();
            if (actions != null && actions.Length > 0) {
                foreach (AinDevHelperPluginAction action in actions) {
                    pluginActions.Add(action);
                }
            }
            return pluginActions;
        }


        public override bool Equals(object obj) {
            return obj is AinDevHelperPluginAction action &&
                   Name == action.Name &&
                   ID == action.ID;
        }

        public string GetLocalizedName() {
            if (currentLanguage == null || LocalizedNames == null || LocalizedNames.Count == 0) {
                return Name;
            }

            Func<AinDevHelperLocalizedMessage, bool> predicate = localizedName => localizedName.LanguageCode.Equals(currentLanguage.LanguageCode);
            if (LocalizedNames.Any(predicate)) {
                return LocalizedNames.First(predicate).Message;
            }

            return Name;
        }

        public override string ToString() {
            return GetLocalizedName();
        }

        public override int GetHashCode() {
            int hashCode = 413449769;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
            return hashCode;
        }
    }
}
