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
using System;

namespace AinDevHelperPluginLibrary.Language {
    /// <summary>
    /// [RU] Класс содержит свойства для локализации интерфейса AinDevHelper на один из поддерживаемых языков
    /// [EN] The class contains properties for localizing the AinDevHelper interface into one of the supported languages
    /// </summary>
    [Serializable]
    public class AinDevHelperLanguage {
        /// <summary>
        /// [RU] Код поддерживаемого языка
        /// [EN] Supported language code
        /// </summary>
        public virtual string LanguageCode { get; set; } = "ru";

        /// <summary>
        /// [RU] Читаемое название поддерживаемого языка, будет отображаться в выпадающем меню в интерфейсе AinDevHelper
        /// [EN] The readable name of the supported language will be displayed in the drop-down menu in the AinDevHelper interface
        /// </summary>
        public virtual string LanguageName { get; set; } = "Русский";

        /// <summary>
        /// [RU] Название заголовка для главного окна AinDevHelper
        /// [EN] Header name for the main AinDevHelper window 
        /// </summary>
        public virtual string WindowAppTitle { get; set; } = "Помощник Разработчика";      

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Файл"
        /// [EN] Localization for the main menu item "File"
        /// </summary>
        public virtual string MainMenuFile { get; set; } = "&Файл";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Правка"
        /// [EN] Localization for the main menu item "Edit"
        /// </summary>
        public virtual string MainMenuEdit { get; set; } = "&Правка";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Вид"
        /// [EN] Localization for the main menu item "View"
        /// </summary>
        public virtual string MainMenuView { get; set; } = "&Вид";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Плагины"
        /// [EN] Localization for the main menu item "Plugins"
        /// </summary>
        public virtual string MainMenuPlugins { get; set; } = "П&лагины";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Инструменты"
        /// [EN] Localization for the main menu item "Tools"
        /// </summary>
        public virtual string MainMenuTools { get; set; } = "&Инструменты";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Среды разработки"
        /// [EN] Localization for the main menu item "IDEs"
        /// </summary>
        public virtual string MainMenuIDEs { get; set; } = "&Среды разработки";

        /// <summary>
        /// [RU] Локализация для пункта главного меню "Помощь"
        /// [EN] Localization for the main menu item "Help"
        /// </summary>
        public virtual string MainMenuHelp { get; set; } = "П&омощь";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Установить плагины для AinDevHelper..."
        /// [EN] Localization for the menu item "File" -> "Install plugins for AinDevHelper..."
        /// </summary>
        public virtual string MenuFileInstallPlugins { get; set; } = "Установить плагины для AinDevHelper...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Создать плагин на базе XML-дескриптора..."
        /// [EN] Localization for the menu item "File" -> "Create a plugin based on an XML descriptor..."
        /// </summary>
        public virtual string MenuFileCreatePluginBasedOnXMLDescriptor { get; set; } = "Создать плагин на базе XML-дескриптора...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Перечитать каталог с плагинами"
        /// [EN] Localization for the menu item "File" -> "Reread directory with plugins"
        /// </summary>
        public virtual string MenuFileReloadPluginsDirectory { get; set; } = "Перечитать каталог с плагинами";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть каталог AinDevHelper в Проводнике"
        /// [EN] Localization for the menu item "File" -> "Open the AinDevHelper directory in Explorer"
        /// </summary>
        public virtual string MenuFileOpenAppDirectoryInExplorer { get; set; } = "Открыть каталог AinDevHelper в Проводнике";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть каталог плагинов в Проводнике"
        /// [EN] Localization for the menu item "File" -> "Open the plugin directory in Explorer"
        /// </summary>
        public virtual string MenuFileOpenPluginsDirectoryInExplorer { get; set; } = "Открыть каталог плагинов в Проводнике";


        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Запустить Windows PowerShell"
        /// [EN] Localization for the menu item "File" -> "Run Windows PowerShell"
        /// </summary>
        public virtual string MenuFileStartWindowsPowerShell { get; set; } = "Запустить Windows PowerShell";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Запустить Windows PowerShell под Администратором"
        /// [EN] Localization for the menu item "File" -> "Run Windows PowerShell as Administrator"
        /// </summary>
        public virtual string MenuFileStartWindowsPowerShellAsAdministrator { get; set; } = "Запустить Windows PowerShell под Администратором";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть командную строку (cmd)"
        /// [EN] Localization for the menu item "File" -> "Open command line (cmd)"
        /// </summary>
        public virtual string MenuFileOpenCommandLine { get; set; } = "Открыть командную строку (cmd)";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть командную строку (cmd) под Администратором"
        /// [EN] Localization for the menu item "File" -> "Open command line (cmd) as Administrator"
        /// </summary>
        public virtual string MenuFileOpenCommandLineAsAdiministrator { get; set; } = "Открыть командную строку (cmd) под Администратором";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть командную строку (cmd) в каталоге..."
        /// [EN] Localization for the menu item "File" -> "Open command line (cmd) in the directory..."
        /// </summary>
        public virtual string MenuFileOpenCommandLineInDirectory { get; set; } = "Открыть командную строку (cmd) в каталоге...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Открыть командную строку (cmd) или Windows PowerShell в каталоге..."
        /// [EN] Localization for the menu item "File" -> "Open command line (cmd) or Windows PowerShell in the directory..."
        /// </summary>
        public virtual string MenuFileOpenCommandLineOrWindowsPowerShellInDirectory { get; set; } = "Открыть командную строку (cmd) или Windows PowerShell в каталоге...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Язык программы"
        /// [EN] Localization for the menu item "File" -> "Program language"
        /// </summary>
        public virtual string MenuFileAppLanguage { get; set; } = "Язык программы";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Настройки"
        /// [EN] Localization for the menu item "File" -> "Settings"
        /// </summary>
        public virtual string MenuFileSettings { get; set; } = "Настройки";

        /// <summary>
        /// [RU] Локализация для пункта меню "Файл" -> "Выход"
        /// [EN] Localization for the menu item "File" -> "Exit"
        /// </summary>
        public virtual string MenuFileExit { get; set; } = "Выход";

        /// <summary>
        /// [RU] Локализация для пункта меню "Правка" -> "Быстрый поиск..."
        /// [EN] Localization for the menu item "Edit" -> "Quick Search..."
        /// </summary>
        public virtual string MenuEditQuickSearch { get; set; } = "Быстрый поиск...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Правка" -> "Найти плагин..."
        /// [EN] Localization for the menu item "Edit" -> "Find plugin..."
        /// </summary>
        public virtual string MenuEditFindPlugin { get; set; } = "Найти плагин...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Правка" -> "Найти действие..."
        /// [EN] Localization for the menu item "Edit" -> "Find action..."
        /// </summary>
        public virtual string MenuEditFindAction { get; set; } = "Найти действие...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Правка" -> "Очистить лог событий"
        /// [EN] Localization for the menu item "Edit" -> "Clear event log"
        /// </summary>
        public virtual string MenuEditClearEventLog { get; set; } = "Очистить лог событий";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать в статусной строке количество установленных плагинов"
        /// [EN] Localization for the menu item "View" -> "Show the number of installed plugins in the status bar"
        /// </summary>
        public virtual string MenuViewShowInstalledPluginsInStatusBar { get; set; } = "Показывать в статусной строке количество установленных плагинов";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать в статусной строке имя текущего плагина"
        /// [EN] Localization for the menu item "View" -> "Show the name of the current plugin in the status bar"
        /// </summary>
        public virtual string MenuViewShowCurrentPluginInStatusBar { get; set; } = "Показывать в статусной строке имя текущего плагина";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать основной тулбар"
        /// [EN] Localization for the menu item "View" -> "Show main toolbar"
        /// </summary>
        public virtual string MenuViewShowMainToolbar { get; set; } = "Показывать основной тулбар";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать тулбар над деревом плагинов"
        /// [EN] Localization for the menu item "View" -> "Show toolbar above the plugin tree"
        /// </summary>
        public virtual string MenuViewToolbarForPluginsTree { get; set; } = "Показывать тулбар над деревом плагинов";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Все действия' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'All Actions' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowAllActionsButton { get; set; } = "Показывать кнопку \"Все действия\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Действия без параметров' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Actions Without Parameters' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowNoParamsActionsButton { get; set; } = "Показывать кнопку \"Действия без параметров\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Действия с параметрами' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Actions With Parameters' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowParameterizedActionsButton { get; set; } = "Показывать кнопку \"Действия с параметрами\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Действия на генерацию' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Generation Actions' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowGenerationActionsButton { get; set; } = "Показывать кнопку \"Действия на генерацию\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Веб-ссылки' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Web Links' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowWebLinksActionsButton { get; set; } = "Показывать кнопку \"Веб-ссылки\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Очистить лог' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Clear Event Log' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowClearEventLogButton { get; set; } = "Показывать кнопку \"Очистить лог\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Быстрый поиск' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Quick Search' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowQuickSearchButton { get; set; } = "Показывать кнопку \"Быстрый поиск\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Показывать кнопку 'Настройки' на основном тулбаре"
        /// [EN] Localization for the menu item "View" -> "Show the 'Settings' button on the main toolbar"
        /// </summary>
        public virtual string MenuViewShowSettingsButton { get; set; } = "Показывать кнопку \"Настройки\" на основном тулбаре";

