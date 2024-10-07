using AinDevHelperPluginLibrary.Util.RecentPath;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Themes {
    public class AinDevHelperThemeManager {

        public static readonly string THEMES_DIRECTORY = "themes";
        public static readonly string STANDARD_THEME_NAME = "standard";

        private static readonly object _lock = new object();
        private static AinDevHelperThemeManager instance;

        private static HashSet<AinDevHelperTheme> cachedRecentThemesSet = new HashSet<AinDevHelperTheme>();
        private bool isRewriteStanardThemeDevMode = true;

        private bool isThemesLoadComplete;

        public static AinDevHelperThemeManager Instance {
            get {
                lock (_lock) {
                    instance ??= new AinDevHelperThemeManager();
                    return instance;
                }
            }
        }

        public ImmutableHashSet<AinDevHelperTheme> ReloadAvailableThemes(string appStartupPath) {
            lock (_lock) {
                cachedRecentThemesSet.Clear();
                isThemesLoadComplete = false;
                return LoadAvailableThemes(appStartupPath);
            }
        }

        public bool SaveAllThemes(string appStartupPath) {
            lock (_lock) {
                if (cachedRecentThemesSet.Count == 0) {
                    LoadAvailableThemes(appStartupPath);
                }

                string themesDirectoryPath = Path.Combine(appStartupPath, THEMES_DIRECTORY);
                if (!Directory.Exists(themesDirectoryPath)) { 
                    Directory.CreateDirectory(themesDirectoryPath);
                }
                try {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperTheme));

                    foreach (var theme in cachedRecentThemesSet) {
                        var themeFileName = Path.Combine(themesDirectoryPath, theme.ThemeInternalName + ".xml");
                        var fileStream = new FileStream(themeFileName, FileMode.Create, FileAccess.Write);
                        xmlSerializer.Serialize(fileStream, theme);
                        fileStream.Close();
                    }
                } catch (Exception) {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// [RU] Загружает доступные темы для AinDevHelper, если они ещё не были загружены и закешированы. Не производит загрузку тем, если они были загружены и закешированы ранее.
        /// [EN] 
        /// </summary>
        /// <returns></returns>
        public ImmutableHashSet<AinDevHelperTheme> LoadAvailableThemes(string appStartupPath) {
            try {
                if (isThemesLoadComplete) {
                    return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
                }

                string themesDirectoryPath = Path.Combine(appStartupPath, THEMES_DIRECTORY);
                if (!Directory.Exists(themesDirectoryPath)) {
                    if (!isThemesLoadComplete) {
                        LoadDefaultTheme();
                    }
                    return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
                }

                var themeFiles = Directory.GetFiles(themesDirectoryPath, "*.xml", SearchOption.TopDirectoryOnly).ToList();
                if (themeFiles.Count == 0) {
                    LoadDefaultTheme();
                    return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
                }

                var xmlSerializer = new XmlSerializer(typeof(AinDevHelperTheme));

                lock (_lock) {
                    if (isThemesLoadComplete) {
                        return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
                    }

                    bool isDefaultThemeFound = false;
                    foreach (var themeFile in themeFiles) {
                        using var themeFileStream = new FileStream(themeFile, FileMode.Open, FileAccess.Read);
                        var deserializedTheme = (AinDevHelperTheme)xmlSerializer.Deserialize(themeFileStream);

                        //TODO: remove later
                        //Color clr = deserializedTheme.MainWindowBackgroundColorValue;
                        //Color clr2 = deserializedTheme.MainWindowForegroundColorValue;

                        if (STANDARD_THEME_NAME.Equals(deserializedTheme.ThemeInternalName)) {
                            isDefaultThemeFound = true;
                        }
                        cachedRecentThemesSet.Add(deserializedTheme);
                    }

                    // Среди тем в каталоге "themes" не была найдена стандартная... Добавляем вручную
                    if (!isDefaultThemeFound) {
                        cachedRecentThemesSet.Add(AinDevHelperTheme.CreateDefaultTheme());
                    }

                    isThemesLoadComplete = true;
                }
            } catch (Exception) {
                return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
            }

            return ImmutableHashSet.CreateRange(cachedRecentThemesSet);
        }

        private void LoadDefaultTheme() {
            lock (_lock) {
                cachedRecentThemesSet.Add(AinDevHelperTheme.CreateDefaultTheme());
                isThemesLoadComplete = true;
            }            
        }
    }
}
