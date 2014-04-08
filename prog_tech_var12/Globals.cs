using System;
using System.Collections.Generic;
using System.Text;

namespace utils
{   
    /// <summary>
    /// Класс, содержащий статические глобальные переменные 
    /// </summary>
    public class Globals
    {
        /// <summary>
        /// Представляют собой цветовые компоненты для отрисовки графика
        /// </summary>
        public static byte glob_colorRed;
        public static byte glob_colorGreen;
        public static byte glob_colorBlue;

        /// <summary>
        /// Тип графика. 0 - 'Line', 1 - 'Bar', others - 'undefined'
        /// </summary>
        public static byte glob_graphType;

        /// <summary>
        /// Разрешается ли отрисовка графика
        /// </summary>
        public static bool glob_canDraw; 
    }
}