        /// <summary>
        /// [RU] Локализация для пункта меню "Вид" -> "Развернуть окно на весь экран"
        /// [EN] Localization for the menu item "View" -> "Maximize window to full screen"
        /// </summary>
        public virtual string MenuViewMaximizeMainAppWindow { get; set; } = "Развернуть окно на весь экран";

        /// <summary>
        /// [RU] Локализация для пункта меню "Инструменты" -> "Сгенерировать GUID..."
        /// [EN] Localization for the menu item "Tools" -> "Generate GUID..."
        /// </summary>
        public virtual string MenuToolsGenerateGUID { get; set; } = "Сгенерировать GUID...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Инструменты" -> "Конвертер цветов..."
        /// [EN] Localization for the menu item "Tools" -> "Color Converter..."
        /// </summary>
        public virtual string MenuToolsColorConverter { get; set; } = "Конвертер цветов...";

        /// <summary>
        /// [RU] Локализация для пункта меню "Инструменты" -> "Конвертер символов в коды..."
        /// [EN] Localization for the menu item "Tools" -> "Converter of characters to codes..."
        /// </summary>
        public virtual string MenuToolsCharsConverter { get; set; } = "Конвертер символов в коды...";

        public virtual string MenuToolsCalculateStringLength { get; set; } = "Подсчитать длину строки...";

        public virtual string MenuHelpNavigateToAllineedRuMainPage { get; set; } = "Перейти на главную страницу Allineed.Ru";
        public virtual string MenuHelpJoinAllineedRuMainTelegramGroup { get; set; } = "Присоединиться к основной группе Allineed.Ru в Telegram";
        public virtual string MenuHelpHotKeysCombinations { get; set; } = "Справка по быстрым сочетаниям клавиш...";
        public virtual string MenuHelpOpenOfflineHelp { get; set; } = "Оффлайн-справка по программе AinDevHelper";
        public virtual string MenuHelpReportABug { get; set; } = "Сообщить разработчикам о проблеме...";
        public virtual string MenuHelpAboutProgram { get; set; } = "О программе AinDevHelper...";

        /// <summary>
        /// [RU] Локализация для вкладки "Основное" на главной форме приложения
        /// [EN] Localization for the "Main Info" tab on the main application form
        /// </summary>
        public virtual string TabPageMainInfo { get; set; } = "Основное";

        /// <summary>
        /// [RU] Локализация для вкладки "Действия" на главной форме приложения
        /// [EN] Localization for the "Actions" tab on the main application form
        /// </summary>
        public virtual string TabPageActions { get; set; } = "Действия";

        /// <summary>
        /// [RU] Локализация для вкладки "Справка" на главной форме приложения
        /// [EN] Localization for the "Help" tab on the main application form
        /// </summary>
        public virtual string TabPageHelp { get; set; } = "Справка";

        /// <summary>
        /// [RU] Локализация для вкладки "Лог событий" на главной форме приложения
        /// [EN] Localization for the "Event Log" tab on the main application form
        /// </summary>
        public virtual string TabPageEventLog { get; set; } = "Лог событий";

        /// <summary>
        /// [RU] Локализация для метки "Установленных плагинов:" в статусной строке приложения
        /// [EN] Localization for the "Installed plugins:" label in the application status bar
        /// </summary>
        public virtual string StatusLabelInstalledPluginsCount { get; set; } = "Установленных плагинов:";

        /// <summary>
        /// [RU] Локализация для метки "Текущий плагин:" в статусной строке приложения
        /// [EN] Localization for the "Current Plugin:" label in the application status bar
        /// </summary>
        public virtual string StatusLabelCurrentPlugin { get; set; } = "Текущий плагин:";

        /// <summary>
        /// [RU] Локализация для метки по умолчанию с названием текущего плагина в статусной строке приложения
        /// [EN] Localization for the default label with the name of the current plugin in the application status bar
        /// </summary>
        public virtual string StatusLabelCurrentPluginDefaultValue { get; set; } = "[Плагин не выбран]";

        /// <summary>
        /// [RU] Локализация для метки "Статус:" в статусной строке приложения
        /// [EN] Localization for the "Status:" label in the application status bar
        /// </summary>
        public virtual string StatusLabelStatus { get; set; } = "Статус:";

        /// <summary>
        /// [RU] Локализация для названия статуса "Готов" в статусной строке приложения
        /// [EN] Localization for the status name "Ready" in the application status bar
        /// </summary>
        public virtual string StatusReady { get; set; } = "Готов.";

        /// <summary>
        /// [RU] Локализация для названия статуса "Выполняю действие плагина..." в статусной строке приложения
        /// [EN] Localization for the status name "Executing the Plugin Action..." in the application status bar
        /// </summary>
        public virtual string StatusExecutingPluginAction { get; set; } = "Выполняю действие плагина...";

        /// <summary>
        /// [RU] Локализация сообщения "Пожалуйста, подождите..."
        /// [EN] Localization of the message "Please wait..."
        /// </summary>
        public virtual string MsgPleaseWait { get; set; } = "Пожалуйста, подождите...";

        /// <summary>
        /// [RU] Локализация сообщения "Программа загружена." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "The program has been loaded." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgProgramHasBeenLoaded { get; set; } = "Программа загружена.";

        /// <summary>
        /// [RU] Локализация сообщения "Инициализация хоста для доступных плагинов..." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "Initializing host for available plugins..." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgInitializingPluginsHost { get; set; } = "Инициализация хоста для доступных плагинов...";

        /// <summary>
        /// [RU] Локализация сообщения "Установленных плагинов не обнаружено." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "No installed plugins found." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgNoInstalledPluginsFound { get; set; } = "Установленных плагинов не обнаружено.";

        /// <summary>
        /// [RU] Локализация сообщения "Загрузка установленных плагинов..." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "Loading installed plugins..." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgLoadingInstalledPlugins { get; set; } = "Загрузка установленных плагинов...";

        /// <summary>
        /// [RU] Локализация сообщения "Инициализация плагина '{0}'..." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "Initializing plugin '{0}'..." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgInitializingPlugin { get; set; } = "Инициализация плагина '{0}'...";

        /// <summary>
        /// [RU] Локализация сообщения "Отображение основной информации для плагина '{0}'..." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "Displaying main information for plugin '{0}'..." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgShowingMainInfoForPlugin { get; set; } = "Отображение основной информации для плагина '{0}'...";

        /// <summary>
        /// [RU] Локализация сообщения "Получение действий для плагина '{0}'..." для лога событий, отображаемого на вкладке "Лог событий"
        /// [EN] Localization of the message "Getting actions for plugin '{0}'..." for the event log displayed on the "Event Log" tab
        /// </summary>
        public virtual string MsgGettingActionsForPlugin { get; set; } = "Получение действий для плагина '{0}'...";

