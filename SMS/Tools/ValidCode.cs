using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS.Tools
{
    public class ValidCode
    {
        #region 验证码功能
        /// <summary>
        /// 生成随机验证码字符串
        /// </summary>
        public static string CreateRandomCode(int CodeLength)
        {
            int rand;
            char code;
            string randomCode = String.Empty; //随机验证码

            //生成一定长度的随机验证码
            //Random random = new Random();//生成随机数对象
            for (int i = 0; i < CodeLength; i++)
            {
                //利用GUID生成6位随机数
                byte[] buffer = Guid.NewGuid().ToByteArray(); //生成字节数组
                int seed = BitConverter.ToInt32(buffer, 0); //利用BitConvert方法把字节数组转换为整数
                Random random = new Random(seed); //以生成的整数作为随机种子
                rand = random.Next();

                //rand = random.Next();
                if (rand % 3 == 1)
                {
                    code = (char)('A' + (char)(rand % 26));
                }
                else if (rand % 3 == 2)
                {
                    code = (char)('a' + (char)(rand % 26));
                }
                else
                {
                    code = (char)('0' + (char)(rand % 10));
                }
                randomCode += code.ToString();
            }
            return randomCode;
        }

        /// <summary>
        /// 创建验证码图片
        /// </summary>
        public static void CreateImage(string strValidCode, PictureBox pbox)
        {
            try
            {
                int RandAngle = 45; //随机转动角度
                int MapWidth = (int)(strValidCode.Length * 25);
                Bitmap map = new Bitmap(MapWidth, 30); //验证码图片—长和宽

                //创建绘图对象Graphics
                Graphics graph = Graphics.FromImage(map);
                graph.Clear(Color.AliceBlue); //清除绘画面,填充背景色
                graph.DrawRectangle(new Pen(Color.Black, 0), 0, 0, map.Width - 1, map.Height - 1); //画一个边框
                graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //模式
                Random rand = new Random();
                //背景噪点生成
                Pen blackPen = new Pen(Color.LightGray, 0);
                for (int i = 0; i < 50; i++)
                {
                    int x = rand.Next(0, map.Width);
                    int y = rand.Next(0, map.Height);
                    graph.DrawRectangle(blackPen, x, y, 1, 1);
                }
                //验证码旋转，防止机器识别
                char[] chars = strValidCode.ToCharArray(); //拆散字符串成单字符数组
                //文字居中
                StringFormat format = new StringFormat(StringFormatFlags.NoClip);
                format.Alignment = StringAlignment.Center;
                format.LineAlignment = StringAlignment.Center;
                //定义颜色
                Color[] c =
                {
                    Color.Black,
                    Color.Red,
                    Color.DarkBlue,
                    Color.Green,
                    Color.Orange,
                    Color.Brown,
                    Color.DarkCyan,
                    Color.Purple
                };
                //定义字体
                string[] font =
                {
                    "Verdana",
                    "Microsoft Sans Serif",
                    "Comic Sans MS",
                    "Arial",
                    "宋体"
                };
                for (int i = 0; i < chars.Length; i++)
                {
                    int cindex = rand.Next(7);
                    int findex = rand.Next(5);
                    Font f = new System.Drawing.Font(
                        font[findex],
                        13,
                        System.Drawing.FontStyle.Bold
                    ); //字体样式(参数2为字体大小)
                    Brush b = new System.Drawing.SolidBrush(c[cindex]);
                    Point dot = new Point(16, 16);

                    float angle = rand.Next(-RandAngle, RandAngle); //转动的度数
                    graph.TranslateTransform(dot.X, dot.Y); //移动光标到指定位置
                    graph.RotateTransform(angle);
                    graph.DrawString(chars[i].ToString(), f, b, 1, 1, format);

                    graph.RotateTransform(-angle); //转回去
                    graph.TranslateTransform(2, -dot.Y); //移动光标到指定位置
                }
                pbox.Image = map;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("验证码图片创建错误");
            }
        }
        #endregion
    }
}
