using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Util.RecentPath
{
    /// <summary>
    /// [RU] Представляет собой недавно использованный каталог
    /// [EN] Describes a recently used directory
    /// </summary>
    [Serializable]
    public class AinDevHelperRecentPath
    {
        /// <summary>
        /// [RU] Псевдоним недавно использованного пути
        /// [EN] The alias of the recently used path
        /// </summary>
        public virtual string Alias { get; set; }

        /// <summary>
        /// [RU] Полный путь к недавно использованному каталогу
        /// [EN] The full path to the recently used directory
        /// </summary>
        public virtual string FullPath { get; set; }

        public AinDevHelperRecentPath() { }

        public AinDevHelperRecentPath(string alias, string fullPath) {
            Alias = alias;
            FullPath = fullPath;
        }

        public AinDevHelperRecentPath(string fullPath) {
            FullPath = fullPath;
        }

        public override bool Equals(object obj) {
            return obj is AinDevHelperRecentPath path &&
                   Alias == path.Alias &&
                   FullPath == path.FullPath;
        }

        public override int GetHashCode() {
            int hashCode = 2090576170;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Alias);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FullPath);
            return hashCode;
        }
    }
}