        public virtual string MsgExecutingActionForPlugin { get; set; } = "Выполнение действия '{0}' для плагина '{1}'...";
        public virtual string MsgExecutingParameterizedActionForPlugin { get; set; } = "Выполнение параметризованного действия '{0}' для плагина '{1}'...";
        public virtual string MsgErrorDuringParticularPluginActionExecution { get; set; } = "При выполнении действия '{0}' плагина возникла ошибка: '{1}'";
        public virtual string MsgErrorDuringPluginActionExecution { get; set; } = "При выполнении действия плагина возникла ошибка:";
        public virtual string MsgStacktrace { get; set; } = "Трассировка стека:";
        public virtual string MsgRecommendationsForTroubleshooting { get; set; } = "Рекомендации по устранению ошибки:";
        public virtual string MsgTroubleshootingRunActionMethod1 { get; set; } = "1) Убедитесь, что плагин, для которого было вызвано действие, реализует в своём коде метод RunAction(AinDevHelperPluginAction actionToRun)";
        public virtual string MsgTroubleshootingRunActionMethod2 { get; set; } = "2) Убедитесь, что реализованный метод RunAction(AinDevHelperPluginAction actionToRun) плагина не выбрасывает необработанных плагином исключений во время своей работы.";
        public virtual string MsgPluginReportedItHasNoImplementedActions { get; set; } = "Плагин '{0}' сообщил об ошибке (NotImplementedException). Это значит, что плагин пока не имеет реализованных действий.";
        public virtual string MsgPluginCausedUnexpectedError { get; set; } = "Плагин '{0}' сообщил об ошибке (Exception).";

        /// <summary>
        /// [RU] Локализация для метки "Название плагина:" на вкладке "Основное"
        /// [EN] Localization for the "Plugin Name:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginName { get; set; } = "Название плагина:";

        /// <summary>
        /// [RU] Локализация для метки "Организация / Производитель:" на вкладке "Основное"
        /// [EN] Localization for the "Organization / Manufacturer:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginCompany { get; set; } = "Организация / Производитель:";

        /// <summary>
        /// [RU] Локализация для метки "Автор плагина:" на вкладке "Основное"
        /// [EN] Localization for the "Author:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginAuthor { get; set; } = "Автор плагина:";

        /// <summary>
        /// [RU] Локализация для метки "Email автора плагина:" на вкладке "Основное"
        /// [EN] Localization for the "Plugin author email:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginAuthorEmail { get; set; } = "E-mail автора плагина:";


        /// <summary>
        /// [RU] Локализация для метки "Версия плагина:" на вкладке "Основное"
        /// [EN] Localization for the "Version:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginVersion { get; set; } = "Версия плагина:";

        /// <summary>
        /// [RU] Локализация для метки "Теги плагина:" на вкладке "Основное"
        /// [EN] Localization for the "Tags:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginTags { get; set; } = "Теги плагина:";

        /// <summary>
        /// [RU] Локализация для метки "Веб-сайт разработчика:" на вкладке "Основное"
        /// [EN] Localization for the "Developer Website:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelAuthorSiteURL { get; set; } = "Веб-сайт разработчика:";

        /// <summary>
        /// [RU] Локализация для метки "Описание:" на вкладке "Основное"
        /// [EN] Localization for the "Description:" label on the "Main Info" tab
        /// </summary>
        public virtual string TabPageMainInfoLabelPluginDescription { get; set; } = "Описание:";

        /// <summary>
        /// [RU] Локализация для метки "Доступные действия плагина "{0}":" на вкладке "Действия"
        /// [EN] Localization for the "Available actions for plugin "{0}":" label on the "Actions" tab
        /// </summary>
        public virtual string TabPageActionsAvailablePluginActions { get; set; } = "Доступные действия плагина \"{0}\":";

        /// <summary>
        /// [RU] Локализация для метки "Результат выполнения действия:" на вкладке "Действия"
        /// [EN] Localization for the "Result of the action execution:" label on the "Actions" tab
        /// </summary>
        public virtual string TabPageActionsActionResult { get; set; } = "Результат выполнения действия:";

        /// <summary>
        /// [RU] Локализация для кнопки "Выполнить действие" на вкладке "Действия"
        /// [EN] Localization for the "Execute Action" button on the "Actions" tab
        /// </summary>
        public virtual string ButtonExecutePluginAction { get; set; } = "Выполнить действие";

        /// <summary>
        /// [RU] Локализация для заголовка всплывающего окна с подсказкой при наведении курсора мыши на элементы интерфейса
        /// [EN] Localization for the title of the pop-up window with a tooltip when hovering the mouse over interface elements
        /// </summary>
        public virtual string ToolTipTitle { get; set; } = "Подсказка";

        /// <summary>
        /// [RU] Локализация для текста подсказки во всплывающем окне при наведении курсора мыши на кнопку "Выполнить действие" на вкладке "Действия"
        /// [EN] Localization for tooltip text in the popup when hovering the mouse over the "Execute Action" button on the "Actions" tab
        /// </summary>
        public virtual string ToolTipForButtonExecutePluginAction { get; set; } = "Запустить выбранное доступное действие плагина";

        /// <summary>
        /// [RU] Локализация для текста подсказки во всплывающем окне при наведении курсора мыши на кнопку "Копировать" на вкладке "Действия"
        /// [EN] Localization for tooltip text in the popup when hovering the mouse over the "Copy" button on the "Actions" tab
        /// </summary>
        public virtual string ToolTipForButtonCopyActionResult { get; set; } = "Копировать результат выполнения действия в буфер обмена";

        /// <summary>
        /// [RU] Локализация для текста подсказки во всплывающем окне при наведении курсора мыши на кнопку "Очистить" на вкладке "Действия"
        /// [EN] Localization for tooltip text in the popup when hovering the mouse over the "Clear" button on the "Actions" tab
        /// </summary>
        public virtual string ToolTipForButtonClearActionResult { get; set; } = "Очистить результат выполнения действия";

        /// <summary>
        /// [RU] Локализация для выпадающей кнопки "Все действия" в главном тулбаре
        /// [EN] Localization for the "All Actions" drop-down button in the main toolbar
        /// </summary>
        public virtual string ToolStripDropDownButtonAllActions { get; set; } = "Все действия";

        /// <summary>
        /// [RU] Локализация для выпадающей кнопки "Действия без параметров" в главном тулбаре
        /// [EN] Localization for the "Actions without parameters" drop-down button in the main toolbar
        /// </summary>
        public virtual string ToolStripDropDownButtonNoParamsActions { get; set; } = "Действия без параметров";

        /// <summary>
        /// [RU] Локализация для выпадающей кнопки "Действия с параметрами" в главном тулбаре
        /// [EN] Localization for the "Actions with parameters" drop-down button in the main toolbar
        /// </summary>
        public virtual string ToolStripDropDownButtonParameterizedActions { get; set; } = "Действия с параметрами";

        /// <summary>
        /// [RU] Локализация для выпадающей кнопки "Действия на генерацию" в главном тулбаре
        /// [EN] Localization for the "Generation Actions" drop-down button in the main toolbar
        /// </summary>
        public virtual string ToolStripDropDownButtonGenerationActions { get; set; } = "Действия на генерацию";

        /// <summary>
        /// [RU] Локализация для выпадающей кнопки "Веб-ссылки" в главном тулбаре
        /// [EN] Localization for the "Web Links" drop-down button in the main toolbar
        /// </summary>
        public virtual string ToolStripDropDownButtonWebLinkActions { get; set; } = "Веб-ссылки";

        /// <summary>
        /// [RU] Локализация для кнопки "Очистить лог" в главном тулбаре
        /// [EN] Localization for the "Clear Event Log" button in the main toolbar
        /// </summary>
        public virtual string ToolStripButtonClearEventLog { get; set; } = "Очистить лог";

