namespace WindowsFormsApp1
{
    partial class PicTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicTool));
            this.button1 = new System.Windows.Forms.Button();
            this.tb_original = new System.Windows.Forms.TextBox();
            this.tb_height = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_width = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_x = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_y = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_mode = new System.Windows.Forms.ComboBox();
            this.fb_dialog = new System.Windows.Forms.FolderBrowserDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_original
            // 
            this.tb_original.Location = new System.Drawing.Point(77, 29);
            this.tb_original.Name = "tb_original";
            this.tb_original.Size = new System.Drawing.Size(138, 21);
            this.tb_original.TabIndex = 1;
            // 
            // tb_height
            // 
            this.tb_height.Location = new System.Drawing.Point(218, 149);
            this.tb_height.Name = "tb_height";
            this.tb_height.Size = new System.Drawing.Size(54, 21);
            this.tb_height.TabIndex = 2;
            this.tb_height.Text = "660";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "图片文件夹：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图片高度：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "图片宽度：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tb_width
            // 
            this.tb_width.Location = new System.Drawing.Point(77, 149);
            this.tb_width.Name = "tb_width";
            this.tb_width.Size = new System.Drawing.Size(64, 21);
            this.tb_width.TabIndex = 5;
            this.tb_width.Text = "723";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "左边距：";
            // 
            // tb_x
            // 
            this.tb_x.Location = new System.Drawing.Point(77, 90);
            this.tb_x.Name = "tb_x";
            this.tb_x.Size = new System.Drawing.Size(64, 21);
            this.tb_x.TabIndex = 9;
            this.tb_x.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "上边距：";
            // 
            // tb_y
            // 
            this.tb_y.Location = new System.Drawing.Point(218, 90);
            this.tb_y.Name = "tb_y";
            this.tb_y.Size = new System.Drawing.Size(54, 21);
            this.tb_y.TabIndex = 7;
            this.tb_y.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "转换模式：";
            // 
            // cb_mode
            // 
            this.cb_mode.FormattingEnabled = true;
            this.cb_mode.Items.AddRange(new object[] {
            "固定宽高缩放",
            "固定宽度缩放",
            "固定高度缩放",
            "固定高度裁剪",
            "固定区域裁剪",
            "智能去除白边"});
            this.cb_mode.Location = new System.Drawing.Point(77, 206);
            this.cb_mode.Name = "cb_mode";
            this.cb_mode.Size = new System.Drawing.Size(114, 20);
            this.cb_mode.TabIndex = 12;
            this.cb_mode.Text = "固定区域裁剪";
            this.cb_mode.SelectedIndexChanged += new System.EventHandler(this.cb_mode_SelectedIndexChanged);
            // 
            // fb_dialog
            // 
            this.fb_dialog.Description = "请选择要转换的图片所在文件夹";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "选择";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PicTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cb_mode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_x);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_y);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_height);
            this.Controls.Add(this.tb_original);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicTool";
            this.Text = "图片批量处理器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tb_original;
        private System.Windows.Forms.TextBox tb_height;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_width;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_x;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_mode;
        private System.Windows.Forms.FolderBrowserDialog fb_dialog;
        private System.Windows.Forms.Button button2;
    }
}

