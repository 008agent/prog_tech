using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            new AboutBox1().ShowDialog();
        }
    }
}
