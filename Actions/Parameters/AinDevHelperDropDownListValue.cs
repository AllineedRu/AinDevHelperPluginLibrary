﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AinDevHelperPluginLibrary.Actions.Parameters {
    /// <summary>
    /// [RU] Класс описывает одно значение для выпадающего списка, представленного классом <see cref="AinDevHelperPluginActionDropDownListParameter"/>. Используется для задания плагином значений в выпадающем списке<br/>
    /// [EN] The class describes a single value for a dropdown list, represented by the <see cref="AinDevHelperPluginActionDropDownListParameter"/> class. Used to set the plugin values in the drop-down list
    /// </summary>
    public class AinDevHelperDropDownListValue {
        /// <summary>
        /// [RU] Отображаемое в списке читаемое значение. Это значение видит пользователь при раскрытии выпадающего списка<br/>
        /// [EN] The readable value displayed in the list. This value is seen by the user when expanding the drop-down list
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// [RU] Объект, ассоциированный с данным значением выпадающего списка<br/>
        /// [EN] The object associated with the given dropdown list value
        /// </summary>
        public object Value { get; set; }

        /// <summary>
        /// [RU] Конструктор без параметров<br/>
        /// [EN] Constructor without parameters
        /// </summary>
        public AinDevHelperDropDownListValue() {

        }

        public AinDevHelperDropDownListValue(string name, object value) {
            Name = name;
            Value = value;
        }

        public override bool Equals(object obj) {
            return obj is AinDevHelperDropDownListValue value &&
                   Name == value.Name &&
                   Value == value.Value;
        }

        public override int GetHashCode() {
            int hashCode = -244751520;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(Value);
            return hashCode;
        }

        public override string ToString() {
            return Name != null ? Name.ToString() : string.Empty;
        }
    }
}
