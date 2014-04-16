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

        public static System.Drawing.Color glob_fillColor = System.Drawing.Color.White;

        /// <summary>
        /// Тип графика. 0 - 'Line', 1 - 'Bar', others - 'undefined'
        /// </summary>
        public static byte glob_graphType;

        /// <summary>
        /// Разрешается ли отрисовка графика
        /// </summary>
        public static bool glob_canDraw;

        /// <summary>
        /// Путь к текущему открытому файлу
        /// </summary>
        public static string glob_activeFname;

        /// <summary>
        /// Глобальный дескриптор контекста
        /// </summary>
        public static Context glob_context;

        /// <summary>
        /// Путь к отладочному XML файлу
        /// </summary>
        public static string glob_debugFname;

        /// <summary>
        /// Файловый фильтр для диалогов XML
        /// </summary>
        public static string glob_XMLfilter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
    }
}
