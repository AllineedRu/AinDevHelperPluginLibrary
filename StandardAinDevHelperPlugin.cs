/*
Copyright 2024 Allineed.Ru, Max Damascus

Permission is hereby granted, free of charge, to any person obtaining a copy of this software 
and associated documentation files (the "Software"), to deal in the Software without restriction, 
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, 
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, 
INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. 
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE 
OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using AinDevHelperPluginLibrary.Actions;
using AinDevHelperPluginLibrary.Language;
using static AinDevHelperPluginLibrary.Language.AinDevHelperLanguageCodeConstants;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Абстрактный класс, представляющий базовое поведение плагинов AinDevHelper.<br/>
    /// [EN] 
    /// </summary>
    public abstract class StandardAinDevHelperPlugin : IAinDevHelperPlugin {
        private IAinDevHelperPluginHost host;
        protected AinDevHelperPluginSettings pluginSettings;
        protected readonly string DEFAULT_PLUGIN_SETTINGS_FILE = "settings.xml";

        public abstract string Name { get; }
        public virtual string Company => "";
        public abstract string Description { get; }
        public abstract string Author { get; }
        public virtual string AuthorSiteURL => "";
        public virtual string AuthorEmail => "";
        public string HelpFilePath { get; set; }
        public bool HasHelpFile { get; set; }
        public string PluginDirectory { get; set; }
        public virtual int MajorVersion => 1;
        public virtual int MinorVersion => 0;        
        public virtual int RevisionVersion => 0;
        public virtual int BuildVersion => 0;
        public virtual string Version => "";
        public abstract IEnumerable<string> Tags { get; }
        public abstract IEnumerable<string> SupportedLanguageCodes { get; }

        public IAinDevHelperPluginHost Host {
            get => host;
            set {
                host = value;
                host.RegisterPlugin(this);
            }
        }

        public virtual IEnumerable<AinDevHelperLocalizedMessage> LocalizedDescriptions => new HashSet<AinDevHelperLocalizedMessage>();        

        public abstract IEnumerable<AinDevHelperPluginAction> GetActions();
        public abstract AinDevHelperPluginActionResult RunAction(AinDevHelperPluginAction actionToRun);        

        public virtual AinDevHelperPluginSettings GetSettings() {
            return pluginSettings;
        }
        protected StandardAinDevHelperPlugin() {
            pluginSettings = new AinDevHelperPluginSettings();
        }

        public virtual void Initialize() {
        }

        public AinDevHelperPluginActionResult GetErroneousResponse(AinDevHelperPluginAction actionToRun, string errorMessage) {
            return new AinDevHelperPluginActionResult(
                this, 
                actionToRun,
                AinDevHelperPluginActionResult.ActionResultReturnCode.PluginFailedToExecuteAction,
                errorMessage
            );
        }

        public AinDevHelperPluginActionResult GetErroneousResponse(AinDevHelperPluginAction actionToRun, string errorMessage, params (string languageCode, string localizedErrorMessage)[] localizedErrorMessages) {
            return new AinDevHelperPluginActionResult(
                this, 
                actionToRun,
                AinDevHelperPluginActionResult.ActionResultReturnCode.PluginFailedToExecuteAction,
                errorMessage, 
                localizedErrorMessages
            );
        }

        public AinDevHelperPluginActionResult GetErroneousResponseActionNotRecognized(AinDevHelperPluginAction actionToRun) {
            return GetErroneousResponse(
                actionToRun,
                $"Ошибка при выполнении действия плагина. Действие не распознано. Убедитесь, что со стороны плагина есть соответствующий код для обработки действия '{actionToRun.Name}' и возврата результата по данному действию.",
                (EN, $"An error occurred while executing the plugin action. Action not recognized. Make sure that the plugin has the appropriate code to handle the '{actionToRun.Name}' action and return the result for that action."),
                (DE, $"Beim Ausführen der Plugin-Aktion ist ein Fehler aufgetreten. Aktion nicht erkannt. Stellen Sie sicher, dass das Plugin über den entsprechenden Code verfügt, um die Aktion „{actionToRun.Name}“ zu verarbeiten und das Ergebnis für diese Aktion zurückzugeben.")
            ); ;
        }

        public AinDevHelperPluginActionResult GetErroneousResponseDirectoryWasNotFound(AinDevHelperPluginAction actionToRun, string notFoundDirectoryName) {
            string directoryName = string.IsNullOrEmpty(notFoundDirectoryName) ? "" : notFoundDirectoryName;

            return GetErroneousResponse(
                actionToRun, 
                $"Ошибка при выполнении действия плагина. Директория '{directoryName}' не существует в файловой системе. Проверьте корректность пути.",
                (EN, $"An error occurred while executing the plugin action. Directory '{directoryName}' does not exist in the file system. Check that the path is correct."),
                (DE, $"Beim Ausführen der Plugin-Aktion ist ein Fehler aufgetreten. Das Verzeichnis „{directoryName}“ ist im Dateisystem nicht vorhanden. Überprüfen Sie, ob der Pfad korrekt ist.")
                );
        }

        public AinDevHelperPluginActionResult GetSuccessfulResponseWebLinkAction(AinDevHelperPluginAction actionToRun, AinDevHelperPluginWebLinkAction webLinkAction) {
            return new AinDevHelperPluginActionResult(
                this,
                actionToRun,
                $"Действие '{webLinkAction.Name}' успешно выполнено. Страница '{webLinkAction.WebLink}' открыта в браузере по умолчанию.",
                (EN, $"Action '{webLinkAction.Name}' completed successfully. The '{webLinkAction.WebLink}' page is opened in the default browser."),
                (DE, $"Aktion „{webLinkAction.Name}“ erfolgreich abgeschlossen. Die Seite „{webLinkAction.WebLink}“ wird im Standardbrowser geöffnet.")
            );
        }

        public AinDevHelperPluginActionResult GetErroneousResponseFileWasNotFound(AinDevHelperPluginAction actionToRun, string notFoundFileName) {
            string fileName = string.IsNullOrEmpty(notFoundFileName) ? "" : notFoundFileName;

            return GetErroneousResponse(
                actionToRun,
                $"Ошибка при выполнении действия плагина. Файл '{fileName}' не был найден, хотя ожидалось, что он существует.",
                (EN, $"An error occurred while executing the plugin action. The file '{fileName}' was not found although it was expected to exist."),
                (DE, $"Beim Ausführen der Plugin-Aktion ist ein Fehler aufgetreten. Die Datei „{fileName}“ wurde nicht gefunden, obwohl erwartet wurde, dass sie vorhanden ist.")
            );
        }

        public AinDevHelperPluginActionResult GetErroneousResponseForException(AinDevHelperPluginAction actionToRun, Exception exception) {            
            return new AinDevHelperPluginActionResult(
                this,
                actionToRun,
                AinDevHelperPluginActionResult.ActionResultReturnCode.PluginFailedToExecuteAction,
                $"Произошло исключение при выполнении действия плагина.\r\nСообщение ошибки: {exception.Message}.\r\n\r\nТрассировка стека:\r\n{exception.StackTrace}",
                (EN, $"An exception occurred while executing a plugin action.\r\nError message: {exception.Message}.\r\n\r\nStack trace:\r\n{exception.StackTrace}"),
                (DE, $"Beim Ausführen einer Plugin-Aktion ist eine Ausnahme aufgetreten.\r\nFehlermeldung: {exception.Message}.\r\n\r\nStacktrace:\r\n{exception.StackTrace}")
            );
        }

        public AinDevHelperPluginActionResult GetErroneousResponseExpectedParameterizedAction(AinDevHelperPluginAction actionToRun) {
            return new AinDevHelperPluginActionResult(
                this,
                actionToRun,
                "Ошибка при выполнении действия плагина. Действие не является экземпляром класса AinDevHelperPluginParameterizedAction.",
                (EN, "An error occurred while executing the plugin action. The action is not an instance of the AinDevHelperPluginParameterizedAction class."),
                (DE, "Beim Ausführen der Plugin-Aktion ist ein Fehler aufgetreten. Die Aktion ist keine Instanz der AinDevHelperPluginParameterizedAction-Klasse.")
            );
        }


        /// <summary>
        /// [RU] Метод сохраняет текущие настройки плагина<br/>
        /// [EN] The method saves the current plugin settings
        /// </summary>
        public virtual void SaveSettings() {
            try {
                if (pluginSettings.SettingControls.Count > 0) {
                    var xmlSerializer = new XmlSerializer(pluginSettings.GetType());
                    var settingsPath = PluginDirectory + Path.DirectorySeparatorChar + DEFAULT_PLUGIN_SETTINGS_FILE;

                    if (File.Exists(settingsPath)) {
                        File.Delete(settingsPath);
                    }

                    var fileStream = new FileStream(settingsPath, FileMode.Create, FileAccess.Write);
                    xmlSerializer.Serialize(fileStream, pluginSettings);
                    fileStream.Close();
                } 
            } catch (Exception e) {
                Console.WriteLine($"Ошибка в методе SaveSettings плагина {Name}: {e.Message}:");
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// [RU] Метод производит загрузку текущих настроек плагина<br/>
        /// [EN] The method loads the current plugin settings
        /// </summary>
        public virtual void LoadSettings() {
            try {
                var settingsPath = PluginDirectory + Path.DirectorySeparatorChar + DEFAULT_PLUGIN_SETTINGS_FILE;

                if (File.Exists(settingsPath)) {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperPluginSettings));
                    using var myFileStream = new FileStream(settingsPath, FileMode.Open);
                    pluginSettings = (AinDevHelperPluginSettings)xmlSerializer.Deserialize(myFileStream);
                }
            } catch (Exception e) {
                Console.WriteLine($"Ошибка в методе LoadSettings плагина {Name}: {e.Message}:");
                Console.WriteLine(e);
            }            
        }
    }
}
