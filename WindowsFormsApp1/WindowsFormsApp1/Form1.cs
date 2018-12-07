using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Airi : Form
    {
        public Airi()
        {
            InitializeComponent();
            textBox1.Visible = false;
            this.Activate();
            this.Icon = new System.Drawing.Icon(@"D:\Projects\airi\WindowsFormsApp1\WindowsFormsApp1\airi.ico");
        }

        //Form1のLoadイベントハンドラ
        private void Form1_Load(object sender, System.EventArgs e)
        {
            pictureBox1.MouseDown +=
                new MouseEventHandler(Form1_MouseDown);
            pictureBox1.MouseMove +=
                new MouseEventHandler(Form1_MouseMove);
        }

        //マウスのクリック位置を記憶
        private Point mousePoint;

        //Form1のMouseDownイベントハンドラ
        //マウスのボタンが押されたとき
        private void Form1_MouseDown(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }

        //Form1のMouseMoveイベントハンドラ
        //マウスが動いたとき
        private void Form1_MouseMove(object sender,
            System.Windows.Forms.MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                this.Left += e.X - mousePoint.X;
                this.Top += e.Y - mousePoint.Y;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 18 )
            {
                textBox1.Visible = !textBox1.Visible;
                if (textBox1.Visible == true)
                {
                    textBox1.Focus();
                    this.TopMost = true;
                }
                else
                {
                    this.TopMost = false;
                }
            }
    
            if( (textBox1.Visible == true) && (e.KeyValue == 13))
            {
                if(textBox1.Text == "chrome")
                {
                    Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe");
                }
                else if(textBox1.Text == "memo")
                {
                    Process.Start(@"C:\Windows\system32\notepad.exe");
                }
                else if(textBox1.Text == "peint"){
                    Process.Start(@"C:\Windows\system32\mspaint.exe");
                }
                else if(textBox1.Text == "gimp")
                {
                    Process.Start(@"C:\Program Files\GIMP 2\bin\gimp-2.10.exe");
                }
                else if(textBox1.Text == "music")
                {
                    Process.Start(@"D:\\music\\Playlists\\fav.zpl");
                }
                textBox1.Text = "\n";
                textBox1.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
