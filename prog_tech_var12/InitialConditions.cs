using System;
using System.Collections.Generic;
using System.Text;

namespace utils
{
    /// <summary>
    /// Задает начальные условия для отрисовки графика
    /// </summary>
    class InitialConditions
    {
        /// <summary>
        /// Масштаб по Х и У
        /// </summary>
        public uint scaleX,scaleY;
        /// <summary>
        /// Максимальные и минимальные значения по осям
        /// </summary>
        public double Xmin, Xmax, Ymin, Ymax;
        /// <summary>
        /// Количество делений по Х и по У
        /// </summary>
        public uint numDivX,numDivY;
        /// <summary>
        /// шаг деления по умолчанию
        /// </summary>
        public double stepDiv = 0.5;
        public utils.Context ctx;
        public InitialConditions(utils.Context Ctx,ref System.Windows.Forms.PictureBox pbCanvas)
        {
            try
            {
                Xmin = Xmax = Ctx.Xarr[0];
                Ymin = Ymax = Ctx.Yarr[0];
                foreach (double tmX in Ctx.Xarr)
                {
                    if (tmX > Xmax) Xmax = tmX;
                    if (tmX < Xmin) Xmin = tmX;
                }
                foreach (double tmY in Ctx.Yarr)
                {
                    if (tmY > Ymax) Ymax = tmY;
                    if (tmY < Ymin) Ymin = tmY;
                }
                if (Xmax < 0) Xmax = 0.0;
                if (Xmin > 0) Xmin = 0.0;
                if (Ymax < 0) Ymax = 0.0;
                if (Ymin > 0) Ymin = 0.0;

                numDivX = (uint)((Xmax - Xmin) / stepDiv);
                scaleX = (uint)(pbCanvas.Width / numDivX);
                numDivY = (uint)((Ymax - Ymin) / stepDiv);
                scaleY = (uint)(pbCanvas.Height / numDivY);
                this.ctx = Ctx;
            }
            catch (Exception E)
            {
                System.Windows.Forms.MessageBox.Show(E.Message);
            }
        }
        /// <summary>
        /// Получает координаты точки с максимальным значением Y
        /// </summary>
        /// <returns>Возвращает объект типа Point</returns>
        public System.Drawing.Point getMaxYPoint()
        {
            System.Drawing.Point tmp = new System.Drawing.Point();
            tmp.X = (int)this.ctx.Xarr[0];
            tmp.Y = (int)this.ctx.Yarr[0];
            for (int i = 0; i < this.ctx.Xarr.GetLength(0); i++)
            {
                if (this.ctx.Yarr[i] > tmp.Y)
                {
                    tmp.X = (int)this.ctx.Xarr[i];
                    tmp.Y = (int)this.ctx.Yarr[i];
                }
            }
            return tmp;
        }
        /// <summary>
        /// Получает координаты точки с минимальным значением Y
        /// </summary>
        /// <returns>Возвращает объект типа Point</returns>
        public System.Drawing.Point getMinYPoint()
        {
            System.Drawing.Point tmp = new System.Drawing.Point();
            tmp.X = (int)this.ctx.Xarr[0];
            tmp.Y = (int)this.ctx.Yarr[0];
            for (int i = 0; i < this.ctx.Xarr.GetLength(0); i++)
            {
                if (this.ctx.Yarr[i] < tmp.Y)
                {
                    tmp.X = (int)this.ctx.Xarr[i];
                    tmp.Y = (int)this.ctx.Yarr[i];
                }
            }
            return tmp;
        }
    }
}
