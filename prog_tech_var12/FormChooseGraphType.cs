using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prog_tech_var12
{
    public partial class FormChooseGraphType : Form
    {
        public FormChooseGraphType()
        {
            InitializeComponent();
        }

        private void rb_line_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_ok_Click(object sender, EventArgs e)
        {
            if (rb_bar.Checked) { utils.Globals.glob_graphType = 1; }
            if (rb_line.Checked) { utils.Globals.glob_graphType = 0; }
            this.Close();
        }
    }
}
