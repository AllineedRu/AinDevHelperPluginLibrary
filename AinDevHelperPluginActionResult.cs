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
using System.Collections.Generic;
using AinDevHelperPluginLibrary.Actions;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Класс описывает результат выполнения заданного действия, поддерживаемого плагином.<br/>
    /// [EN] The class describes the result of executing a given action supported by the plugin.
    /// </summary>
    public class AinDevHelperPluginActionResult {
        /// <summary>
        /// [RU] Перечисление задаёт возможные коды выполнения действия плагина.<br/>
        /// [EN] The enumeration specifies possible codes for executing the plugin action.
        /// </summary>
        public enum ActionResultReturnCode {
            /// <summary>
            /// [RU] Действие плагина была выполнено успешно и без ошибок.<br/>
            /// [EN] The plugin action was completed successfully and without errors.
            /// </summary>
            ActionExecutedSuccessfully,

            /// <summary>
            /// [RU] Плагин не смог выполнить указанное действие (возникли ошибки при выполнении плагином действия).<br/>
            /// [EN] The plugin was unable to perform the specified action (errors occurred while the plugin was performing the action).
            /// </summary>
            PluginFailedToExecuteAction
        }

        /// <summary>
        /// [RU] Сообщение об ошибке, возникшей при выполнении действия. Должно содержать описание ошибки, если действие плагина не удалось выполнить.<br/>
        /// [EN] Message about an error that occurred while performing the action. Should contain a description of the error if the plugin action failed.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// [RU] Набор локализованных сообщений об ошибке, возникшей при выполнении действия плагина<br/>
        /// [EN] A set of localized error messages that occurred when executing a plugin action
        /// </summary>
        public virtual HashSet<AinDevHelperLocalizedMessage> LocalizedErrorMessages { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Набор локализованных сообщений об успешном выполнении действия плагина<br/>
        /// [EN] A set of localized messages about the successful completion of a plugin action
        /// </summary>
        public virtual HashSet<AinDevHelperLocalizedMessage> LocalizedSuccessMessages { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Возвращаемый код для результата выполнения действия.<br/>
        /// [EN] Return code for the result of the action.
        /// </summary>
        public ActionResultReturnCode ReturnCode { get; set; }

        /// <summary>
        /// [RU] Сообщение об успешном выполнении действия.<br/>
        /// [EN] Message about successful completion of the action.
        /// </summary>
        public string SuccessMessage { get; set; }

        /// <summary>
        /// [RU] Флаг, отражающий, следует ли обновить список действий, поддерживаемых данным плагином после выполнения текущего действия. Значение <see langword="true"/> говорит о том, что обновление списка действий требуется, значение <see langword="false"/> - обновление не требуется.<br/>
        /// [EN] A flag indicating whether the list of actions supported by this plugin should be updated after the current action is completed. The value <see langword="true"/> indicates that updating the list of actions is required, the value <see langword="false"/> means that updating is not required.
        /// </summary>
        public bool IsRefreshPluginActions { get; set; }

        /// <summary>
        /// [RU] Возвращает/устанавливает ссылку на плагин, для которого выполнялось действие.<br/>
        /// [EN] Returns/sets a link to the plugin for which the action was performed.
        /// </summary>
        public IAinDevHelperPlugin Plugin { get; set; }

        /// <summary>
        /// [RU] Возвращает, устанавливает ссылку на действие, которое выполнялось плагином.<br/>
        /// [EN] Returns and sets a link to the action that was performed by the plugin.
        /// </summary>
        public AinDevHelperPluginAction PluginAction { get; set; }

        public AinDevHelperPluginActionResult(IAinDevHelperPlugin plugin, AinDevHelperPluginAction action, string successMessage, params (string languageCode, string localizedSuccessMessage)[] localizedSuccessMessages) {
            SuccessMessage = successMessage;
            ReturnCode = ActionResultReturnCode.ActionExecutedSuccessfully;
            Plugin = plugin;
            PluginAction = action;
            if (localizedSuccessMessages != null) {
                foreach ((string langCode, string localizedSuccessMessage) in localizedSuccessMessages) {
                    LocalizedSuccessMessages.Add(new AinDevHelperLocalizedMessage(langCode, localizedSuccessMessage));
                }
            }
        }

        public AinDevHelperPluginActionResult(
                IAinDevHelperPlugin plugin, 
                AinDevHelperPluginAction action, 
                string successMessage, 
                bool isRefreshPluginActions, 
                params (string languageCode, string actionLocalizedName)[] localizedSuccessMessages) : this(plugin, action, successMessage, localizedSuccessMessages) 
            {
                IsRefreshPluginActions = isRefreshPluginActions;            
        }

        public AinDevHelperPluginActionResult(IAinDevHelperPlugin plugin, AinDevHelperPluginAction action, ActionResultReturnCode returnCode, string resultMessage, params (string languageCode, string localizedResultMessage)[] localizedResultMessages) : this(plugin, action, returnCode, resultMessage, false, localizedResultMessages) {
        }

        public AinDevHelperPluginActionResult(IAinDevHelperPlugin plugin, AinDevHelperPluginAction action, ActionResultReturnCode returnCode, string resultMessage, bool isRefreshPluginActions, params (string languageCode, string localizedResultMessage)[] localizedResultMessages) {
            ReturnCode = returnCode;
            IsRefreshPluginActions = isRefreshPluginActions;
            switch (returnCode) {
                case ActionResultReturnCode.ActionExecutedSuccessfully:
                    SuccessMessage = resultMessage;
                    break;
                case ActionResultReturnCode.PluginFailedToExecuteAction:
                    ErrorMessage = resultMessage;
                    break;
            }
            Plugin = plugin;
            PluginAction = action;
            if (localizedResultMessages != null) {
                foreach ((string langCode, string localizedResultMessage) in localizedResultMessages) {
                    switch (returnCode) {
                        case ActionResultReturnCode.ActionExecutedSuccessfully:
                            LocalizedSuccessMessages.Add(new AinDevHelperLocalizedMessage(langCode, localizedResultMessage));
                            break;
                        case ActionResultReturnCode.PluginFailedToExecuteAction:
                            LocalizedErrorMessages.Add(new AinDevHelperLocalizedMessage(langCode, localizedResultMessage));
                            break;
                    }
                }
            }
        }
    }
}
