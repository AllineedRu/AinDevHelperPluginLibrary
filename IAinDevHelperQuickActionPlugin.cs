namespace AinDevHelperPluginLibrary {
    public interface IAinDevHelperQuickActionPlugin : IAinDevHelperPlugin {
        /// <summary>
        /// [RU] Запускает быстрое действие, предусмотренное плагином
        /// [EN] Runs quick action assumed to be performed by the plugin
        /// </summary>
        void RunQuickAction();
    }
}