        /// <summary>
        /// [RU] Локализация для кнопки "Быстрый поиск" в главном тулбаре
        /// [EN] Localization for the "Quick Search" button in the main toolbar
        /// </summary>
        public virtual string ToolStripButtonQuickSearchToolbar { get; set; } = "Быстрый поиск";

        /// <summary>
        /// [RU] Локализация для кнопки "Настройки" в главном тулбаре
        /// [EN] Localization for the "Settings" button in the main toolbar
        /// </summary>
        public virtual string ToolStripButtonSettings { get; set; } = "Настройки";

        /// <summary>
        /// [RU] Локализация для узла "Действия" в дереве плагинов
        /// [EN] Localization for the "Actions" node in the plugin tree
        /// </summary>
        public virtual string PluginsTreeNodeActions { get; set; } = "Действия";

        /// <summary>
        /// [RU] Локализация для общего сообщения "Пожалуйста, подождите..."
        /// [EN] Localization for the general message "Please wait..."
        /// </summary>
        [Obsolete]
        public virtual string CommonMsgPleaseWait { get; set; } = "Пожалуйста, подождите...";

        /// <summary>
        /// [RU] Локализация для общего сообщения "Теги действия:"
        /// [EN] Localization for the general message "Action tags:"
        /// </summary>
        public virtual string CommonMsgActionTags { get; set; } = "Теги действия:";

        /// <summary>
        /// [RU] Локализация для общего сообщения "Теги плагина:"
        /// [EN] Localization for the general message "Plugin tags:"
        /// </summary>
        public virtual string CommonMsgPluginTags { get; set; } = "Теги плагина:";

        /// <summary>
        /// [RU] Локализация для заголовка диалогового окна "Конвертер цветов", доступного из пункта главного меню "Инструменты"
        /// [EN] Localization for the title of the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string SearchFormQuickSearchDialogTitle { get; set; } = "Быстрый поиск";

        public virtual string SearchFormQuickSearchLabelEnterSearchPattern { get; set; } = "Введите часть имени плагина, действия или их тегов:";
        public virtual string SearchFormQuickSearchLabelSearchFor { get; set; } = "Искать:";
        public virtual string SearchFormQuickSearchRadioButtonSearchAll { get; set; } = "Плагины и действия";
        public virtual string SearchFormQuickSearchRadioButtonOnlyPlugins { get; set; } = "Только плагины";
        public virtual string SearchFormQuickSearchRadioButtonOnlyActions { get; set; } = "Только действия";
        public virtual string SearchFormCheckBoxIgnoreCaseSearch { get; set; } = "Поиск без учёта регистра";

        public virtual string SearchFormLabelSearchForActionTypes { get; set; } = "Искать типы действий:";
        public virtual string SearchFormCheckBoxNoParamsActions { get; set; } = "Без параметров";
        public virtual string SearchFormCheckBoxParameterizedActions { get; set; } = "С параметрами";
        public virtual string SearchFormCheckBoxGenerationActions { get; set; } = "Генерация";
        public virtual string SearchFormCheckBoxWebLinkActions { get; set; } = "Веб-ссылки";

        public virtual string SearchFormQuickSearchLabelFoundElements { get; set; } = "Найденные элементы:";
        public virtual string SearchFormGoToFoundElementButtonTitle { get; set; } = "Перейти к элементу";
        public virtual string SearchFormCancelButtonTitle { get; set; } = "Отмена";


        public virtual string SearchFormFindPluginDialogTitle { get; set; } = "Найти плагин";
        public virtual string SearchFormFindPluginLabelEnterSearchPattern { get; set; } = "Введите часть имени плагина или его тегов:";
        public virtual string SearchFormFindPluginLabelFoundElements { get; set; } = "Найденные плагины:";
        public virtual string SearchFormFindPluginGoToFoundPluginButtonTitle { get; set; } = "Перейти к плагину";


        public virtual string SearchFormFindActionDialogTitle { get; set; } = "Найти действие";
        public virtual string SearchFormFindActionLabelEnterSearchPattern { get; set; } = "Введите часть имени действия или его тегов:";
        public virtual string SearchFormFindActionLabelFoundElements { get; set; } = "Найденные действия:";
        public virtual string SearchFormFindActionGoToFoundActionButtonTitle { get; set; } = "Перейти к действию";



        /// <summary>
        /// [RU] Локализация для заголовка диалогового окна "Конвертер цветов", доступного из пункта главного меню "Инструменты"
        /// [EN] Localization for the title of the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterDialogTitle { get; set; } = "Конвертер цветов";

        /// <summary>
        /// [RU] Локализация для метки "Выберите нужный цвет, кликнув мышью на квадрат слева или задайте параметры цвета вручную в текстовых полях:" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Select the desired color by clicking on the square on the left or set the color parameters manually in the text fields:" in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterLabelChooseColor { get; set; } = "Выберите нужный цвет, кликнув мышью на квадрат слева или задайте параметры цвета вручную в текстовых полях:";

        /// <summary>
        /// [RU] Локализация для метки "Int-значение =" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Int value =" in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterLabelIntColorValue { get; set; } = "Int-значение =";

        /// <summary>
        /// [RU] Локализация для заголовка "Другие опции копирования в буфер обмена:" группы кнопок в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the heading "Other copy to clipboard options:" of the group of buttons in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterOtherCopyOptionsGroupBoxTitle { get; set; } = "Другие опции копирования в буфер обмена:";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать значение красного (R)" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy Red Value (R)" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyRedValueButtonTitle { get; set; } = "Копировать значение красного (R)";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать значение зелёного (G)" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy Green Value (G)" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyGreenValueButtonTitle { get; set; } = "Копировать значение зелёного (G)";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать значение синего (B)" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy Blue Value (B)" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyBlueValueButtonTitle { get; set; } = "Копировать значение синего (B)";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать значение Альфа-канала (A)" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy Alpha Channel Value (A)" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyAlphaValueButtonTitle { get; set; } = "Копировать значение Альфа-канала (A)";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать HEX-представление цвета" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy HEX Representation of Color" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyHexValueButtonTitle { get; set; } = "Копировать HEX-представление цвета";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать HEX-представление цвета с Альфа-каналом" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy HEX Representation of Color with Alpha Channel" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyExtendedHexValueButtonTitle { get; set; } = "Копировать HEX-представление цвета с Альфа-каналом";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать Int-представление цвета" в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy Int Representation of Color" button in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyIntColorValueButtonTitle { get; set; } = "Копировать Int-представление цвета";

        /// <summary>
        /// [RU] Локализация для префикса "Копировать", используемого в названиях кнопок в диалоговом окне "Конвертер цветов", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy" prefix used in the button names in the "Color Converter" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormColorConverterCopyButtonsPrefix { get; set; } = "Копировать";

        /// <summary>
        /// [RU] Локализация для заголовка диалогового окна "Конвертер символов в коды", доступного из пункта главного меню "Инструменты"
        /// [EN] Localization for the title of the "Converter of characters to codes" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormCharsConverterDialogTitle { get; set; } = "Конвертер символов в коды";        

        /// <summary>
        /// [RU] Локализация для метки "Введите символ или символы:" в диалоговом окне "Конвертер символов в коды", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Enter a character or characters:" in the "Converter of characters to codes" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormCharsConverterLabelChooseColor { get; set; } = "Введите символ или символы:";

        /// <summary>
        /// [RU] Локализация для метки "Коды символов:" в диалоговом окне "Конвертер символов в коды", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Character codes:" in the "Converter of characters to codes" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormCharsConverterLabelCharacterCodes { get; set; } = "Коды символов:";

        /// <summary>
        /// [RU] Локализация для сообщения "Символ:" в диалоговом окне "Конвертер символов в коды", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Symbol:" in the "Converter of characters to codes" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormCharsConverterMsgSymbol { get; set; } = "Символ:";

