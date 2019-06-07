using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0607
{
    public partial class Form1 : Form
    {
        //疑似乱数
        //ランダムのシード(種)を指定して初期化する
        //それを使い続ける
        private static Random rand = new Random();
        int vx = rand.Next(-10, 11);
        int vy = rand.Next(-10,11);
        int zx = rand.Next(-10, 10);
        int zy = rand.Next(-10, 10);
        int mx = rand.Next(-10, 10);
        int my = rand.Next(-10, 10);
        int time = 100 * 5;
        
        public Form1()
        {
            InitializeComponent();

            //以下に、Label1.Leftとlabel1.Topの座標をランダムで求めよ
            label1.Left = rand.Next(ClientSize.Width - label1.Width);
            label1.Top = rand.Next(ClientSize.Height - label1.Height);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += vx;
            label1.Top += vy;

            if (label3.Left <= 0)
            {
                mx = -mx;
            }
            if (label3.Top <= 0)
            {
                my = -my;
            }
            if (label3.Left >= ClientSize.Width - label3.Width)
            {
                mx = -Math.Abs(-mx);
            }
            if (label3.Top >= ClientSize.Height - label3.Height)
            {
                my = -Math.Abs(-my);
            }
            label3.Left += mx;
            label3.Top += my;

            if (label3.Left <= 0)
            {
                mx = -mx;
            }
            if (label3.Top <= 0)
            {
                my = -my;
            }
            if (label3.Left >= ClientSize.Width - label3.Width)
            {
                mx = -Math.Abs(-mx);
            }
            if (label3.Top >= ClientSize.Height - label3.Height)
            {
                my = -Math.Abs(-my);
            }

            label2.Left += zx;
            label2.Top += zy;

            if(label2.Left<=0)
            {
                zx = -zx;
            }
            if(label2.Top<=0)
            {
                zy = -zy;
            }
            if(label2.Left>=ClientSize.Width-label2.Width)
            {
                zx = -Math.Abs(-zx);
            }
            if(label2.Top>=ClientSize.Height-label2.Height)
            {
                zy = -Math.Abs(-zy);
            }
            label2.Left += zx;
            label2.Top += zy;

            if(label2.Left<=0)
            {
                zx = -zx;
            }
            if(label2.Top<=0)
            {
                zy = -zy;
            }
            if(label2.Left>=ClientSize.Width-label2.Width)
            {
                zx = -Math.Abs(-zx);
            }
            if(label2.Top>=ClientSize.Height-label2.Height)
            {
                zy = -Math.Abs(-zy);
            }

            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left <= 0)
            {
                vx = -vx;
            }
            if (label1.Top <= 0)
            {
                vy = -vy;
            }
            if (label1.Left >= ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(-vx);
            }
            if (label1.Top >= ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(-vy);
            }
            label1.Left += vx;
            label1.Top += vy;

            if (label1.Left <= 0)
            {
                vx = -vx;
            }
            if (label1.Top <= 0)
            {
                vy = -vy;
            }
            if (label1.Left >= ClientSize.Width - label1.Width)
            {
                vx = -Math.Abs(-vx);
            }
            if (label1.Top >= ClientSize.Height - label1.Height)
            {
                vy = -Math.Abs(-vy);
            }

            //マウスと重なった時、タイマーを止める
            Point p = PointToClient(MousePosition);

            if (    (p.X>=label1.Left)
               && (p.X<=label1.Right)
               && (p.Y>=label1.Top)
               && (p.Y<=label1.Bottom)
               )
            {
                timer1.Enabled = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
