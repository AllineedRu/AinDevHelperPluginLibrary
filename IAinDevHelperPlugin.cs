using System.Collections.Generic;
using AinDevHelperPluginLibrary.Actions;
using AinDevHelperPluginLibrary.Language;

namespace AinDevHelperPluginLibrary {
    /// <summary>
    /// [RU] Интерфейс описывает плагин, поддерживаемый приложением AinDevHelper.<br/>
    /// [EN] The interface describes the plugin supported by the AinDevHelper application.
    /// </summary>
    public interface IAinDevHelperPlugin {
        /// <summary>
        /// [RU] Название плагина - в том виде, как оно будет отображаться в интерфейсе AinDevHelper. Например: "Angular Helper Plugin". 
        /// Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] The name of the plugin - as it will be displayed in the AinDevHelper interface. For example: "Angular Helper Plugin". 
        /// This property is expected to be overridden by the plugin.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// [RU] Название компании, производителя или поставщика плагина, который создал и выпустил плагин. 
        /// Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] The name of the Company, Manufacturer or Vendor of the plugin which has created and produced the plugin. 
        /// This property is expected to be overridden by the plugin.
        /// </summary>
        string Company { get; }

        /// <summary>
        /// [RU] Описание плагина и его функциональных возможностей. 
        /// Описание плагина будет давать пользователям представление о его предназначении и механизме работы. 
        /// Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] Description of the plugin and its functionality. 
        /// The description of the plugin will give users an idea of its purpose and how it works.
        /// This property is expected to be overridden by the plugin.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// [RU] Имя автора плагина. Например: "Mr. Ivan Ivanov". Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] The Author name of the plugin. For example: "Mr. Ivan Ivanov". This property is expected to be overridden by the plugin.
        /// </summary>
        string Author { get; }

        /// <summary>
        /// [RU] Адрес Веб-сайта разработчика/автора плагина. Например: "https://some.amazing.website.dev". 
        /// Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] Website address of the developer/author of the plugin. For example: "https://some.amazing.website.dev". 
        /// This property is expected to be overridden by the plugin.
        /// </summary>
        string AuthorSiteURL { get; }

        /// <summary>
        /// [RU] Email разработчика/автора плагина. Например: "aindevhelper_plugin_author@gmail.com". 
        /// Ожидается переопределение данного свойства со стороны плагина.<br/>
        /// [EN] Email address of the developer/author of the plugin. For example: "aindevhelper_plugin_author@gmail.com". 
        /// This property is expected to be overridden by the plugin.
        /// </summary>
        string AuthorEmail { get; }

        /// <summary>
        /// [RU] Путь к файлу справки плагина "plugin_help.html". 
        /// Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper. 
        /// Не предусмотрено переопределение этого свойства из кода самого плагина.<br/>
        /// [EN] Path to the plugin help file "plugin_help.html". 
        /// The property is initialized by the host when the plugin is loaded and connected to AinDevHelper. 
        /// There is no provision for overriding this property from the plugin code itself.
        /// </summary>
        string HelpFilePath { get; set; }

        /// <summary>
        /// [RU] Путь к каталогу плагина. 
        /// Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper. 
        /// Не предусмотрено переопределение этого свойства из кода самого плагина.<br/>
        /// [EN] Path to the plugin directory. 
        /// The property is initialized by the host when the plugin is loaded and connected to AinDevHelper. 
        /// There is no provision for overriding this property from the plugin code itself.
        /// </summary>
        string PluginDirectory { get; set; }

        /// <summary>
        /// [RU] Флаг, определяющий, имеет ли плагин связанную документацию и файл "plugin_help.html" в своём каталоге. 
        /// Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper. 
        /// Не предусмотрено переопределение этого свойства из кода самого плагина.<br/>
        /// [EN] A flag that determines whether the plugin has associated documentation and a "plugin_help.html" file in its directory. 
        /// The property is initialized by the host when the plugin is loaded and connected to AinDevHelper. 
        /// There is no provision for overriding this property from the plugin code itself.
        /// </summary>
        bool HasHelpFile { get; set; }

        /// <summary>
        /// [RU] Основная версия плагина. Это основной релизный выпуск плагина (предполагается, что увеличивается, когда было добавлено много новых функций или изменений в пользовательском интерфейсе).
        /// [EN] The Major version of the plugin. It is a major release of the plugin (expected to increase when many new features or changes to the user interface have been added).
        /// Example: 1
        /// </summary>
        int MajorVersion { get; }

