using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AinDevHelperPluginLibrary.Actions;
using AinDevHelperPluginLibrary.Language;

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