        /// <summary>
        /// [RU] Локализация для сообщения "Код:" в диалоговом окне "Конвертер символов в коды", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the label "Code:" in the "Converter of characters to codes" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormCharsConverterMsgCode { get; set; } = "Код:";


        /// <summary>
        /// [RU] Локализация для заголовка диалогового окна "Сгенерировать GUID", доступного из пункта главного меню "Инструменты"
        /// [EN] Localization for the title of the "Generate GUID" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormGenerateGUIDDialogTitle { get; set; } = "Сгенерировать GUID";

        /// <summary>
        /// [RU] Локализация для кнопки "Сгенерировать следующий GUID" в диалоговом окне "Сгенерировать GUID", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Generate next GUID" button in the "Generate GUID" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormGenerateGUIDGenerateGUIDButtonTitle { get; set; } = "Сгенерировать следующий GUID";

        /// <summary>
        /// [RU] Локализация для кнопки "Копировать GUID в буфер обмена" в диалоговом окне "Сгенерировать GUID", доступном из пункта главного меню "Инструменты"
        /// [EN] Localization for the "Copy GUID to Clipboard" button in the "Generate GUID" dialog box, accessible from the "Tools" main menu item
        /// </summary>
        public virtual string ToolFormGenerateGUIDCopyGUIDToClipboardButtonTitle { get; set; } = "Копировать GUID в буфер обмена";

        public virtual string ToolFormCalculateStringLengthDialogTitle { get; set; } = "Подсчитать длину строки";
        public virtual string ToolFormCalculateStringLengthLabelEnterAString { get; set; } = "Введите строку для подсчёта количества символов в ней:";
        public virtual string ToolFormCalculateStringLengthLabelNumberOfCharactersInString { get; set; } = "Количество символов в строке:";
        public virtual string ToolFormCalculateStringLengthCopyNumberOfCharactersInStringButtonTitle { get; set; } = "Копировать количество символов в строке";        

        public virtual string SettingsFormDialogTitle { get; set; } = "Настройки";
        public virtual string SettingsFormSectionMain { get; set; } = "Основные";
        public virtual string SettingsFormSectionQuickSearch { get; set; } = "Быстрый поиск";
        public virtual string SettingsFormSectionPlugins { get; set; } = "Плагины";
        public virtual string SettingsFormSectionView { get; set; } = "Вид";
        public virtual string SettingsFormSectionTools { get; set; } = "Инструменты";
        public virtual string SettingsFormSectionIDEs { get; set; } = "Среды разработки";
        public virtual string SettingsFormSectionPluginSettings { get; set; } = "Настройки плагинов";

        [Obsolete]
        public virtual string SettingsFormErrorDialogTitle { get; set; } = "Ошибка";
        public virtual string SettingsFormUnsavedChangesDialogTitle { get; set; } = "Есть несохранённые изменения в настройках";

        public virtual string SettingsFormToolsErrMsgMissingToolNameOrExecutablePath { get; set; } = "Ошибка: введите название инструмента и путь до его исполняемого файла.";
        public virtual string SettingsFormIDEsErrMsgMissingIDENameOrExecutablePath { get; set; } = "Ошибка: введите название среды разработки и путь до её исполняемого файла.";
        public virtual string SettingsFormOpenFileForToolDialogTitle { get; set; } = "Выбрать избранный инструмент";
        public virtual string SettingsFormOpenFileForIDEDialogTitle { get; set; } = "Выбрать избранную среду разработки";
        public virtual string SettingsFormFilterExecutableFiles { get; set; } = "Исполняемые файлы (.exe)";
        public virtual string SettingsFormFilterBatFiles { get; set; } = "Пакетные файлы Windows (.bat)";
        public virtual string SettingsFormFilterCmdFiles { get; set; } = "Сценарии Windows (.cmd)";
        public virtual string SettingsFormFilterAllFiles { get; set; } = "Все файлы (*.*)";


        public virtual string SettingsFormTabQuickSearchCheckBoxEnabledAutocomplete { get; set; } = "Включить автодополнение при вводе текста для поиска в выпадающем списке";
        public virtual string SettingsFormTabQuickSearchCheckBoxLimitSearchResults { get; set; } = "Ограничить результаты поиска заданным количеством первых найденных элементов";
        public virtual string SettingsFormTabQuickSearchLabelLimitSearchResults { get; set; } = "Ограничить результаты поиска количеством первых найденных элементов (макс. 1000):";
        public virtual string SettingsFormTabQuickSearchCheckBoxExcludeTagsMatchesFromResults { get; set; } = "Исключить из результатов поиска совпадения по тегам для плагинов и действий";


        public virtual string SettingsFormTabPluginsCheckBoxEnableRemovalOfAlreadyInstalledPlugins { get; set; } = "Разрешить удаление уже установленных плагинов";
        public virtual string SettingsFormTabPluginsCheckBoxHidePluginsWithoutCurrentLanguageSupport { get; set; } = "Скрывать плагины, которые не поддерживают текущий язык интерфейса";
        public virtual string SettingsFormTabPluginsCheckBoxHidePluginsWithoutSupportedLanguages { get; set; } = "Скрывать плагины, которые не поддерживают все доступные языки интерфейса";

        public virtual string SettingsFormTabPluginsShowPluginsGroupBoxTitle { get; set; } = "Отображать плагины следующих типов:";
        public virtual string SettingsFormTabPluginsRadioButtonShowAllPluginTypes { get; set; } = "Все типы (*.dll, *.xml)";
        public virtual string SettingsFormTabPluginsRadioButtonShowAssemblyPluginsOnly { get; set; } = "Только сборки (*.dll)";
        public virtual string SettingsFormTabPluginsRadioButtonShowDescriptorBasedPluginsOnly { get; set; } = "Только на базе дескриптора (*.xml)";


        public virtual string SettingsFormTabViewCheckBoxEnableTooltipsForUIElements { get; set; } = "Включить всплывающие подсказки для элементов управления";
        public virtual string SettingsFormTabViewCheckBoxSaveCurrentSplitterDistance { get; set; } = "Сохранять текущую позицию разделителя между деревом плагинов и вкладками";
        public virtual string SettingsFormTabViewMainToolbarButtonsStyleGroupBoxTitle { get; set; } = "Вид кнопок основного тулбара:";
        public virtual string SettingsFormTabViewPluginsToolbarButtonsStyleGroupBoxTitle { get; set; } = "Вид кнопок тулбара над деревом плагинов:";

        public virtual string SettingsFormTabViewToolbarButtonsDisplayStyleText { get; set; } = "Текст";
        public virtual string SettingsFormTabViewToolbarButtonsDisplayStyleIcon { get; set; } = "Иконка";
        public virtual string SettingsFormTabViewToolbarButtonsDisplayStyleIconAndText { get; set; } = "Иконка и текст";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignTopLeft { get; set; } = "Верхний левый угол";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignTopCenter { get; set; } = "Вверху по центру";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignTopRight { get; set; } = "Верхний правый угол";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignMiddleLeft { get; set; } = "Слева посередине";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignMiddleCenter { get; set; } = "По центру";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignMiddleRight { get; set; } = "Справа посередине";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignBottomLeft { get; set; } = "Нижний левый угол";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignBottomCenter { get; set; } = "Снизу по центру";
        public virtual string SettingsFormTabViewToolbarButtonsImageAlignBottomRight { get; set; } = "Нижний правый угол";

        public virtual string SettingsFormTabViewToolbarButtonsTextImageRelationIconAboveText { get; set; } = "Иконка над текстом";
        public virtual string SettingsFormTabViewToolbarButtonsTextImageRelationTextAboveIcon { get; set; } = "Текст над иконкой";
        public virtual string SettingsFormTabViewToolbarButtonsTextImageRelationIconBeforeText { get; set; } = "Иконка перед текстом";
        public virtual string SettingsFormTabViewToolbarButtonsTextImageRelationTextBeforeIcon { get; set; } = "Текст перед иконкой";


