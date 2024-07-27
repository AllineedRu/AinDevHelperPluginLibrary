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
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions {
    /// <summary>
    /// [RU] Класс описывает действие плагина с типом "Веб-ссылка". При выполнении этого действия AinDevHelper будет производить переход в браузере по указанному в действии адресу<br/>
    /// [EN] The class describes the action of a plugin with the "Web link" type. When performing this action, AinDevHelper will navigate in the browser to the address specified in the action
    /// </summary>
    public class AinDevHelperPluginWebLinkAction : AinDevHelperPluginAction {
        /// <summary>
        /// [RU] Адрес Веб-ссылки для перехода в браузере<br/>
        /// [EN] Web link address to navigate to in browser
        /// </summary>
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

        /// <summary>
        /// [RU] Метод производит навигацию по Веб-ссылке, указанной в данном экземпляре действия (свойство <see cref="WebLink"/>)<br/>
        /// [EN] The method navigates through the Web link specified in this action instance (property <see cref="WebLink"/>)
        /// </summary>
        /// <returns>[RU] <see langword="true"/>, если адрес Веб-ссылки непустой и процесс был запущен, иначе <see langword="false"/>;<br/>[EN] <see langword="true"/> if the Web link address is non-empty and the process has been started, otherwise <see langword="false"/></returns>
        public bool Navigate() {
            if (!string.IsNullOrEmpty(WebLink)) {
                Process.Start(WebLink);
                return true;
            }
            return false;
        }
    }
}
