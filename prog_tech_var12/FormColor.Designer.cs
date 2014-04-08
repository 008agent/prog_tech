namespace prog_tech_var12
{
    partial class FormColor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_red = new System.Windows.Forms.TextBox();
            this.tb_green = new System.Windows.Forms.TextBox();
            this.tb_blue = new System.Windows.Forms.TextBox();
            this.l_Red = new System.Windows.Forms.Label();
            this.l_Green = new System.Windows.Forms.Label();
            this.l_Blue = new System.Windows.Forms.Label();
            this.b_OK = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_red
            // 
            this.tb_red.ForeColor = System.Drawing.Color.Red;
            this.tb_red.Location = new System.Drawing.Point(13, 13);
            this.tb_red.Name = "tb_red";
            this.tb_red.Size = new System.Drawing.Size(100, 20);
            this.tb_red.TabIndex = 0;
            // 
            // tb_green
            // 
            this.tb_green.ForeColor = System.Drawing.Color.Green;
            this.tb_green.Location = new System.Drawing.Point(12, 39);
            this.tb_green.Name = "tb_green";
            this.tb_green.Size = new System.Drawing.Size(100, 20);
            this.tb_green.TabIndex = 1;
            // 
            // tb_blue
            // 
            this.tb_blue.ForeColor = System.Drawing.Color.Blue;
            this.tb_blue.Location = new System.Drawing.Point(13, 65);
            this.tb_blue.Name = "tb_blue";
            this.tb_blue.Size = new System.Drawing.Size(100, 20);
            this.tb_blue.TabIndex = 2;
            // 
            // l_Red
            // 
            this.l_Red.AutoSize = true;
            this.l_Red.ForeColor = System.Drawing.Color.Red;
            this.l_Red.Location = new System.Drawing.Point(120, 16);
            this.l_Red.Name = "l_Red";
            this.l_Red.Size = new System.Drawing.Size(27, 13);
            this.l_Red.TabIndex = 3;
            this.l_Red.Text = "Red";
            // 
            // l_Green
            // 
            this.l_Green.AutoSize = true;
            this.l_Green.ForeColor = System.Drawing.Color.Green;
            this.l_Green.Location = new System.Drawing.Point(120, 42);
            this.l_Green.Name = "l_Green";
            this.l_Green.Size = new System.Drawing.Size(36, 13);
            this.l_Green.TabIndex = 4;
            this.l_Green.Text = "Green";
            // 
            // l_Blue
            // 
            this.l_Blue.AutoSize = true;
            this.l_Blue.ForeColor = System.Drawing.Color.Blue;
            this.l_Blue.Location = new System.Drawing.Point(120, 68);
            this.l_Blue.Name = "l_Blue";
            this.l_Blue.Size = new System.Drawing.Size(28, 13);
            this.l_Blue.TabIndex = 5;
            this.l_Blue.Text = "Blue";
            // 
            // b_OK
            // 
            this.b_OK.Location = new System.Drawing.Point(185, 16);
            this.b_OK.Name = "b_OK";
            this.b_OK.Size = new System.Drawing.Size(75, 23);
            this.b_OK.TabIndex = 6;
            this.b_OK.Text = "OK";
            this.b_OK.UseVisualStyleBackColor = true;
            this.b_OK.Click += new System.EventHandler(this.b_OK_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(185, 58);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 7;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // FormColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 110);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_OK);
            this.Controls.Add(this.l_Blue);
            this.Controls.Add(this.l_Green);
            this.Controls.Add(this.l_Red);
            this.Controls.Add(this.tb_blue);
            this.Controls.Add(this.tb_green);
            this.Controls.Add(this.tb_red);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormColor";
            this.Text = "FormColor";
            this.Load += new System.EventHandler(this.FormColor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_red;
        private System.Windows.Forms.TextBox tb_green;
        private System.Windows.Forms.TextBox tb_blue;
        private System.Windows.Forms.Label l_Red;
        private System.Windows.Forms.Label l_Green;
        private System.Windows.Forms.Label l_Blue;
        private System.Windows.Forms.Button b_OK;
        private System.Windows.Forms.Button b_Cancel;
    }
}