        public virtual string SettingsFormTabToolsLabelListOfFavouriteTools { get; set; } = "Список избранных инструментов:";
        public virtual string SettingsFormTabToolsAddEditFavouriteToolGroupBoxTitle { get; set; } = "Добавить/Редактировать избранный инструмент:";
        public virtual string SettingsFormTabToolsLabelFavouriteToolName { get; set; } = "Название избранного инструмента:";
        public virtual string SettingsFormTabToolsLabelPathToFavouriteToolExecutable { get; set; } = "Путь до исполняемого файла для избранного инструмента:";
        public virtual string SettingsFormTabToolsAddFavouriteToolButtonTitle { get; set; } = "Добавить избранный инструмент";


        public virtual string SettingsFormTabIDEsLabelListOfFavouriteIDEs { get; set; } = "Список избранных сред разработки:";
        public virtual string SettingsFormTabIDEsAddEditFavouriteIDEGroupBoxTitle { get; set; } = "Добавить/Редактировать избранную среду разработки:";
        public virtual string SettingsFormTabIDEsLabelFavouriteIDEName { get; set; } = "Название избранной среды разработки:";
        public virtual string SettingsFormTabIDEsLabelPathToFavouriteIDEExecutable { get; set; } = "Путь до исполняемого файла для избранной среды разработки:";
        public virtual string SettingsFormTabIDEsAddFavouriteIDEButtonTitle { get; set; } = "Добавить избранную среду разработки";

        public virtual string SettingsFormBrowseButtonTitle { get; set; } = "Обзор...";
        public virtual string SettingsFormSaveChangesOnTabButtonTitle { get; set; } = "Сохранить изменения";

        public virtual string SettingsFormSaveChangesButtonTitle { get; set; } = "Сохранить";
        public virtual string SettingsFormSaveChangesAndCloseButtonTitle { get; set; } = "Сохранить и закрыть";
        public virtual string SettingsFormCloseButtonTitle { get; set; } = "Закрыть";


        public virtual string CommonErrorMsgFileDoesNotExist { get; set; } = "Ошибка: Файла '{0}' не существует";
        public virtual string CommonErrorDialogTitle { get; set; } = "Ошибка";
        public virtual string CommonErrorTooltipTitle { get; set; } = "Ошибка";
        public virtual string CommonValidationErrorsDialogTitle { get; set; } = "Ошибки валидации";
        public virtual string CommonValidationErrorsMessage { get; set; } = "На форме присутствуют ошибки при заполнении полей. Пожалуйста, исправьте их перед продолжением.";

        public virtual string CommonActionParamTextDataType { get; set; } = "Текстовое поле";
        public virtual string CommonActionParamCheckBoxYesNoDataType { get; set; } = "Флажок (Да/Нет)";        
        public virtual string CommonActionParamDirectorySelectionDataType { get; set; } = "Выбор каталога";
        public virtual string CommonActionParamFileSelectionDataType { get; set; } = "Выбор файла";
        public virtual string CommonBrowseButtonTitle { get; set; } = "Обзор...";
        public virtual string CommonCancelButtonTitle { get; set; } = "Отмена";
        public virtual string CommonCloseButtonTitle { get; set; } = "Закрыть";
        public virtual string CommonSaveButtonTitle { get; set; } = "Сохранить";
        public virtual string CommonDeleteButtonTitle { get; set; } = "Удалить";
        public virtual string CommonEditButtonTitle { get; set; } = "Правка";
        public virtual string CommonClickToCopyMessage { get; set; } = "Кликните, чтобы скопировать в буфер обмена";
        public virtual string CommonMsgQuestionSaveChangesBeforeExit { get; set; } = "На форме есть несохранённые изменения. Сохранить их перед выходом?";
        public virtual string CommonMsgConfirmSavingChangesDialogTitle { get; set; } = "Подтвердите сохранение изменений";
        public virtual string CommonMsgVersion { get; set; } = "Версия";
        public virtual string CommonMsgErrorDetails { get; set; } = "Детали ошибки:";
        public virtual string CommonMsgUnexpectedErrorOccurred { get; set; } = "Произошла непредвиденная ошибка";
        public virtual string CommonMsgErrorOfflineHelpFilesNotFound { get; set; } = "Файлы {0} оффлайн-справки не были найдены в каталоге 'help' программы. Возможно, файлы справки были перемещены или удалены. Попробуйте вернуть файлы в каталог 'help' или переустановить программу заново.";
        public virtual string CommonMsgAreYouSureToRemoveSelectedPlugin { get; set; } = "Вы уверены, что хотите окончательно удалить плагин '{0}'?";
        public virtual string CommonMsgPluginRemovalIrreversibleChangesWarning { get; set; } = "При подтверждении данного действия каталог плагина будет безвозвратно удалён с диска вместе со всеми файлами плагина. Если Вы вновь захотите использовать плагин позднее, Вам потребуется его устанавливать заново.";
        public virtual string CommonMsgConfirmTheAction { get; set; } = "Подтвердите выполнение действия";
        public virtual string CommonMsgThePluginWasSuccessfullyRemoved { get; set; } = "Плагин '{0}' был успешно удалён.";
        public virtual string CommonMsgCompletedSuccessfully { get; set; } = "Успешно выполнено";
        public virtual string CommonMsgMailRecipientGreeting { get; set; } = "{0}, добрый день!";
        public virtual string CommonMsgMailContentPlaceholder { get; set; } = "[Введите здесь текст вашего сообщения...]";
        public virtual string CommonMsgMailBugReportContentPlaceholder { get; set; } = "[Введите здесь текст вашего сообщения и опишите детали ошибки, возникшей в программе AinDevHelper. Очень желательно предоставить подробные скриншоты с ошибкой и детальные шаги по её воспроизведению. Так мы быстрее сможем отреагировать и исправить ошибку в ближайшем обновлении AinDevHelper]";
        public virtual string CommonMsgMailSubjectQuestion { get; set; } = "Вопрос по продукту AinDevHelper";
        public virtual string CommonMsgMailSubjectBugReport { get; set; } = "Отчёт об ошибке по продукту AinDevHelper";
        public virtual string CommonMsgMailContentBestRegards { get; set; } = "С наилучшими пожеланиями,";
        public virtual string CommonMsgMailContentSignature { get; set; } = "[Ваше имя]";


        public virtual string CreateXmlPluginDialogTitle { get; set; } = "Создать плагин на базе XML-дескриптора";
        public virtual string CreateXmlPluginFormLabelPluginName { get; set; } = "Название плагина:";
        public virtual string CreateXmlPluginFormLabelPluginCompany { get; set; } = "Организация / Производитель:";
        public virtual string CreateXmlPluginFormLabelPluginAuthor { get; set; } = "Автор плагина:";
        public virtual string CreateXmlPluginFormLabelPluginVersion { get; set; } = "Версия плагина:";
        public virtual string CreateXmlPluginFormLabelPluginAuthorSiteURL { get; set; } = "Веб-сайт разработчика:";
        public virtual string CreateXmlPluginFormLabelPluginDescription { get; set; } = "Описание:";
        public virtual string CreateXmlPluginFormLabelPluginActions { get; set; } = "Действия плагина:";
        public virtual string CreateXmlPluginFormLabelPluginDirectoryName { get; set; } = "Название нового каталога для плагина в каталоге /plugins:";
        public virtual string CreateXmlPluginFormLabelPluginTags { get; set; } = "Теги плагина (вводите через запятую):";
        public virtual string CreateXmlPluginFormLabelPluginAuthorEmail { get; set; } = "E-mail автора плагина:";
        public virtual string CreateXmlPluginFormLabelPluginSupportedLanguages { get; set; } = "Языки, поддерживаемые плагином:";
        public virtual string CreateXmlPluginFormLabelSelectedPluginAction { get; set; } = "Выбранное действие:";
        
        public virtual string CreateXmlPluginFormAddPluginActionButtonTitle { get; set; } = "Добавить";
        public virtual string CreateXmlPluginFormEditPluginActionButtonTitle { get; set; } = "Правка";
        public virtual string CreateXmlPluginFormDeletePluginActionButtonTitle { get; set; } = "Удалить";
        public virtual string CreateXmlPluginFormCreatePluginButtonTitle { get; set; } = "Создать плагин";
        public virtual string CreateXmlPluginFormCancelButtonTitle { get; set; } = "Отмена";

