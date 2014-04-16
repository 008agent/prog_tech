using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace prog_tech_var12
{
    public partial class DebugWindow : Form
    {
        public DebugWindow()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblue.Text = Convert.ToString(utils.Globals.glob_colorBlue);
            lred.Text = Convert.ToString(utils.Globals.glob_colorRed);
            lgreen.Text = Convert.ToString(utils.Globals.glob_colorGreen);
            lforecolor.Text = Convert.ToString(utils.Globals.glob_fillColor);
            lgraphtype.Text = Convert.ToString(utils.Globals.glob_graphType);
            lcandraw.Text = Convert.ToString(utils.Globals.glob_canDraw);
            lactfname.Text = utils.Globals.glob_activeFname;
            ldebugfname.Text = utils.Globals.glob_debugFname;
        }

        private void DebugWindow_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void DebugWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = utils.Globals.glob_XMLfilter;
                ofd.ShowDialog();
                if (ofd.FileName.Length == 0) throw new utils.FileEx();
                utils.Globals.glob_debugFname = ofd.FileName;
                utils.Context ctx = utils.Loader.loadXML(utils.Globals.glob_debugFname);
                lbX.Items.Clear(); lbY.Items.Clear();
                foreach (double sX in ctx.Xarr) { lbX.Items.Add(sX); }
                foreach (double sY in ctx.Yarr) { lbY.Items.Add(sY); }
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void bremoveX_Click(object sender, EventArgs e)
        {
            try
            {
                lbX.Items.RemoveAt(lbX.SelectedIndex);
            }
            catch{}
        }

        private void bremoveY_Click(object sender, EventArgs e)
        {
            try
            {
                lbY.Items.RemoveAt(lbY.SelectedIndex);
            }
            catch { }
        }

        private void baddX_Click(object sender, EventArgs e)
        {
            try
            {
                double tmp = Double.Parse(tbAddX.Text);
                lbX.Items.Add(tmp);
            }
            catch { }
        }

        private void baddY_Click(object sender, EventArgs e)
        {
            try
            {
                double tmp = Double.Parse(tbAddY.Text);
                lbY.Items.Add(tmp);
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lbX.Items.Count == 0 || lbY.Items.Count == 0)
                {
                    throw new Exception("0 elements in controls");
                }
                if (lbX.Items.Count != lbY.Items.Count)
                {
                    throw new Exception("Count of X elements must equils Y elements");
                }
                SaveFileDialog ofd = new SaveFileDialog();
                ofd.Filter = utils.Globals.glob_XMLfilter;
                ofd.ShowDialog();
                if (ofd.FileName.Length == 0) throw new utils.FileEx();
                utils.Globals.glob_debugFname = ofd.FileName;
                    double[] tmpX = new double[lbX.Items.Count];
                    double[] tmpY = new double[lbY.Items.Count];
                    for (int i = 0; i < lbX.Items.Count; i++) tmpX[i] = (double)lbX.Items[i];
                    for (int i = 0; i < lbY.Items.Count; i++) tmpY[i] = (double)lbY.Items[i];
                    utils.Context ctx = new utils.Context(tmpX, tmpY);
                    utils.Loader.saveXML(ctx, utils.Globals.glob_debugFname);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lbX.Items.Clear();
            lbY.Items.Clear();
        }
    }
}