        /// <summary>
        /// [RU] Минорная версия плагина. Это минорный релиз (обычно, когда выпущеные некоторые новые фичи) для предыдущего Major-релиза плагина.<br/>
        /// [EN] Minor version of the plugin. This is a minor release (usually when some new features are released) for the previous Major release of the plugin.
        /// </summary>
        int MinorVersion { get; }

        /// <summary>
        /// [RU] Версия ревизии плагина. Это обычно исправления для предыдущей Minor-версии плагина (нет новой функциональности, только исправления дефектов).<br/> 
        /// [EN] Plugin revision version. These are usually fixes for the previous Minor version of the plugin (no new functionality, only bug fixes).
        /// </summary>
        int RevisionVersion { get; }

        /// <summary>
        /// [RU] Версия сборки плагина. Увеличивается каждый раз для каждого последнего (свежего) билда текущей ревизии плагина.<br/>
        /// [EN] Plugin build version. Increases each time for each latest (fresh) build of the current plugin revision.
        /// </summary>
        int BuildVersion { get; }

        /// <summary>
        /// [RU] Версия плагина, которая указывается в свободной форме на усмотрение разработчика плагина. При использовании этого поля не будет использоваться нумерация версий плагина в виде [MajorVersion].[MinorVersion].[RevisionVersion].[BuildVersion].<br/>
        /// [EN] The plugin version, which is specified in free form at the discretion of the plugin developer. When using this field, plugin version numbering in the form [MajorVersion].[MinorVersion].[RevisionVersion].[BuildVersion] will not be used.
        /// </summary>
        string Version { get; }

        /// <summary>
        /// [RU] Свойство возвращает коллекцию строк, где каждая строка представляет собой тег для связи с экземпляром плагина и его семантического описания. Теги облегчают для пользователя AinDevHelper поиск данного плагина.<br/>
        /// [EN] The property returns a collection of strings, where each string represents a tag to associate with a plugin instance and its semantic description. Tags make it easier for the AinDevHelper user to find a given plugin.
        /// </summary>
        IEnumerable<string> Tags { get; }

        /// <summary>
        /// [RU] Свойство возвращает коллекцию строк, где каждая строка представляет собой код языка, поддерживаемого данным плагином. Если плагин предусматривает локализацию на другие языки, то он должен вернуть коды всех поддерживаемых языков.<br/>
        /// [EN] The property returns a collection of strings, where each string represents the code of the language supported by this plugin. If the plugin provides localization into other languages, then it must return codes for all supported languages.
        /// </summary>
        IEnumerable<string> SupportedLanguageCodes { get; }

        /// <summary>
        /// [RU] Свойство возвращает коллекцию элементов <see cref="AinDevHelperLocalizedMessage"/>, представляющих собой локализации описания плагина на поддерживаемые AinDevHelper языки<br/>
        /// [EN] The property returns a collection of <see cref="AinDevHelperLocalizedMessage"/> elements, representing localizations of the plugin description into languages supported by AinDevHelper
        /// </summary>
        IEnumerable<AinDevHelperLocalizedMessage> LocalizedDescriptions { get; }

        /// <summary>
        /// [RU] Метод, который вызывается хостом (приложением AinDevHelper) при обнаружении плагина и подключении его к AinDevHelper. 
        /// Используется для выполнения различных действий, инициализирующих работу плагина и которые необходимо выполнить перед началом его работы. 
        /// Ожидается переопределение данного метода со стороны плагина, если есть необходимость в выполнении инициализирующих действий.
        /// Метод вызывается хостом до вызова метода <see cref="LoadSettings"/>.<br/>
        /// [EN] A method that is called by the host (AinDevHelper application) when it detects a plugin and connects it to AinDevHelper. 
        /// Used to perform various actions that initialize the plugin and which must be performed before it starts working. 
        /// This method is expected to be overridden by the plugin if there is a need to perform initialization actions. 
        /// The method is called by the host before the <see cref="LoadSettings"/> method is called.
        /// </summary>
        void Initialize();

        /// <summary>
        /// [RU] Метод, который вызывается хостом (приложением AinDevHelper) при сохранении настроек всего приложения и отвечает за сохранение 
        /// настроек экземпляра данного плагина, при условии, что плагин использует и поддерживает свои собственные настройки.
        /// Стандартная реализация механизма сохранения настроек плагина уже реализована в классе <see cref="StandardAinDevHelperPlugin"/>,
        /// поэтому имеет смысл рассмотреть возможность наследования от этого класса.<br/>
        /// [EN] A method that is called by the host (AinDevHelper application) when saving application-wide settings and is responsible for saving 
        /// the settings of a given plugin instance, provided that the plugin uses and maintains its own settings. 
        /// The standard implementation of the mechanism for saving plugin settings is already implemented in the <see cref="StandardAinDevHelperPlugin"/> class, 
        /// so it makes sense to consider the possibility of inheriting from this class.
        /// </summary>
        void SaveSettings();