        public virtual string CreateXmlPluginFormErrMsgDirectoryAlreadyExists { get; set; } = "Каталог '{0}' уже существует. Пожалуйста, выберите другое название каталога для создания нового плагина.";
        public virtual string CreateXmlPluginFormSuccessMsgPluginSuccessfullyCreated { get; set; } = "Плагин '{0}' успешно создан в каталоге '{1}'! Желаете открыть каталог плагина в Проводнике?";
        public virtual string CreateXmlPluginFormSuccessMsgPluginSuccessfullyCreatedDialogTitle { get; set; } = "Плагин создан успешно";
        public virtual string CreateXmlPluginFormSuccessMsgPluginSuccessfullyEdited { get; set; } = "Изменения для плагина '{0}' успешно сохранены!";
        public virtual string CreateXmlPluginFormSuccessMsgPluginSuccessfullyEditedDialogTitle { get; set; } = "Плагин сохранён успешно";
        public virtual string CreateXmlPluginFormErrMsgUnexpectedErrorWhenCreatingPlugin { get; set; } = "Возникла непредвиденная ошибка при создании плагина. Детали:";
        public virtual string CreateXmlPluginFormErrMsgUnexpectedErrorWhenSavingPlugin { get; set; } = "Возникла непредвиденная ошибка при сохранении изменений для плагина. Детали:";
        public virtual string CreateXmlPluginFormErrMsgMissingPluginName { get; set; } = "Вы должны указать имя плагина";
        public virtual string CreateXmlPluginFormErrMsgMissingPluginDescription { get; set; } = "Вы должны ввести описание для плагина. Поясните другим разработчикам, что делает Ваш плагин.";
        public virtual string CreateXmlPluginFormErrMsgMissingPluginDirectory { get; set; } = "Вы должны ввести название для каталога, в котором будет сохранён XML-дескриптор плагина. Это каталог внутри каталога 'plugins' относительно корневого каталога AinDevHelper.";
        public virtual string CreateXmlPluginFormErrMsgMissingPluginAuthor { get; set; } = "Введите имя автора плагина.";

        public virtual string EditXmlPluginDialogTitle { get; set; } = "Редактировать плагин на базе XML-дескриптора";
        public virtual string EditXmlPluginFormSavePluginButtonTitle { get; set; } = "Сохранить плагин";
        public virtual string EditXmlPluginFormLabelPluginDirectoryName { get; set; } = "Путь к каталогу плагина в каталоге /plugins:";

        public virtual string AddXmlPluginActionDialogTitle { get; set; } = "Добавить действие плагина";
        public virtual string AddXmlPluginActionEditDialogTitle { get; set; } = "Редактировать действие плагина";
        
        public virtual string AddXmlPluginActionFormTypeOfPluginActionGroupBoxTitle { get; set; } = "Тип действия плагина:";
        public virtual string AddXmlPluginActionFormRadioButtonNoParamsAction { get; set; } = "Действие без параметров";
        public virtual string AddXmlPluginActionFormRadioButtonParameterizedAction { get; set; } = "Действие с параметрами";
        public virtual string AddXmlPluginActionFormRadioButtonGenerationAction { get; set; } = "Действие на генерацию";
        public virtual string AddXmlPluginActionFormRadioButtonWebLinkAction { get; set; } = "Веб-ссылка";

        public virtual string AddXmlPluginActionFormLabelActionName { get; set; } = "Название действия:";
        public virtual string AddXmlPluginActionFormLabelActionID { get; set; } = "ID действия:";
        public virtual string AddXmlPluginActionFormLabelActionCommand { get; set; } = "Команда (процесс) для выполнения:";

        public virtual string AddXmlPluginActionFormLabelActionArguments { get; set; } = "Аргументы для команды:";

        public virtual string AddXmlPluginActionFormRedirectToFileGroupBoxTitle { get; set; } = "Перенаправление вывода в файл:";

        public virtual string AddXmlPluginActionFormCheckBoxRedirectToFile { get; set; } = "Перенаправлять вывод от выполнения действия в файл";
        public virtual string AddXmlPluginActionFormCheckBoxShowProcessWindow { get; set; } = "Показывать окно при запуске процесса";

        public virtual string AddXmlPluginActionFormLabelRedirectToFileName { get; set; } = "Имя файла:";

        public virtual string AddXmlPluginActionFormLabelWebLink { get; set; } = "Переход по указанной Веб-ссылке (URL) при выполнении действия:";
        public virtual string AddXmlPluginActionFormActionParametersGroupBoxTitle { get; set; } = "Параметры действия:";
        public virtual string AddXmlPluginActionFormLabelParameterName { get; set; } = "Название параметра (внутреннее):";

        public virtual string AddXmlPluginActionFormLabelParameterLabel { get; set; } = "Название параметра (метка на форме):";
        public virtual string AddXmlPluginActionFormLabelParameterDataType { get; set; } = "Тип данных параметра:";
        public virtual string AddXmlPluginActionFormLabelParameterDescription { get; set; } = "Описание параметра:";

        public virtual string AddXmlPluginActionFormAddActionParameterButtonTitle { get; set; } = "Добавить параметр плагина";

        public virtual string AddXmlPluginActionFormAddPluginActionButtonTitle { get; set; } = "Добавить действие плагина";
        public virtual string AddXmlPluginActionFormSavePluginActionButtonTitle { get; set; } = "Сохранить действие плагина";

        public virtual string AddXmlPluginActionFormCancelButtonTitle { get; set; } = "Отмена";

        public virtual string AddXmlPluginActionErrMsgEnterCommandForAction { get; set; } = "Введите команду для действия";
        public virtual string AddXmlPluginActionErrMsgEnterWebLinkForAction { get; set; } = "Введите Web-ссылку для действия";        
        public virtual string AddXmlPluginActionErrMsgEnterActionName { get; set; } = "Введите имя для действия";
        public virtual string AddXmlPluginActionErrMsgEnterActionID { get; set; } = "Введите ID для действия";
        public virtual string AddXmlPluginActionErrMsgParameterWithThisNameAlreadyExists { get; set; } = "Параметр с именем '{0}' уже существует. Выберите другое имя для добавления нового параметра.";


        public virtual string AddLocalizedMessageDialogTitle { get; set; } = "Добавить локализацию";
        public virtual string AddLocalizedMessageForFieldDialogTitle { get; set; } = "Добавить локализацию для поля '{0}'";
        public virtual string AddLocalizedMessageFormLabelLanguage { get; set; } = "Язык:";
        public virtual string AddLocalizedMessageFormLabelAddLocalizedMessage { get; set; } = "Добавить локализованную строку для выбранного языка:";
        public virtual string AddLocalizedMessageFormLabelEditLocalizedMessage { get; set; } = "Редактировать локализованную строку: [{0}]:{1}";
        public virtual string AddLocalizedMessageFormLabelAddedLocalizedStrings { get; set; } = "Добавленные локализованные строки:";
        public virtual string AddLocalizedMessageFormAddLocalizedMessageButtonTitle { get; set; } = "Добавить локализацию";
        public virtual string AddLocalizedMessageErrMsgCannotAddMoreThanOneLocalizedMessageForSingleLanguage { get; set; } = "Нельзя добавить более одного локализационного сообщения для одного и того же языка";
        public virtual string AddLocalizedMessageErrMsgCannotAddEmptyLocalizedMessage { get; set; } = "Нельзя добавить пустое локализационное сообщение";

        //AinCustomButtonAddLocalizedMessage

