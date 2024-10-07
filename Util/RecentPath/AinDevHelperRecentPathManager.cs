using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AinDevHelperPluginLibrary.Util.RecentPath
{
    /// <summary>
    /// [RU] Менеджер по управлению недавно использованными путями к каталогам
    /// [EN] Manager for managing recently used directory paths
    /// </summary>
    public class AinDevHelperRecentPathManager
    {
        public static readonly string RECENT_PATHS_FILE = "recent_paths.xml";

        private static readonly object _lock = new object();
        private static AinDevHelperRecentPathManager instance;

        private static AinDevHelperRecentPathSet cachedRecentPathSet = new AinDevHelperRecentPathSet();

        AinDevHelperRecentPathManager() { }

        public static AinDevHelperRecentPathManager Instance {
            get {
                lock (_lock) {
                    instance ??= new AinDevHelperRecentPathManager();
                    return instance;
                }
            }
        }

        public bool AddRecentPathIfDirectoryExists(string appStartupPath, string newDirectoryRecentPath) {
            if (Directory.Exists(newDirectoryRecentPath)) {
                var newPath = new AinDevHelperRecentPath(newDirectoryRecentPath);
                if (cachedRecentPathSet.RecentPaths.Contains(newPath)) {
                    return false;
                }
                cachedRecentPathSet.RecentPaths.Add(newPath);

                try {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperRecentPathSet));
                    var recentPathsFile = Path.Combine(appStartupPath, RECENT_PATHS_FILE);                    

                    var fileStream = new FileStream(recentPathsFile, FileMode.Create, FileAccess.Write);
                    xmlSerializer.Serialize(fileStream, cachedRecentPathSet);
                    fileStream.Close();
                } catch (Exception exception) {
                    return false;
                }

                return true;
            }
            return false;
        }

        public AinDevHelperRecentPathSet GetRecentPathSetFromCache() {
            return cachedRecentPathSet;
        }

        public AinDevHelperRecentPathSet GetRecentPathSetAndReloadCache(string appStartupPath) {
            try {
                cachedRecentPathSet.RecentPaths.Clear();

                var recentPathsFile = Path.Combine(appStartupPath, RECENT_PATHS_FILE);

                if (File.Exists(recentPathsFile)) {
                    var xmlSerializer = new XmlSerializer(typeof(AinDevHelperRecentPathSet));
                    using var recentPathsFileStream = new FileStream(recentPathsFile, FileMode.Open, FileAccess.Read);
                    var deserializedRecentPathSet = (AinDevHelperRecentPathSet)xmlSerializer.Deserialize(recentPathsFileStream);
                    
                    foreach (var p in deserializedRecentPathSet.RecentPaths) {
                        cachedRecentPathSet.RecentPaths.Add(p);
                    }

                    return cachedRecentPathSet;
                } else {
                    return cachedRecentPathSet;
                }
            } catch (Exception) {
                return cachedRecentPathSet;
            }
        }
    }
}
