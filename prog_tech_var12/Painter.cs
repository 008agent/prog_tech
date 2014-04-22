using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace utils
{
    /// <summary>
    /// Класс для рисования фигур по заданию
    /// </summary>
    class Painter
    {
        /// <summary>
        /// Очищает область для рисования
        /// </summary>
        /// <param name="pbCanvas">ссылка на объект PictureBox для рисования</param>
        /// <param name="foreColor">цвет фона</param>
        public static void clearCanvas(ref PictureBox pbCanvas,Color foreColor)
        {
            using (Graphics G = pbCanvas.CreateGraphics())
            {
                G.Clear(foreColor);            
            }
        }
        /// <summary>
        /// Отрисовывает координатные плоскости
        /// </summary>
        /// <param name="pbCanvas">Ccылка на объект PictoreBox для рисования</param>
        /// <param name="IC">Объект InitialCondition, задающий начальные условия</param>
        public static void drawGrid(ref PictureBox pbCanvas, utils.InitialConditions IC)
        {
            using (Graphics G = pbCanvas.CreateGraphics())
            {
                Point pCenter = new Point();
                pCenter.X = (int)((pbCanvas.Width / (Math.Abs(IC.Xmin)+Math.Abs(IC.Xmax))) * Math.Abs(IC.Xmin));
                pCenter.Y = (int)((pbCanvas.Height / (Math.Abs(IC.Ymin) + Math.Abs(IC.Ymax))) * Math.Abs(IC.Ymax));
                //MessageBox.Show(pCenter.ToString()+ pbCanvas.Width.ToString() + "X" + pbCanvas.Height.ToString() + " Xmin=" + IC.Xmin + " Xmax=" + IC.Xmax + " Ymin=" + IC.Ymin + " Ymax=" + IC.Ymax);
                
                using (Pen p = new Pen(Color.Black))
                {
                    Point p0X1 = new Point();
                    Point p0X2 = new Point();
                    p0X1.X = 0;
                    p0X1.Y = pCenter.Y;
                    p0X2.X = pbCanvas.Width;
                    p0X2.Y = pCenter.Y;
                    //ось Х 
                    p.Width = 2;
                    G.DrawLine(p, p0X1, p0X2);
                    //ось У
                    p0X1.X = pCenter.X;
                    p0X1.Y = 0;
                    p0X2.X = pCenter.X;
                    p0X2.Y = pbCanvas.Height;
                    G.DrawLine(p, p0X1, p0X2);
                    //подпись к осям(X)
                    Point pmaxX = pCenter;
                    pmaxX.X = pbCanvas.Width-10;
                    G.DrawString("X", SystemFonts.DialogFont, Brushes.Black, pmaxX);
                    //подпись к осям(Y)
                    Point pmaxY = pCenter;
                    pmaxY.Y = 0;
                    G.DrawString("Y", SystemFonts.DialogFont, Brushes.Black, pmaxY);
                    //градация осей по Х
                    Point Xdivs = pCenter;
                    Xdivs.Y -= 10;
                    Point divsA = pCenter,divsB = pCenter;
                    for (int i = 0; i < IC.numDivX; i++)
                    {
                        Xdivs.X = (int)(i * IC.scaleX);
                        divsA.X = divsB.X = Xdivs.X;
                        divsA.Y = pCenter.Y - 5;
                        divsB.Y = pCenter.Y + 5;
                        Xdivs.X -= 10;
                        G.DrawString(Convert.ToString(i * IC.stepDiv - Math.Abs(IC.Xmin)), SystemFonts.DialogFont, Brushes.Black, Xdivs);
                        G.DrawLine(p, divsA, divsB);
                    }
                    //градация осей по У
                    Point Ydivs = pCenter;
                    divsA = pCenter;divsB = pCenter;
                    divsA.X -= 5;
                    divsB.X += 5;
                    for (int i = 0; i <= IC.numDivY; i++)
                    {
                        Ydivs.Y = pbCanvas.Height - (int)(i * IC.scaleY)-10;
                        divsA.Y = Ydivs.Y+10;
                        divsB.Y = Ydivs.Y+10;
                        G.DrawString(Convert.ToString(i * IC.stepDiv - Math.Abs(IC.Ymin)), SystemFonts.DialogFont, Brushes.Black, Ydivs);
                        G.DrawLine(p, divsA, divsB);
                    }
                }
  
            }
            drawPuncture(ref pbCanvas, IC);
        }
        /// <summary>
        /// Рисует пунктирные линии по заданию
        /// </summary>
        /// <param name="pbCanvas">Ccылка на объект PictoreBox для рисования</param>
        /// <param name="IC">Объект InitialCondition, задающий начальные условия</param>
        public static void drawPuncture(ref PictureBox pbCanvas, utils.InitialConditions IC)
        {
            Point maxYa, maxYb ,minYa ,minYb;
            maxYa = maxYb = minYa = minYb = new Point();
            Point pCenter = new Point();
            pCenter.X = (int)((pbCanvas.Width / (Math.Abs(IC.Xmin) + Math.Abs(IC.Xmax))) * Math.Abs(IC.Xmin));
            pCenter.Y = (int)((pbCanvas.Height / (Math.Abs(IC.Ymin) + Math.Abs(IC.Ymax))) * Math.Abs(IC.Ymax));
                maxYa = IC.getMaxYPoint();
                maxYa.X *= (int)IC.scaleX*2;
                maxYa.X += pCenter.X;
                maxYa.Y *= (int)IC.scaleY*2;
                maxYa.Y = pCenter.Y - maxYa.Y;
                maxYb.X = pCenter.X;
                maxYb.Y = maxYa.Y;

                minYa = IC.getMinYPoint();
                minYa.X *= (int)IC.scaleX * 2;
                minYa.X += pCenter.X;
                minYa.Y *= (int)IC.scaleY * 2;
                minYa.Y = pCenter.Y - minYa.Y - 2;
                minYb.X = pCenter.X;
                minYb.Y = minYa.Y;

            Color c = Color.Black;
            using (Graphics G = pbCanvas.CreateGraphics())
            {
                using (Pen p = new Pen(c))
                {
                    p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                    G.DrawLine(p, maxYa, maxYb);
                    G.DrawLine(p, minYa, minYb);
                }
            }
        }
        /// <summary>
        /// Рисует линейный график
        /// </summary>
        /// <param name="pbCanvas">Ccылка на объект PictoreBox для рисования</param>
        /// <param name="IC">Объект InitialCondition, задающий начальные условия</param>
        public static void drawLinearGraph(ref PictureBox pbCanvas, utils.InitialConditions IC)
        {
            Color GlaphColor = Color.FromArgb(Globals.glob_colorRed,Globals.glob_colorGreen,Globals.glob_colorBlue);
            Point[] arr = new Point[IC.ctx.Xarr.GetLength(0)];
            Point pCenter = new Point();
            pCenter.X = (int)((pbCanvas.Width / (Math.Abs(IC.Xmin) + Math.Abs(IC.Xmax))) * Math.Abs(IC.Xmin));
            pCenter.Y = (int)((pbCanvas.Height / (Math.Abs(IC.Ymin) + Math.Abs(IC.Ymax))) * Math.Abs(IC.Ymax));
            for (int i = 0; i < IC.ctx.Xarr.GetLength(0); i++)
            {
                arr[i].X = (int)(pCenter.X + 2*(IC.ctx.Xarr[i] * IC.scaleX));
            }
            for (int j = 0; j < IC.ctx.Yarr.GetLength(0); j++)
            {
                arr[j].Y = (int)(pCenter.Y - 2*(IC.ctx.Yarr[j] * IC.scaleY));
            }
            using (Graphics G = pbCanvas.CreateGraphics())
            {
                using (Pen p = new Pen(GlaphColor))
                {
                    p.Width = 3;
                    G.DrawLines(p, arr);
                }
            }
        }
        /// <summary>
        /// Рисует столбиковую диаграмму
        /// </summary>
        /// <param name="pbCanvas">Ccылка на объект PictoreBox для рисования</param>
        /// <param name="IC">Объект InitialCondition, задающий начальные условия</param>
        public static void drawDiagramm(ref PictureBox pbCanvas, utils.InitialConditions IC)
        {
            Color GlaphColor = Color.FromArgb(Globals.glob_colorRed, Globals.glob_colorGreen, Globals.glob_colorBlue);
            Point[] arr = new Point[IC.ctx.Xarr.GetLength(0)];
            Point[] zeroVertexes = new Point[IC.ctx.Xarr.GetLength(0)];

            Point pCenter = new Point();
            pCenter.X = (int)((pbCanvas.Width / (Math.Abs(IC.Xmin) + Math.Abs(IC.Xmax))) * Math.Abs(IC.Xmin));
            pCenter.Y = (int)((pbCanvas.Height / (Math.Abs(IC.Ymin) + Math.Abs(IC.Ymax))) * Math.Abs(IC.Ymax));
            for (int i = 0; i < IC.ctx.Xarr.GetLength(0); i++)
            {
                arr[i].X = (int)(pCenter.X + 2 * (IC.ctx.Xarr[i] * IC.scaleX));
                zeroVertexes[i].X = arr[i].X;
            }
            for (int j = 0; j < IC.ctx.Yarr.GetLength(0); j++)
            {
                arr[j].Y = (int)(pCenter.Y - 2 * (IC.ctx.Yarr[j] * IC.scaleY));
                zeroVertexes[j].Y = pCenter.Y;
            }
            using (Graphics G = pbCanvas.CreateGraphics())
            {
                using (Pen p = new Pen(GlaphColor))
                {
                    p.Width = 3;
                    for (int i = 0; i < zeroVertexes.GetLength(0); i++)
                    {
                        G.DrawLine(p, arr[i], zeroVertexes[i]);
                    }
                }
            }
        }
               
    }
}
