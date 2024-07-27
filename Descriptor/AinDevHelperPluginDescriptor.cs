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
using AinDevHelperPluginLibrary.Descriptor.ActionKind;
using AinDevHelperPluginLibrary.Descriptor.ActionParameter.Type;
using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Descriptor {
    /// <summary>
    /// [RU] Описывает дескриптор плагина для AinDevHelper. Используется для создания плагинов, основанных на базе XML-дескриптора.<br/>
    /// [EN] Describes the plugin descriptor for AinDevHelper. Used to create plugins based on an XML descriptor.
    /// </summary>    
    [Serializable]
    [XmlInclude(typeof(AinDevHelperPluginActionTextParameterDescriptor))]    
    [XmlInclude(typeof(AinDevHelperPluginActionCheckBoxParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionFileSelectionParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionDirectorySelectionParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginActionDropDownListParameterDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginParameterizedActionDescriptor))]        
    [XmlInclude(typeof(AinDevHelperPluginNoParamsActionDescriptor))]
    [XmlInclude(typeof(AinDevHelperPluginWebLinkActionDescriptor))]
    [XmlInclude(typeof(AinDevHelperPerformedActionKindRunProcess))]
    public class AinDevHelperPluginDescriptor {
        /// <summary>
        /// [RU] Название плагина - в том виде, как оно будет отображаться в интерфейсе AinDevHelper. Например: "Angular Helper Plugin".<br/>
        /// [EN] The name of the plugin - as it will be displayed in the AinDevHelper interface. For example: "Angular Helper Plugin".
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Название компании, производителя или поставщика плагина, который создал и выпустил плагин.<br/>
        /// [EN] The name of the Company, Manufacturer or Vendor of the plugin which has created and produced the plugin.
        /// </summary>
        public string Company { get; set; }

        /// <summary>
        /// [RU] Описание плагина и его функциональных возможностей. 
        /// Описание плагина будет давать пользователям представление о его предназначении и механизме работы.<br/>
        /// [EN] Description of the plugin and its functionality. 
        /// The description of the plugin will give users an idea of its purpose and how it works.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// [RU] Имя автора плагина. Например: "Mr. Ivan Ivanov".<br/>
        /// [EN] The Author name of the plugin. For example: "Mr. Ivan Ivanov"
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// [RU] Адрес Веб-сайта разработчика/автора плагина. Например: "https://some.amazing.website.dev".<br/>
        /// [EN] Website address of the developer/author of the plugin. For example: "https://some.amazing.website.dev".
        /// </summary>
        public string AuthorSiteURL { get; set; }

        /// <summary>
        /// [RU] Email разработчика/автора плагина. Например: "aindevhelper_plugin_author@gmail.com".<br/>
        /// [EN] Email address of the developer/author of the plugin. For example: "aindevhelper_plugin_author@gmail.com".
        /// </summary>
        public string AuthorEmail { get; set; }

        /// <summary>
        /// [RU] Путь к файлу справки плагина "plugin_help.html". Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper.<br/>
        /// [EN] Path to the plugin help file "plugin_help.html". The property is initialized by the host when the plugin is loaded and connected to AinDevHelper. 
        /// </summary>
        public string HelpFilePath { get; set; }

        /// <summary>
        /// [RU] Путь к каталогу плагина. Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper.<br/>
        /// [EN] Path to the plugin directory. The property is initialized by the host when the plugin is loaded and connected to AinDevHelper.
        /// </summary>
        public string PluginDirectory { get; set; }

        /// <summary>
        /// [RU] Флаг, определяющий, имеет ли плагин связанную документацию и файл "plugin_help.html" в своём каталоге. 
        /// Свойство инициализируется хостом при загрузке плагина и подключении его к AinDevHelper.<br/>
        /// [EN] A flag that determines whether the plugin has associated documentation and a "plugin_help.html" file in its directory. 
        /// The property is initialized by the host when the plugin is loaded and connected to AinDevHelper.
        /// </summary>
        public bool HasHelpFile { get; set; }

        /// <summary>
        /// [RU] Основная версия плагина. Это основной релизный выпуск плагина (предполагается, что увеличивается, когда было добавлено много новых функций или изменений в пользовательском интерфейсе).<br/>
        /// [EN] The Major version of the plugin. It is a major release of the plugin (expected to increase when many new features or changes to the user interface have been added).
        /// </summary>
        public int MajorVersion { get; set; }

        /// <summary>
        /// [RU] Минорная версия плагина. Это минорный релиз (обычно, когда выпущеные некоторые новые фичи) для предыдущего Major-релиза плагина.<br/>
        /// [EN] Minor version of the plugin. This is a minor release (usually when some new features are released) for the previous Major release of the plugin.
        /// </summary>
        public int MinorVersion { get; set; }

        /// <summary>
        /// [RU] Версия ревизии плагина. Это обычно исправления для предыдущей Minor-версии плагина (нет новой функциональности, только исправления дефектов).<br/> 
        /// [EN] Plugin revision version. These are usually fixes for the previous Minor version of the plugin (no new functionality, only bug fixes).
        /// </summary>
        public int RevisionVersion { get; set; }

        /// <summary>
        /// [RU] Версия сборки плагина. Увеличивается каждый раз для каждого последнего (свежего) билда текущей ревизии плагина.<br/>
        /// [EN] Plugin build version. Increases each time for each latest (fresh) build of the current plugin revision.
        /// </summary>
        public int BuildVersion { get; set; }

        /// <summary>
        /// [RU] Версия плагина, которая указывается в свободной форме на усмотрение разработчика плагина. При использовании этого поля не будет использоваться нумерация версий плагина в виде [MajorVersion].[MinorVersion].[RevisionVersion].[BuildVersion].<br/>
        /// [EN] The plugin version, which is specified in free form at the discretion of the plugin developer. When using this field, plugin version numbering in the form [MajorVersion].[MinorVersion].[RevisionVersion].[BuildVersion] will not be used.
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// [RU] Свойство возвращает коллекцию строк, где каждая строка представляет собой тег для связи с экземпляром плагина и его семантического описания. Теги облегчают для пользователя AinDevHelper поиск данного плагина.<br/>
        /// [EN] The property returns a collection of strings, where each string represents a tag to associate with a plugin instance and its semantic description. Tags make it easier for the AinDevHelper user to find a given plugin.
        /// </summary>
        public HashSet<string> Tags { get; set; } = new HashSet<string>();

        /// <summary>
        /// [RU] Свойство возвращает коллекцию строк, где каждая строка представляет собой код языка, поддерживаемого данным плагином. Если плагин предусматривает локализацию на другие языки, то он должен вернуть коды всех поддерживаемых языков.<br/>
        /// [EN] The property returns a collection of strings, where each string represents the code of the language supported by this plugin. If the plugin provides localization into other languages, then it must return codes for all supported languages.
        /// </summary>
        public HashSet<string> SupportedLanguageCodes { get; set; } = new HashSet<string>();

        /// <summary>
        /// [RU] Свойство возвращает коллекцию элементов <see cref="AinDevHelperLocalizedMessage"/>, представляющих собой локализации описания плагина на поддерживаемые AinDevHelper языки.<br/>
        /// [EN] The property returns a collection of <see cref="AinDevHelperLocalizedMessage"/> elements, representing localizations of the plugin description into languages supported by AinDevHelper.
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedDescriptions { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Свойство возвращает коллекцию действий, которые поддерживаются экземпляром плагина.<br/>
        /// [EN] The property returns a collection of actions that are supported by the plugin instance.
        /// </summary>
        public List<AinDevHelperPluginActionDescriptor> Actions { get; set; } = new List<AinDevHelperPluginActionDescriptor>();

        /// <summary>
        /// [RU] Конструктор без параметров, нужен для поддержки механизмов сериализации.<br/>
        /// [EN] A constructor without parameters, needed to support serialization mechanisms.
        /// </summary>
        public AinDevHelperPluginDescriptor() {
        }
    }
}