        /// <summary>
        /// [RU] Метод, который вызывается хостом (приложением AinDevHelper) при обнаружении плагина и подключении его к AinDevHelper.
        /// Используется для выполнения действий по загрузке настроек плагина, если плагин предусматривает наличие настроек.
        /// Возможно переопределение данного метода со стороны плагина, если плагин использует механизм собственных настроек.
        /// Стандартная реализация механизма загрузки настроек плагина уже реализована в классе <see cref="StandardAinDevHelperPlugin"/>, 
        /// поэтому имеет смысл рассмотреть возможность наследования от этого класса. 
        /// Метод вызывается хостом после вызова метода <see cref="Initialize"/>.<br/>
        /// [EN] A method that is called by the host (AinDevHelper application) when it detects a plugin and connects it to AinDevHelper.
        /// Used to perform actions to load plugin settings, if the plugin provides settings. 
        /// This method may be be overridden by the plugin if the plugin uses its own settings mechanism. 
        /// The standard implementation of the mechanism for loading plugin settings is already implemented in the <see cref="StandardAinDevHelperPlugin"/> class, 
        /// so it makes sense to consider the possibility of inheriting from this class. 
        /// The method is called by the host after calling the <see cref="Initialize"/> method.
        /// </summary>
        void LoadSettings();

        /// <summary>
        /// [RU] Свойство возвращает или устанавливает ссылку на хост для плагина. 
        /// Хостом для всех плагинов, поддерживаемых AinDevHelper, выступает само приложение AinDevHelper (его внутренний служебный класс). 
        /// Установка значения для данного свойства производится самим хостом.<br/>
        /// [EN] The property returns or sets a link to the host for the plugin. 
        /// The host for all plugins supported by AinDevHelper is the AinDevHelper application itself (its internal utility class). 
        /// Setting the value for this property is done by the host itself.
        /// </summary>
        IAinDevHelperPluginHost Host { get; set; }

        /// <summary>
        /// [RU] Метод возвращает коллекцию действий, которые поддерживаются экземпляром плагина.<br/>
        /// [EN] The method returns a collection of actions that are supported by the plugin instance. 
        /// </summary>
        /// <returns>[RU] коллекция действий, поддерживаемых данным экземпляром плагина;<br/>[EN] collection of actions supported by a given plugin instance</returns>
        IEnumerable<AinDevHelperPluginAction> GetActions();

        /// <summary>
        /// [RU] Метод возвращает ссылку на экземпляр настроек плагина. 
        /// Необходимая реализация уже присутствует в классе <see cref="StandardAinDevHelperPlugin"/>, поэтому имеет смысл рассмотреть возможность наследования от данного класса.<br/>
        /// [EN] The method returns a reference to a plugin settings instance. 
        /// The necessary implementation is already present in the <see cref="StandardAinDevHelperPlugin"/> class, so it makes sense to consider the possibility of inheriting from this class.
        /// </summary>
        /// <returns>[RU] ссылка на экземпляр настроек плагина;<br/>[EN] reference to plugin settings instance</returns>
        AinDevHelperPluginSettings GetSettings();

        /// <summary>
        /// [RU] Метод вызывается приложением AinDevHelper при выполнении одного из поддерживаемых плагином действий. 
        /// Плагин должен реализовать данный метод и произвести необходимые действия для выполнения заданного действия <paramref name="actionToRun"/>, поддерживаемого этим плагином.<br/>
        /// [EN] The method is called by the AinDevHelper application when performing one of the actions supported by the plugin. 
        /// The plugin must implement this method and perform the necessary actions to perform the specified action <paramref name="actionToRun"/> supported by this plugin.
        /// </summary>
        /// <param name="actionToRun">[RU] ссылка на экземпляр действия, поддерживаемого данным плагином и которое было выбрано пользователем в интерфейсе AinDevHelper;<br/>[EN] a reference to an instance of an action supported by this plugin and which was selected by the user in the AinDevHelper interface</param>
        /// <returns>[RU] экземпляр класса <see cref="AinDevHelperPluginActionResult"/>, представляющий собой результат выполнения действия <paramref name="actionToRun"/>, поддерживаемого плагином;<br/>[EN] an instance of the <see cref="AinDevHelperPluginActionResult"/> class, which represents the result of executing the action <paramref name="actionToRun"/> supported by the plugin;</returns>
        AinDevHelperPluginActionResult RunAction(AinDevHelperPluginAction actionToRun);        
    }
}
