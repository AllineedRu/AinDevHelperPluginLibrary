using AinDevHelperPluginLibrary.Language;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AinDevHelperPluginLibrary.Language.AinDevHelperLanguageCodeConstants;

namespace AinDevHelperPluginLibrary.Themes {
    /// <summary>
    /// [RU] Класс описывает тему для интерфейса AinDevHelper
    /// [EN] 
    /// </summary>
    [Serializable]
    public class AinDevHelperTheme {
        /// <summary>
        /// [RU] Локализованные названия темы, отображаемые в интерфейсе AinDevHelper
        /// [EN] 
        /// </summary>
        public HashSet<AinDevHelperLocalizedMessage> LocalizedThemeNames { get; set; } = new HashSet<AinDevHelperLocalizedMessage>();

        /// <summary>
        /// [RU] Внутреннее название (идентификатор) темы
        /// [EN] 
        /// </summary>
        public virtual string ThemeInternalName { get; set; } = "standard";

        /// <summary>
        /// [RU] Цвет фона в основных окнах и диалогах приложения
        /// [EN] 
        /// </summary>
        public virtual string WindowBackgroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета фона в основных окнах и диалогах приложения
        /// [EN] 
        /// </summary>
        public virtual Color WindowBackgroundColorValue { 
            get {
                return ColorFromString(WindowBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет шрифта в основных окнах и диалогах приложения
        /// [EN] 
        /// </summary>
        public virtual string WindowForegroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета шрифта в основных окнах и диалогах приложения
        /// [EN] 
        /// </summary>
        public virtual Color WindowForegroundColorValue {
            get {
                return ColorFromString(WindowForegroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет фона для дерева плагинов
        /// [EN] 
        /// </summary>
        public virtual string PluginsTreeBackgroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета фона для дерева плагинов
        /// [EN] 
        /// </summary>
        public virtual Color PluginsTreeBackgroundColorValue {
            get {
                return ColorFromString(PluginsTreeBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет шрифта для дерева плагинов
        /// [EN] 
        /// </summary>
        public virtual string PluginsTreeForegroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета шрифта для дерева плагинов
        /// [EN] 
        /// </summary>
        public virtual Color PluginsTreeForegroundColorValue {
            get {
                return ColorFromString(PluginsTreeForegroundColor);
            }
        }


        /// <summary>
        /// [RU] Цвет фона для главного тулбара
        /// [EN] 
        /// </summary>
        public virtual string MainToolbarBackgroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета фона для главного тулбара
        /// [EN] 
        /// </summary>
        public virtual Color MainToolbarBackgroundColorValue {
            get {
                return ColorFromString(MainToolbarBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет фона для главного меню приложения
        /// [EN] 
        /// </summary>
        public virtual string MainMenuStripBackgroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета фона для главного меню приложения
        /// [EN] 
        /// </summary>
        public virtual Color MainMenuStripBackgroundColorValue {
            get {
                return ColorFromString(MainMenuStripBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет шрифта для главного меню приложения
        /// [EN] 
        /// </summary>
        public virtual string MainMenuStripForegroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета шрифта для главного меню приложения
        /// [EN] 
        /// </summary>
        public virtual Color MainMenuStripForegroundColorValue {
            get {
                return ColorFromString(MainMenuStripForegroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет шрифта для пунктов меню
        /// [EN] 
        /// </summary>
        public virtual string MenuItemBackgroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета шрифта для пунктов меню
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemBackgroundColorValue {
            get {
                return ColorFromString(MenuItemBackgroundColor);
            }
        }


        /// <summary>
        /// [RU] Цвет шрифта для пунктов меню
        /// [EN] 
        /// </summary>
        public virtual string MenuItemForegroundColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета шрифта для пунктов меню
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemForegroundColorValue {
            get {
                return ColorFromString(MenuItemForegroundColor);
            }
        }

        /// <summary>
        /// [RU] Цвет фона для выбранного пункта меню
        /// [EN] 
        /// </summary>
        public virtual string MenuItemSelectedColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета фона для выбранного пункта меню
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemSelectedColorValue {
            get {
                return ColorFromString(MenuItemSelectedColor);
            }
        }

        /// <summary>
        /// [RU] Цвет границы для выбранного пункта меню
        /// [EN] 
        /// </summary>
        public virtual string MenuItemBorderColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета границы для выбранного пункта меню
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemBorderColorValue {
            get {
                return ColorFromString(MenuItemBorderColor);
            }
        }

        /// <summary>
        /// [RU] Цвет границы для меню
        /// [EN] 
        /// </summary>
        public virtual string MenuBorderColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета границы для меню
        /// [EN] 
        /// </summary>
        public virtual Color MenuBorderColorValue {
            get {
                return ColorFromString(MenuBorderColor);
            }
        }

        /// <summary>
        /// [RU] Цвет тени для сепаратора между пунктами меню
        /// [EN] 
        /// </summary>
        public virtual string SeparatorDarkColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета тени для сепаратора между пунктами меню
        /// [EN] 
        /// </summary>
        public virtual Color SeparatorDarkColorValue {
            get {
                return ColorFromString(SeparatorDarkColor);
            }
        }

        /// <summary>
        /// [RU] Цвет подсветки для сепаратора между пунктами меню
        /// [EN] 
        /// </summary>
        public virtual string SeparatorLightColor { get; set; }

        /// <summary>
        /// [RU] Значение цвета подсветки для сепаратора между пунктами меню
        /// [EN] 
        /// </summary>
        public virtual Color SeparatorLightColorValue {
            get {
                return ColorFromString(SeparatorLightColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string CheckBackgroundColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color CheckBackgroundColorValue {
            get {
                return ColorFromString(CheckBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string CheckSelectedBackgroundColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color CheckSelectedBackgroundColorValue {
            get {
                return ColorFromString(CheckSelectedBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string CheckPressedBackgroundColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color CheckPressedBackgroundColorValue {
            get {
                return ColorFromString(CheckPressedBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string GripLightColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color GripLightColorValue {
            get {
                return ColorFromString(GripLightColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string GripDarkColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color GripDarkColorValue {
            get {
                return ColorFromString(GripDarkColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string RaftingContainerGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color RaftingContainerGradientBeginColorValue {
            get {
                return ColorFromString(RaftingContainerGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string RaftingContainerGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color RaftingContainerGradientEndColorValue {
            get {
                return ColorFromString(RaftingContainerGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginGradientBeginColorValue {
            get {
                return ColorFromString(ImageMarginGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginGradientMiddleColorValue {
            get {
                return ColorFromString(ImageMarginGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginGradientEndColorValue {
            get {
                return ColorFromString(ImageMarginGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginRevealedGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginRevealedGradientBeginColorValue {
            get {
                return ColorFromString(ImageMarginRevealedGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginRevealedGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginRevealedGradientMiddleColorValue {
            get {
                return ColorFromString(ImageMarginRevealedGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ImageMarginRevealedGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ImageMarginRevealedGradientEndColorValue {
            get {
                return ColorFromString(ImageMarginRevealedGradientEndColor);
            }
        }


        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonPressedGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonPressedGradientBeginColorValue {
            get {
                return ColorFromString(ButtonPressedGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonPressedGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonPressedGradientMiddleColorValue {
            get {
                return ColorFromString(ButtonPressedGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonPressedGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonPressedGradientEndColorValue {
            get {
                return ColorFromString(ButtonPressedGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedGradientBeginColorValue {
            get {
                return ColorFromString(ButtonSelectedGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedGradientMiddleColorValue {
            get {
                return ColorFromString(ButtonSelectedGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedGradientEndColorValue {
            get {
                return ColorFromString(ButtonSelectedGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuStripGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuStripGradientBeginColorValue {
            get {
                return ColorFromString(MenuStripGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuStripGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuStripGradientEndColorValue {
            get {
                return ColorFromString(MenuStripGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemSelectedGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemSelectedGradientBeginColorValue {
            get {
                return ColorFromString(MenuItemSelectedGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemSelectedGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemSelectedGradientEndColorValue {
            get {
                return ColorFromString(MenuItemSelectedGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemPressedGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemPressedGradientBeginColorValue {
            get {
                return ColorFromString(MenuItemPressedGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemPressedGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemPressedGradientMiddleColorValue {
            get {
                return ColorFromString(MenuItemPressedGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemPressedGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemPressedGradientEndColorValue {
            get {
                return ColorFromString(MenuItemPressedGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ToolStripBorderColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ToolStripBorderColorValue {
            get {
                return ColorFromString(ToolStripBorderColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ToolStripDropDownBackgroundColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ToolStripDropDownBackgroundColorValue {
            get {
                return ColorFromString(ToolStripDropDownBackgroundColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual string ToolStripGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual Color ToolStripGradientBeginColorValue {
            get {
                return ColorFromString(ToolStripGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual string ToolStripGradientMiddleColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual Color ToolStripGradientMiddleColorValue {
            get {
                return ColorFromString(ToolStripGradientMiddleColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual string ToolStripGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual Color ToolStripGradientEndColorValue {
            get {
                return ColorFromString(ToolStripGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual string ToolStripContentPanelGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual Color ToolStripContentPanelGradientBeginColorValue {
            get {
                return ColorFromString(ToolStripContentPanelGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual string ToolStripContentPanelGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        [Obsolete]
        public virtual Color ToolStripContentPanelGradientEndColorValue {
            get {
                return ColorFromString(ToolStripContentPanelGradientEndColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ToolStripPanelGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ToolStripPanelGradientBeginColorValue {
            get {
                return ColorFromString(ToolStripPanelGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ToolStripPanelGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ToolStripPanelGradientEndColorValue {
            get {
                return ColorFromString(ToolStripPanelGradientEndColor);
            }
        }



        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string MenuItemArrowColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color MenuItemArrowColorValue {
            get {
                return ColorFromString(MenuItemArrowColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string StatusStripGradientBeginColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color StatusStripGradientBeginColorValue {
            get {
                return ColorFromString(StatusStripGradientBeginColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string StatusStripGradientEndColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color StatusStripGradientEndColorValue {
            get {
                return ColorFromString(StatusStripGradientEndColor);
            }
        }


        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedHighlightColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedHighlightColorValue {
            get {
                return ColorFromString(ButtonSelectedHighlightColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedHighlightBorderColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedHighlightBorderColorValue {
            get {
                return ColorFromString(ButtonSelectedHighlightBorderColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonPressedHighlightColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonPressedHighlightColorValue {
            get {
                return ColorFromString(ButtonPressedHighlightColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonPressedHighlightBorderColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonPressedHighlightBorderColorValue {
            get {
                return ColorFromString(ButtonPressedHighlightBorderColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string ButtonSelectedBorderColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color ButtonSelectedBorderColorValue {
            get {
                return ColorFromString(ButtonSelectedBorderColor);
            }
        }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual string CustomToolStripBorderColor { get; set; }

        /// <summary>
        /// [RU] 
        /// [EN] 
        /// </summary>
        public virtual Color CustomToolStripBorderColorValue {
            get {
                return ColorFromString(CustomToolStripBorderColor);
            }
        }


        // +
        public virtual bool IsOverrideButtonPressedGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideButtonPressedGradientMiddle { get; set; }
        // +
        public virtual bool IsOverrideButtonPressedGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideButtonSelectedGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideButtonSelectedGradientMiddle { get; set; }
        // +
        public virtual bool IsOverrideButtonSelectedGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideMenuStripGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideMenuStripGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideMenuItemSelected { get; set; }
        // +
        public virtual bool IsOverrideMenuItemBorder { get; set; }
        // +
        public virtual bool IsOverrideMenuBorder { get; set; }
        // +
        public virtual bool IsOverrideMenuItemSelectedGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideMenuItemSelectedGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideMenuItemPressedGradientBegin { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideMenuItemPressedGradientMiddle { get; set; }
        // +
        public virtual bool IsOverrideMenuItemPressedGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideToolStripBorder { get; set; }
        // +
        public virtual bool IsOverrideToolStripDropDownBackground { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideToolStripGradientBegin { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideToolStripGradientMiddle { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideToolStripGradientEnd { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideToolStripContentPanelGradientBegin { get; set; }
        // +
        [Obsolete]
        public virtual bool IsOverrideToolStripContentPanelGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideToolStripPanelGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideToolStripPanelGradientEnd { get; set; }
        // +
        public virtual bool IsOverrideSeparatorDark { get; set; }
        // +
        public virtual bool IsOverrideSeparatorLight { get; set; }
        // +
        public virtual bool IsOverrideCheckBackground { get; set; }
        // +
        public virtual bool IsOverrideCheckSelectedBackground { get; set; }
        // +
        public virtual bool IsOverrideCheckPressedBackground { get; set; }
        // +
        public virtual bool IsOverrideGripDark { get; set; }
        // +
        public virtual bool IsOverrideGripLight { get; set; }
        // +
        public virtual bool IsOverrideRaftingContainerGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideRaftingContainerGradientEnd { get; set; }
        public virtual bool IsOverrideImageMarginGradientBegin { get; set; }
        public virtual bool IsOverrideImageMarginGradientMiddle { get; set; }
        public virtual bool IsOverrideImageMarginGradientEnd { get; set; }
        public virtual bool IsOverrideImageMarginRevealedGradientBegin { get; set; }
        public virtual bool IsOverrideImageMarginRevealedGradientMiddle { get; set; }
        public virtual bool IsOverrideImageMarginRevealedGradientEnd { get; set; }

        // +
        public virtual bool IsOverrideStatusStripGradientBegin { get; set; }
        // +
        public virtual bool IsOverrideStatusStripGradientEnd { get; set; }


        // +
        public virtual bool IsOverrideButtonSelectedHighlight { get; set; }
        // +
        public virtual bool IsOverrideButtonSelectedHighlightBorder { get; set; }

        // +
        public virtual bool IsOverrideButtonPressedHighlight { get; set; }
        // +
        public virtual bool IsOverrideButtonPressedHighlightBorder { get; set; }
        // +
        public virtual bool IsOverrideButtonSelectedBorder { get; set; }
        // +
        public virtual bool IsOverrideMenuItemArrowColor { get; set; }


        public virtual bool IsOverrideCustomToolStripBorder { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров, необходим для целей сериализации/десериализации
        /// [EN] 
        /// </summary>
        public AinDevHelperTheme() {
        }

        /// <summary>
        /// [RU] Получает экземпляр структуры <see cref="Color"/> по входному значению цвета.
        /// [EN] 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static Color ColorFromString(string color) {
            if (color == null) {
                return SystemColors.Control;
            }
            if (color.StartsWith("#")) {
                Regex regexRGBColor = new Regex("^#(?<red>(\\d|[A-Fa-f]){2})(?<green>(\\d|[A-Fa-f]){2})(?<blue>(\\d|[A-Fa-f]){2})$");
                Match matchRGBColor = regexRGBColor.Match(color);
                if (matchRGBColor.Success) {
                    int.TryParse(matchRGBColor.Groups["red"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int red);
                    int.TryParse(matchRGBColor.Groups["green"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int green);
                    int.TryParse(matchRGBColor.Groups["blue"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int blue);
                    return Color.FromArgb(255, red, green, blue);
                } else {
                    Regex regexARGBColor = new Regex("^#(?<alpha>(\\d|[A-Fa-f]){2})(?<red>(\\d|[A-Fa-f]){2})(?<green>(\\d|[A-Fa-f]){2})(?<blue>(\\d|[A-Fa-f]){2})$");
                    Match matchARGBColor = regexARGBColor.Match(color);
                    if (matchARGBColor.Success) {
                        int.TryParse(matchARGBColor.Groups["alpha"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int alpha);
                        int.TryParse(matchARGBColor.Groups["red"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int red);
                        int.TryParse(matchARGBColor.Groups["green"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int green);
                        int.TryParse(matchARGBColor.Groups["blue"].Value, System.Globalization.NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int blue);
                        return Color.FromArgb(alpha, red, green, blue);
                    }
                }
            }
            var testNamedColor = Color.FromName(color);
            return testNamedColor.IsKnownColor || testNamedColor.IsSystemColor ? testNamedColor : SystemColors.Control;
        }

        /// <summary>
        /// [RU] Статический метод для создания экземпляра темы по умолчанию, встроенной в AinDevHelper
        /// [EN] 
        /// </summary>
        /// <returns></returns>
        public static AinDevHelperTheme CreateDefaultTheme() {
            var defaultTheme = new AinDevHelperTheme();
            defaultTheme.LocalizedThemeNames.Add(new AinDevHelperLocalizedMessage(RU, "Стандартная"));
            defaultTheme.LocalizedThemeNames.Add(new AinDevHelperLocalizedMessage(EN, "Standard"));
            defaultTheme.LocalizedThemeNames.Add(new AinDevHelperLocalizedMessage(DE, "Standart"));

            defaultTheme.ThemeInternalName = "standard";

            // Главное окно и диалоговые окна программы
            defaultTheme.WindowBackgroundColor = SystemColors.Control.Name.ToString();
            defaultTheme.WindowForegroundColor = SystemColors.ControlText.Name.ToString();
            
            // Дерево плагинов
            defaultTheme.PluginsTreeBackgroundColor = SystemColors.Window.Name.ToString();
            defaultTheme.PluginsTreeForegroundColor = SystemColors.WindowText.Name.ToString();

            // Главный тулбар
            defaultTheme.MainToolbarBackgroundColor = SystemColors.Control.Name.ToString();

            // Главное меню
            defaultTheme.MainMenuStripBackgroundColor = SystemColors.Control.Name.ToString();
            defaultTheme.MainMenuStripForegroundColor = SystemColors.ControlText.Name.ToString();

            // Пункты меню
            defaultTheme.MenuItemBackgroundColor = SystemColors.Control.Name.ToString();
            defaultTheme.MenuItemForegroundColor = SystemColors.ControlText.Name.ToString();

            var professionalColorTable = new ProfessionalColorTable();

            defaultTheme.ButtonPressedGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonPressedGradientBegin);
            defaultTheme.ButtonPressedGradientMiddleColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonPressedGradientMiddle);
            defaultTheme.ButtonPressedGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonPressedGradientEnd);

            defaultTheme.ButtonSelectedGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedGradientBegin);
            defaultTheme.ButtonSelectedGradientMiddleColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedGradientMiddle);
            defaultTheme.ButtonSelectedGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedGradientEnd);

            defaultTheme.MenuStripGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuStripGradientBegin);
            defaultTheme.MenuStripGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuStripGradientEnd);

            defaultTheme.MenuItemSelectedGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemSelectedGradientBegin);
            defaultTheme.MenuItemSelectedGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemSelectedGradientEnd);

            defaultTheme.MenuItemPressedGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemPressedGradientBegin);
            defaultTheme.MenuItemPressedGradientMiddleColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemPressedGradientMiddle);
            defaultTheme.MenuItemPressedGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemPressedGradientEnd);
            
            defaultTheme.ToolStripBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripBorder);
            defaultTheme.ToolStripDropDownBackgroundColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripDropDownBackground);
            defaultTheme.ToolStripGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripGradientBegin);
            defaultTheme.ToolStripGradientMiddleColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripGradientMiddle);
            defaultTheme.ToolStripGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripGradientEnd);


            defaultTheme.MenuItemSelectedColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemSelected);
            defaultTheme.MenuItemBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuItemBorder);
            defaultTheme.MenuBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.MenuBorder);

            
            defaultTheme.ToolStripContentPanelGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripContentPanelGradientBegin);
            defaultTheme.ToolStripContentPanelGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripContentPanelGradientEnd);
            defaultTheme.ToolStripPanelGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripPanelGradientBegin);
            defaultTheme.ToolStripPanelGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ToolStripPanelGradientEnd);

            defaultTheme.SeparatorDarkColor = GetNamedColorOrHexRepresentation(professionalColorTable.SeparatorDark);
            defaultTheme.SeparatorLightColor = GetNamedColorOrHexRepresentation(professionalColorTable.SeparatorLight);

            defaultTheme.CheckBackgroundColor = GetNamedColorOrHexRepresentation(professionalColorTable.CheckBackground);
            defaultTheme.CheckSelectedBackgroundColor = GetNamedColorOrHexRepresentation(professionalColorTable.CheckSelectedBackground);
            defaultTheme.CheckPressedBackgroundColor = GetNamedColorOrHexRepresentation(professionalColorTable.CheckPressedBackground);
            defaultTheme.GripDarkColor = GetNamedColorOrHexRepresentation(professionalColorTable.GripDark);
            defaultTheme.GripLightColor = GetNamedColorOrHexRepresentation(professionalColorTable.GripLight);
            defaultTheme.RaftingContainerGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.RaftingContainerGradientBegin);
            defaultTheme.RaftingContainerGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.RaftingContainerGradientEnd);

            defaultTheme.ImageMarginGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.ImageMarginGradientBegin);
            defaultTheme.ImageMarginGradientMiddleColor = GetNamedColorOrHexRepresentation(professionalColorTable.ImageMarginGradientMiddle);
            defaultTheme.ImageMarginGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.ImageMarginGradientEnd);


            defaultTheme.StatusStripGradientBeginColor = GetNamedColorOrHexRepresentation(professionalColorTable.StatusStripGradientBegin);
            defaultTheme.StatusStripGradientEndColor = GetNamedColorOrHexRepresentation(professionalColorTable.StatusStripGradientEnd);

            defaultTheme.ButtonSelectedHighlightColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedHighlight);
            defaultTheme.ButtonSelectedHighlightBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedHighlightBorder);
            defaultTheme.ButtonPressedHighlightColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonPressedHighlight);
            defaultTheme.ButtonPressedHighlightBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonPressedHighlightBorder);
            defaultTheme.ButtonSelectedBorderColor = GetNamedColorOrHexRepresentation(professionalColorTable.ButtonSelectedBorder);

            defaultTheme.MenuItemArrowColor = GetNamedColorOrHexRepresentation(Color.Black);

            return defaultTheme;
        }

        public static string GetNamedColorOrHexRepresentation(Color color) {
            return color.IsNamedColor ? color.Name.ToString() : "#" + color.Name;
        }
    }
}
