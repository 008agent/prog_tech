using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prog_tech_var12
{
    public partial class FormColor : Form
    {
        public FormColor()
        {
            InitializeComponent();
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            utils.Globals.glob_canDraw = false;
            this.Close();
        }

        private void b_OK_Click(object sender, EventArgs e)
        {
            try
            {
                byte red, green, blue;
                if (tb_red.Text.Length == 0 || tb_green.Text.Length == 0 || tb_blue.Text.Length == 0)
                {
                    throw new FormatException("Color form : color not defined");
                }
                red = Byte.Parse(tb_red.Text);
                green = Byte.Parse(tb_green.Text);
                blue = Byte.Parse(tb_blue.Text);
                utils.Globals.glob_colorRed = red;
                utils.Globals.glob_colorGreen = green;
                utils.Globals.glob_colorBlue = blue;
                utils.Globals.glob_canDraw = true;
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
                utils.Globals.glob_canDraw = false;
            }
            this.Close();
        }

        private void FormColor_Load(object sender, EventArgs e)
        {
            tb_red.Focus();
        }
    }
}
