using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using utils;

namespace prog_tech_var12
{
    public partial class f_main : Form
    {
        public f_main()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Событие нажатия кнопки QUIT
        /// </summary>
        /// <param name="sender">отправитель события</param>
        /// <param name="e">параметры собития</param>
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Globals.glob_graphType)
                {
                    case 0:
                        {
                            Painter.clearCanvas(ref pb_canvas, utils.Globals.glob_fillColor);
                            InitialConditions ic = new InitialConditions(utils.Globals.glob_context, ref pb_canvas);
                            Painter.drawGrid(ref pb_canvas, ic);
                            Painter.drawLinearGraph(ref pb_canvas, ic); break;
                        }
                    case 1:
                        {
                            Painter.clearCanvas(ref pb_canvas, utils.Globals.glob_fillColor);
                            InitialConditions ic = new InitialConditions(utils.Globals.glob_context, ref pb_canvas);
                            Painter.drawGrid(ref pb_canvas, ic);
                            Painter.drawDiagramm(ref pb_canvas, ic); break;
                        }
                    default:
                        {
                            throw new Exception("Graph type not defined");
                        }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }


        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }

        private void inputToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String fSrc;
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = utils.Globals.glob_XMLfilter;
            try
            {
                ofd.ShowDialog();
                fSrc = ofd.FileName;
                if (fSrc.Length == 0) { throw new FileEx(); }
                Context ctx = Loader.loadXML(fSrc);
                if (ctx.pt_context != "true")
                {
                    throw new Exception("Corrupted XML file");
                }
                utils.Globals.glob_context = ctx;
                MessageBox.Show("File " + fSrc + " loaded successfully");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                fSrc = ofd.FileName = "";
            }
            Globals.glob_activeFname = fSrc;
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChooseGraphType fchoose = new FormChooseGraphType();
            fchoose.ShowDialog();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormColor FC = new FormColor();
            FC.ShowDialog();
            drawToolStripMenuItem.Enabled = utils.Globals.glob_canDraw;
        }

        private void f_main_Load(object sender, EventArgs e)
        {
        }

        private void pb_canvas_Click(object sender, EventArgs e)
        {
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DebugWindow dw = new DebugWindow();
            dw.Show();
        }

        private void f_main_Resize(object sender, EventArgs e)
        {
            if (Globals.glob_canDraw)
            {
                this.drawToolStripMenuItem_Click(sender, e);
            }
        }

        private void f_main_ResizeEnd(object sender, EventArgs e)
        {

        }
    }
}