        //Добавить локализованную строку для выбранного языка:
        //LabelAddedLocalizedStrings
        public virtual string InstallPluginsFormDialogTitle { get; set; } = "Установить плагины для AinDevHelper";
        public virtual string InstallPluginsFormLabelSpecifyInstallationFiles { get; set; } = "Выберите расположение ZIP-архивов с плагинами AinDevHelper для их установки:";
        public virtual string InstallPluginsFormLabelYouCanDragAndDropPluginFilesHere { get; set; } = "Для установки плагинов Вы также можете просто перетащить один или несколько ZIP-архивов с упакованными плагинами AinDevHelper в эту область:";
        public virtual string InstallPluginsFormLabelDragAndDropZipPluginFilesToInstall { get; set; } = "Перетащите сюда один или несколько ZIP-архивов с упакованными плагинами AinDevHelper для их установки";
        public virtual string InstallPluginsFormLabelInstallationLog { get; set; } = "Лог установки:";
        public virtual string InstallPluginsFormLabelPluginsInstalled { get; set; } = "Установлено плагинов:";
        public virtual string InstallPluginsFormLabelInstalledNumberOfTotalCount { get; set; } = "из";
        public virtual string InstallPluginsFormClearFilesListButtonTitle { get; set; } = "Очистить список файлов";
        public virtual string InstallPluginsFormInstallButtonTitle { get; set; } = "Начать установку";

        public virtual string InstallPluginsFormErrMsgCouldNotProcessFile { get; set; } = "Не удалось обработать файл. Убедитесь, что он имеет поддерживаемое расширение и не повреждён.";
        public virtual string InstallPluginsFormErrMsgUnexpectedErrorDuringPluginInstallation { get; set; } = "Неизвестная ошибка при установке плагина.";
        public virtual string InstallPluginsFormErrMsgZipArchiveHasInvalidStructure { get; set; } = "ZIP-архив имеет неверную структуру. Внутри архива должен быть только каталог, в котором должны располагаться файлы плагина.";
        public virtual string InstallPluginsFormMsgSuccessfullyInstalledPlugin { get; set; } = "Успешно установлен плагин:";
        public virtual string InstallPluginsFormMsgErrorDuringPluginInstallation { get; set; } = "Ошибка при установке плагина:";
        public virtual string InstallPluginsFormMsgInstallationCompletedSuccessfully { get; set; } = "Установка успешно завершена!";
        public virtual string InstallPluginsFormMsgInstallationCompletedWithErrors { get; set; } = "Установка была завершена с ошибками. Некоторые плагины не были установлены. Проверьте записи логов установки для выявления ошибок.";
        
        public virtual string InstallPluginsFormChooseZipFilesDialogTitle { get; set; } = "Выбрать ZIP-архивы с плагинами AinDevHelper для установки";
        public virtual string InstallPluginsFormFilterZipAinDevHelperFiles { get; set; } = "ZIP-архивы с плагинами AinDevHelper (.zip)";

        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryDialogTitle { get; set; } = "Открыть командную строку (cmd) или Windows PowerShell в каталоге";
        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryLabelSpecifyDirectory { get; set; } = "Укажите каталог для его открытия в командной строке (cmd) или в Windows PowerShell:";
        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryOpenWPSAsAdminButtonTitle { get; set; } = "Открыть Windows PowerShell в указанном каталоге под Администратором";
        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryOpenWPSButtonTitle { get; set; } = "Открыть Windows PowerShell в указанном каталоге";
        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryOpenCmdAsAdminButtonTitle { get; set; } = "Открыть командную строку (cmd) в указанном каталоге под Администратором";
        public virtual string OpenCommandLineOrWindowsPowerShellInDirectoryOpenCmdButtonTitle { get; set; } = "Открыть командную строку (cmd) в указанном каталоге";

        public virtual string RunParameterizedPluginActionFormDialogTitle { get; set; } = "Запустить действие с параметрами";
        public virtual string RunParameterizedPluginActionFormExecutePluginActionButtonTitle { get; set; } = "Выполнить с параметрами";
        public virtual string RunParameterizedPluginActionFormCancelButtonTitle { get; set; } = "Отмена";

        public virtual string ToolbarForPluginsTreeExpandAllButtonTooltip { get; set; } = "Раскрыть всё";
        public virtual string ToolbarForPluginsTreeCollapseAllButtonTooltip { get; set; } = "Свернуть всё";
        public virtual string ToolbarForPluginsTreeQuickSearchButtonTooltip { get; set; } = "Быстрый поиск";


        public virtual string TreeCtxMenuOpenDirectoryOfSelectedPlugin { get; set; } = "Открыть каталог выбранного плагина";
        public virtual string TreeCtxMenuExpandNode { get; set; } = "Раскрыть узел";
        public virtual string TreeCtxMenuCollapseNode { get; set; } = "Свернуть узел";
        public virtual string TreeCtxMenuOpenPluginXmlDescriptorFile { get; set; } = "Открыть файл XML-дескриптора для плагина";
        public virtual string TreeCtxMenuEditXmlDescriptorBasedPlugin { get; set; } = "Редактировать плагин на базе XML-дескриптора";
        public virtual string TreeCtxMenuRemoveSelectedPlugin { get; set; } = "Удалить выбранный плагин";

        public virtual string MsgMailtoAuthorPluginMailSubject { get; set; } = "Вопрос по плагину \"{0}\" для AinDevHelper";
        public virtual string MsgMailtoAuthorPluginMailGreeting { get; set; } = "{0}, добрый день!";
        public virtual string MsgMailtoAuthorPluginMailContent { get; set; } = "У меня есть вопрос по плагину \"{0}\" для AinDevHelper:";
        public virtual string MsgMailtoAuthorPluginMailContentPlaceholder { get; set; } = "[Введите здесь текст вашего сообщения...]";
        public virtual string MsgMailtoAuthorPluginMailContentBestRegards { get; set; } = "С наилучшими пожеланиями,";
        public virtual string MsgMailtoAuthorPluginMailContentSignature { get; set; } = "[Ваше имя]";

        public virtual string AboutFormDialogTitle { get; set; } = "О программе AinDevHelper...";
        public virtual string AboutFormLabelAppTitleExtra { get; set; } = "Помощник Разработчика";
        public virtual string AboutFormLabelProgramVersion { get; set; } = "Версия программы:";
        public virtual string AboutFormLabelCopyright { get; set; } = "Авторские права:";
        public virtual string AboutFormLabelOfficialSite { get; set; } = "Официальный сайт программы:";
        public virtual string AboutFormLabelDevelopersEmail { get; set; } = "E-mail разработчика:";
        public virtual string AboutFormLabelMainTelegramGroup { get; set; } = "Группа сайта Allineed.Ru в Telegram:";
        public virtual string AboutFormLabelTelegramTopicForProducts { get; set; } = "Тема с вопросами по продуктам Allineed.Ru:";
        public virtual string AboutFormLabelThisProgramIsDistributedUnderLicense { get; set; } = "Данное программное обеспечение распространяется под лицензией";


        public virtual string DescriptorBasedPluginErrMsgActionNotRecognized { get; set; } = "Ошибка при выполнении действия плагина. Действие не распознано.";
        public virtual string DescriptorBasedPluginErrMsgGivenActionNotRecognized { get; set; } = "Ошибка при выполнении действия плагина. Действие '{0}' не распознано.";
        public virtual string DescriptorBasedPluginMsgGivenActionCompletedSuccessfully { get; set; } = "Действие '{0}' выполнено успешно.";
        public virtual string DescriptorBasedPluginMsgGivenActionFailedWithProcExitCode { get; set; } = "Действие '{0}' выполнено неуспешно. Код завершения процесса: {1}";
        public virtual string DescriptorBasedPluginErrMsgArgumentNullMessage { get; set; } = "Параметр не может быть равен null";
        /// <summary>
        /// [RU] Локализация для формата даты, который используется при логировании событий на вкладке "Лог событий", а также других элементах интерфейса, работающих с датами
        /// [EN] Localization for the date format, which is used when logging events on the "Event Log" tab, as well as other interface elements that work with dates
        /// </summary>
        public virtual string DateFormat { get; set; } = "dd.MM.yyyy HH:mm:ss";
    }
}
