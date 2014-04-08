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

            ofd.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            try
            {
                ofd.ShowDialog();
                fSrc = ofd.FileName;
                if (fSrc.Length == 0) { throw new FileEx(); }
                Context ctx = Loader.loadXML(fSrc);
                MessageBox.Show("File " + fSrc + " loaded successfully");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                fSrc = ofd.FileName = "";
            }
        }

        private void chooseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormChooseGraphType fchoose = new FormChooseGraphType();
            fchoose.ShowDialog();
        }
    }
}
