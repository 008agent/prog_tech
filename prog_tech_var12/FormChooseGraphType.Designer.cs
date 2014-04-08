namespace prog_tech_var12
{
    partial class FormChooseGraphType
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
            this.gb_graphType = new System.Windows.Forms.GroupBox();
            this.b_ok = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.rb_line = new System.Windows.Forms.RadioButton();
            this.rb_bar = new System.Windows.Forms.RadioButton();
            this.gb_graphType.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_graphType
            // 
            this.gb_graphType.Controls.Add(this.rb_bar);
            this.gb_graphType.Controls.Add(this.rb_line);
            this.gb_graphType.Location = new System.Drawing.Point(13, 13);
            this.gb_graphType.Name = "gb_graphType";
            this.gb_graphType.Size = new System.Drawing.Size(131, 82);
            this.gb_graphType.TabIndex = 0;
            this.gb_graphType.TabStop = false;
            this.gb_graphType.Text = "1";
            // 
            // b_ok
            // 
            this.b_ok.Location = new System.Drawing.Point(175, 13);
            this.b_ok.Name = "b_ok";
            this.b_ok.Size = new System.Drawing.Size(75, 23);
            this.b_ok.TabIndex = 1;
            this.b_ok.Text = "OK";
            this.b_ok.UseVisualStyleBackColor = true;
            this.b_ok.Click += new System.EventHandler(this.b_ok_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(175, 72);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 2;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // rb_line
            // 
            this.rb_line.AutoSize = true;
            this.rb_line.Location = new System.Drawing.Point(11, 19);
            this.rb_line.Name = "rb_line";
            this.rb_line.Size = new System.Drawing.Size(45, 17);
            this.rb_line.TabIndex = 0;
            this.rb_line.TabStop = true;
            this.rb_line.Text = "Line";
            this.rb_line.UseVisualStyleBackColor = true;
            this.rb_line.CheckedChanged += new System.EventHandler(this.rb_line_CheckedChanged);
            // 
            // rb_bar
            // 
            this.rb_bar.AutoSize = true;
            this.rb_bar.Location = new System.Drawing.Point(11, 43);
            this.rb_bar.Name = "rb_bar";
            this.rb_bar.Size = new System.Drawing.Size(41, 17);
            this.rb_bar.TabIndex = 1;
            this.rb_bar.TabStop = true;
            this.rb_bar.Text = "Bar";
            this.rb_bar.UseVisualStyleBackColor = true;
            // 
            // FormChooseGraphType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 114);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_ok);
            this.Controls.Add(this.gb_graphType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChooseGraphType";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "FormChooseGraphType";
            this.gb_graphType.ResumeLayout(false);
            this.gb_graphType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_graphType;
        private System.Windows.Forms.RadioButton rb_bar;
        private System.Windows.Forms.RadioButton rb_line;
        private System.Windows.Forms.Button b_ok;
        private System.Windows.Forms.Button b_cancel;
    }
}