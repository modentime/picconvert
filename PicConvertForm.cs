using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PicTool : Form
    {
        public PicTool()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            string originImg = @"D:\Study\英语学习\04 兰登Step into\Step 2-Reading with Help （200L-500L） 基本词汇和短句\Step into Reading 2-PDF\A monster is coming20160305215427725_IMG\A monster is coming20160305215427725_4.jpg";
            string outputImg = @"D:\Study\英语学习\04 兰登Step into\Step 2-Reading with Help （200L-500L） 基本词汇和短句\Step into Reading 2-PDF\A monster is coming20160305215427725_IMG\A monster is coming20160305215427725_4_new.jpg";
            string imgFolder = this.tb_original.Text;
            string mode = "CutArea";
            switch (this.cb_mode.SelectedIndex)
            {
                case 0:
                    mode = "HW";
                    break;
                case 1:
                    mode = "W";
                    break;
                case 2:
                    mode = "H";
                    break;
                case 3:
                    mode = "Cut";
                    break;
                case 4:
                    mode = "CutArea";
                    break;
                case 5:
                    mode = "AI";
                    break;
                default:
                    break;
            }
            try
            {
                var images = Directory.GetFiles(imgFolder, ".", SearchOption.AllDirectories).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".bmp"));

                string pathExt = "";
                //foreach (string imgPath in Directory.GetFiles(imgFolder)) //从“我的图片”中读取
                foreach (string imgPath in images)
                {
                    pathExt = imgPath.Substring(imgPath.Length - 3, 3);
                    originImg = imgPath;
                    outputImg = imgPath;
                    if (pathExt == "jpg" || pathExt == "bmp" || pathExt == "png") //筛选图片格式
                    {
                        if (mode == "AI")
                        {
                            ImageHelper.CutImageWhitePart(originImg);
                        }
                        else
                        {
                            ImageHelper.MakeThumbnail(originImg, outputImg, Convert.ToInt32(this.tb_width.Text), mode, Convert.ToInt32(this.tb_height.Text),
                                Convert.ToInt32(this.tb_x.Text), Convert.ToInt32(this.tb_y.Text));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.button1.Enabled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fb_dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (string.IsNullOrEmpty(this.fb_dialog.SelectedPath))
                {
                    MessageBox.Show(this, "文件夹路径不能为空", "提示");
                    return;
                }
                else
                {
                    this.tb_original.Text = this.fb_dialog.SelectedPath;
                }
            }
        }

        private void cb_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cb_mode.SelectedIndex)
            {
                case 0:
                    this.tb_x.Text = "0";
                    this.tb_x.Enabled = false;
                    this.tb_y.Text = "0";
                    this.tb_y.Enabled = false;
                    this.tb_width.Enabled = true;
                    this.tb_height.Enabled = true;
                    break;
                case 1:
                    this.tb_x.Text = "0";
                    this.tb_x.Enabled = false;
                    this.tb_y.Text = "0";
                    this.tb_y.Enabled = false;
                    this.tb_width.Enabled = true;
                    this.tb_height.Enabled = false;
                    break;
                case 2:
                    this.tb_x.Text = "0";
                    this.tb_x.Enabled = false;
                    this.tb_y.Text = "0";
                    this.tb_y.Enabled = false;
                    this.tb_width.Enabled = false;
                    this.tb_height.Enabled = true;
                    break;
                case 3:
                    this.tb_x.Text = "0";
                    this.tb_x.Enabled = false;
                    this.tb_y.Text = "0";
                    this.tb_y.Enabled = false;
                    this.tb_width.Enabled = false;
                    this.tb_height.Enabled = true;
                    break;
                case 4:
                    this.tb_x.Text = "0";
                    this.tb_x.Enabled = true;
                    this.tb_y.Text = "0";
                    this.tb_y.Enabled = true;
                    this.tb_width.Enabled = true;
                    this.tb_height.Enabled = true;
                    break;
                default:
                    break;
            }
        }
    }
}
