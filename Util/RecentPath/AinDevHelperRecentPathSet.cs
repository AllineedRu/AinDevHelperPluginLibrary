using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Util.RecentPath {
    [Serializable]
    public class AinDevHelperRecentPathSet {
        public HashSet<AinDevHelperRecentPath> RecentPaths { get; set; } = new HashSet<AinDevHelperRecentPath>();
    }
}
