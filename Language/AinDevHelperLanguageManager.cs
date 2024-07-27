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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Language {
    /// <summary>
    /// [RU] Класс представляет собой менеджер языков, поддерживаемых AinDevHelper. Этот класс является синглтоном<br/>
    /// [EN] The class is a manager of languages supported by AinDevHelper. This class is a singleton
    /// </summary>
    public class AinDevHelperLanguageManager {
        /// <summary>
        /// [RU] Каталог для хранения языков, поддерживаемых AinDevHelper<br/>
        /// [EN] Directory for storing languages supported by AinDevHelper
        /// </summary>
        private static readonly string LANGUAGES_DIRECTORY = "languages";
        private static readonly string DEFAULT_LANGUAGE_FILE = "default.xml";
        private static readonly object _lock = new object();

        /// <summary>
        /// [RU] Ссылка на закрытый статический экземпляр класса<br/>
        /// [EN] A reference to a private static instance of a class
        /// </summary>
        private static AinDevHelperLanguageManager instance = null;

        /// <summary>
        /// [RU] Список закешированных языков. Обновляется каждый раз при повторном вызове метода <see cref="LoadAvailableLanguages"/><br/>
        /// [EN] List of cached languages. Updated every time the <see cref="LoadAvailableLanguages"/> method is called again
        /// </summary>
        public readonly List<AinDevHelperLanguage> CachedLanguages = new List<AinDevHelperLanguage>();

        public bool HasCachedLanguages { 
            get {
                return CachedLanguages.Count > 0;
            } 
        }

        AinDevHelperLanguageManager() { }

        /// <summary>
        /// [RU] Получает ссылку на единственный экземпляр класса для всего приложения AinDevHelper<br/>
        /// [EN] Gets a reference to the only instance of the class for the entire AinDevHelper application
        /// </summary>
        public static AinDevHelperLanguageManager Instance {
            get {
                lock (_lock) {
                    if (instance == null) {
                        instance = new AinDevHelperLanguageManager();
                    }
                    return instance;
                }
            }
        }

        /// <summary>
        /// [RU] Загружает язык по умолчанию<br/>
        /// [EN] Loads default language
        /// </summary>
        /// <param name="appStartupPath"></param>
        /// <returns></returns>
        public AinDevHelperLanguage LoadDefaultLanguage(string appStartupPath) {
            try {
                var xmlSerializer = new XmlSerializer(typeof(AinDevHelperLanguage));
                var defaultLanguagePath = appStartupPath + Path.DirectorySeparatorChar + LANGUAGES_DIRECTORY + Path.DirectorySeparatorChar + DEFAULT_LANGUAGE_FILE;
                using var defaultLanguageFileStream = new FileStream(defaultLanguagePath, FileMode.Open, FileAccess.Read);
                var defaultLanguage = (AinDevHelperLanguage)xmlSerializer.Deserialize(defaultLanguageFileStream);
                return defaultLanguage;
            } catch (Exception) {
                return new AinDevHelperLanguage();
            }            
        }

        /// <summary>
        /// [RU] Возвращает ссылку на экземпляр языка по его коду<br/>
        /// [EN] Returns a reference to a language instance by its code
        /// </summary>
        /// <param name="languageCode">[RU] код поддерживаемого AinDevHelper языка;<br/>[EN] AinDevHelper supported language code</param>
        /// <returns>[RU] ссылка на экземпляр поддерживаемого языка;<br/>[EN] reference to an instance of a supported language</returns>
        public AinDevHelperLanguage GetLanguageByCode(string languageCode) {
            if (CachedLanguages.Count > 0) {
                if (CachedLanguages.Any(lang => lang.LanguageCode != null && lang.LanguageCode.Equals(languageCode))) {
                    return CachedLanguages.First(lang => lang.LanguageCode != null && lang.LanguageCode.Equals(languageCode));
                }                
            }
            return new AinDevHelperLanguage();
        }

        /// <summary>
        /// [RU] Загружает список поддерживаемых доступных языков для AinDevHelper<br/>
        /// [EN] Loads a list of supported available languages for AinDevHelper
        /// </summary>
        /// <param name="appStartupPath"></param>
        /// <returns>[RU] список поддерживаемых языков;<br/>[EN] list of supported languages</returns>
        public List<AinDevHelperLanguage> LoadAvailableLanguages(string appStartupPath) {
            List<AinDevHelperLanguage> languages = new List<AinDevHelperLanguage>();
            CachedLanguages.Clear();

            try {
                var languagesDirectory = appStartupPath + Path.DirectorySeparatorChar + LANGUAGES_DIRECTORY;
                if (Directory.Exists(languagesDirectory)) {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperLanguage));
                    foreach (var languageFile in Directory.EnumerateFiles(languagesDirectory)) {
                        var currentFileName = Path.GetFileName(languageFile);

                        using var languageFileStream = new FileStream(languageFile, FileMode.Open, FileAccess.Read);
                        var deserializedLanguage = (AinDevHelperLanguage)xmlSerializer.Deserialize(languageFileStream);

                        //if (DEFAULT_LANGUAGE_FILE.Equals(currentFileName)) {
                        //    continue;
                        //}

                        languages.Add(deserializedLanguage);
                        CachedLanguages.Add(deserializedLanguage);
                    }
                    return languages;
                } else {
                    languages.Add(new AinDevHelperLanguage());
                    CachedLanguages.Add(new AinDevHelperLanguage());
                    return languages;
                }                
            } catch (Exception) {
                if (languages.Count > 0 && languages.IndexOf(new AinDevHelperLanguage()) >= 0) {
                    return languages;
                }
                languages.Add(new AinDevHelperLanguage());
                CachedLanguages.Add(new AinDevHelperLanguage());
                return languages;
            }
        }

        //TODO: удалить этот метод после завершения тестирования
        [Obsolete]
        public void StoreTestLanguage(string appStartupPath) {
            try {
                var xmlSerializer = new XmlSerializer(typeof(AinDevHelperLanguage));

                string pathToLanguageFile = appStartupPath +
                    Path.DirectorySeparatorChar + LANGUAGES_DIRECTORY +
                    Path.DirectorySeparatorChar + "ru.xml";

                var lang = new AinDevHelperLanguage();

                var fileStream = new FileStream(pathToLanguageFile, FileMode.Create, FileAccess.Write);
                xmlSerializer.Serialize(fileStream, lang);
                fileStream.Close();
            } catch (Exception exception) {
            }
        }
    }
}
