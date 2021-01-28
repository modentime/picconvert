using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class ImageHelper
    {
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>
        public static void MakeThumbnail(string originalImagePath, string thumbnailPath, int width, string mode, int height, int startX=0, int startY=0)
        {
            System.Drawing.Image originalImage = System.Drawing.Image.FromFile(originalImagePath);
            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;
            switch (mode)
            {
                case "HW"://指定高宽缩放（可能变形）
                    break;
                case "W"://指定宽，高按比例
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                case "CutArea"://指定裁减区域（可能变形）
                    oh = toheight;
                    ow = towidth;
                    y = startY;
                    x = startX;
                    break;
                default:
                    break;
            }
            //新建一个bmp图片
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            //新建一个画板
            Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            //设置高质量插值法
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            //设置高质量,低速度呈现平滑程度
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            //清空画布并以透明背景色填充
            g.Clear(Color.Transparent);
            //在指定位置并且按指定大小绘制原图片的指定部分
            g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight),
            new Rectangle(x, y, ow, oh),
            GraphicsUnit.Pixel);
            try
            {
                originalImage.Dispose();
                //以jpg格式保存缩略图
                if (File.Exists(thumbnailPath))
                    File.Delete(thumbnailPath);
                bitmap.Save(thumbnailPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {                
                bitmap.Dispose();
                g.Dispose();
            }
        }
        /// <summary>
        /// 裁剪图片（去掉百边）
        /// </summary>
        /// <param name="FilePath"></param>
        public static void CutImageWhitePart(string FilePath)
        {
            Bitmap bmp = new Bitmap(FilePath);
            //上左右下
            int top = 0, left = 0, right = bmp.Width, bottom = bmp.Height;

            //寻找最上面的标线,从左(0)到右，从上(0)到下
            for (int i = 0; i < bmp.Height; i++)//行
            {
                bool find = false;
                for (int j = 0; j < bmp.Width; j++)//列
                {
                    Color c = bmp.GetPixel(j, i);
                    if (!IsWhite(c))
                    {
                        top = i;
                        find = true;
                        break;
                    }
                }
                if (find)
                    break;
            }
            //寻找最左边的标线，从上（top位）到下，从左到右
            for (int i = 0; i < bmp.Width; i++)//列
            {
                bool find = false;
                for (int j = top; j < bmp.Height; j++)//行
                {
                    Color c = bmp.GetPixel(i, j);
                    if (!IsWhite(c))
                    {
                        left = i;
                        find = true;
                        break;
                    }
                }
                if (find)
                    break;
            }
            //寻找最下边标线，从下到上，从左到右
            for (int i = bmp.Height - 1; i >= 0; i--)//行
            {
                bool find = false;
                for (int j = left; j < bmp.Width; j++)//列
                {
                    Color c = bmp.GetPixel(j, i);
                    if (!IsWhite(c))
                    {
                        bottom = i;
                        find = true;
                        break;
                    }
                }
                if (find)
                    break;
            }
            //寻找最右边的标线，从上到下，从右往左
            for (int i = bmp.Width - 1; i >= 0; i--)//列
            {
                bool find = false;
                for (int j = 0; j <= bottom; j++)//行
                {
                    Color c = bmp.GetPixel(i, j);
                    if (!IsWhite(c))
                    {
                        right = i;
                        find = true;
                        break;
                    }
                }
                if (find)
                    break;
            }

            //克隆位图对象的一部分。
            Rectangle cloneRect = new Rectangle(left, top, right - left, bottom - top);
            Bitmap cloneBitmap = bmp.Clone(cloneRect, bmp.PixelFormat);
            bmp.Dispose();
            //cloneBitmap.Save(@"d:\123.png", ImageFormat.Png);
            cloneBitmap.Save(FilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            //return cloneBitmap;
        }

        /// <summary>
        /// 判断是否白色和纯透明色（10点的容差）
        /// </summary>
        public static bool IsWhite(Color c)
        {
            //纯透明也是白色,RGB都为255为纯白
            if (c.A < 10 || (c.R > 245 && c.G > 245 && c.B > 245))
                return true;

            return false;
        }
    }
}
