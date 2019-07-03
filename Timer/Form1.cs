using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        int sec, min, hour;
        int count = 0;
        int count3 = 0;
        int muscount = 0;
        
        OpenFileDialog file = new OpenFileDialog();
        
        //
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        string dirPath = $@"{AppDomain.CurrentDomain.BaseDirectory}\Music";
        string[] MusPath = new string[100];
        string[] seC =  { "00" };
        string[] miN = { "00" };
        string[] houR = { "00" };

        public Timer()
        {

            InitializeComponent();
            timer2.Start();
            Hour.Font = new Font("新細明體",30F);
            Sec.Font = new Font("新細明體", 30F);
            Min.Font = new Font("新細明體", 30F);

            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("success");
            }
            else
            {
                Directory.CreateDirectory(dirPath);
                Console.WriteLine("The directory {0} was created.", dirPath);
            }
            foreach (string fname in System.IO.Directory.GetFileSystemEntries($@"{AppDomain.CurrentDomain.BaseDirectory}\Music", "*.mp3"))
            {
                MusPath[muscount] = fname;
                muscount++;
            }
             this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            //建立NotifyIcon
            this.notifyIcon1.Icon = new Icon($@"{AppDomain.CurrentDomain.BaseDirectory}\time.ico");
            this.notifyIcon1.Text = "Timer";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label6.Text = DateTime.Now.ToString("yyyy/MM/dd  hh:mm:ss");
            string time = DateTime.Now.ToString("hh:mm:ss");
            if (textBox1.Text == time)
            {
                 MessageBox.Show($"{textBox2.Text}","時間到",
                 MessageBoxButtons.OK, MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                 wplayer.URL = $"{MusPath[0]}";
            }
            else if (textBox4.Text == time)
            {
                MessageBox.Show($"{textBox3.Text}", "時間到",
                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                wplayer.URL = $"{MusPath[0]}";
            }
            else if (textBox6.Text == time)
            {
                MessageBox.Show($"{textBox5.Text}", "時間到",
                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                wplayer.URL = $"{MusPath[0]}";
            }
            else if (textBox8.Text == time)
            {
                MessageBox.Show($"{textBox7.Text}", "時間到",
                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                wplayer.URL = $"{MusPath[0]}";
            }
            else if (textBox10.Text == time)
            {
                MessageBox.Show($"{textBox9.Text}", "時間到",
                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                wplayer.URL = $"{MusPath[0]}";
            }
        }

        private void RichTextBox3_KeyPress(object sender, KeyPressEventArgs e)//Sec
        {
            // e.KeyChar == (Char)48 ~ 72 -----> 0~24
            // e.KeyChar == (Char)8 -----------> Backpace
            // e.KeyChar == (Char)13-----------> Enter
            if ((e.KeyChar < 48) || (e.KeyChar > 57))//这是允许输入0-24数字
            {
                e.Handled = true;
            }
            if ((e.KeyChar == 13))
            {

                Button1_Click(sender, e);
            }

        }

        private void RichTextBox1_KeyPress(object sender, KeyPressEventArgs e)//hour
        {
            if ((e.KeyChar < 48) || (e.KeyChar > 57))//这是允许输入0-24数字
            {
                e.Handled = true;
            }
            if ((e.KeyChar ==13))
            {
                
                Min.Focus();
            }
        }

        private void RichTextBox2_KeyPress(object sender, KeyPressEventArgs e)//min
        {
            if ((e.KeyChar < 48) || (e.KeyChar > 57))//这是允许输入0-24数字
            {
                e.Handled = true;
            }
            if ((e.KeyChar == 13))
            {
                Sec.Focus();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Sec.ReadOnly = false;
            Min.ReadOnly = false;
            Hour.ReadOnly = false;
            Sec.Text = seC[0];
            Min.Text = miN[0];
            Hour.Text = houR[0];
            count = 0;
            button1.Text = "開始";
            timer1.Stop();
            wplayer.close();
            this.TopMost = false;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            

            count3++;
            Hour.Visible = false;
            Min.Visible = false;
            Sec.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            button3.Text = "計時器";

            if (count3 == 2)
            {
                timer1.Stop();
                button3.Text = "鬧鐘";
                Hour.Visible = true;
                Min.Visible = true;
                Sec.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox9.Visible = false;
                textBox10.Visible = false;
                count3 = 0;
            }
        }

        private void Timer_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon1.Visible = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            wplayer.close();
            count++;
            Min.ReadOnly = true;
            Sec.ReadOnly = true;
            Hour.ReadOnly = true;
            button1.Text = "暫停";
            


            if (string.IsNullOrEmpty(Sec.Text))
            {
              Sec.Text = "00";           
              sec = int.Parse (Sec.Text);//FormatException:            
            }
            else
            {
                seC[0] = Sec.Text;
                sec = int.Parse(Sec.Text);//FormatException: 

            }
            if (string.IsNullOrEmpty(Min.Text))
            {
                Min.Text = "00";
                min = int.Parse(Min.Text);
            }
            else
            {
                miN[0] = Min.Text;
                min = int.Parse(Min.Text);

            }
            if (string.IsNullOrEmpty(Hour.Text))
            {
                Hour.Text = "00";
                hour = int.Parse(Hour.Text);
            }
            else
            {
                houR[0] = Hour.Text;
                hour = int.Parse(Hour.Text);
            }

            if (sec>60)
            {
                Sec.Text = "59";
            }
            if (min>60)
            {
                Min.Text = "59";
            }
            if (hour>24)
            {
                Hour.Text = "23";
            }
            timer1.Start();
            if (count==2)
            {
                timer1.Stop();
                button1.Text = "開始";
                count=0;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if (sec>0)
            {
                sec = sec - 1;
                Sec.Text = sec.ToString();
            }
            else if (min!=0&&sec==0)
            {
                //int m = min - 1;
                min = min - 1;  
                Min.Text = min.ToString();

                sec = 59;
                Sec.Text = "59";
            }
            else if (hour!=0&&min==0&&sec==0)
            {
                hour = hour - 1;
                Hour.Text = hour.ToString();
                min = 59;
                sec = 59;
                Min.Text = "59";
                Sec.Text = "59";
            }
            if (hour==0&&min==0&&sec==0)
            {
                Min.ReadOnly = false;
                Sec.ReadOnly = false;
                Hour.ReadOnly = false;
                //MessageBox.Show("時間到了");
                button1.Text = "開始";
                timer1.Stop();
                count = 0;
                //this.WindowState = FormWindowState.Normal;
                this.TopMost = true;

                //this.Show(this);
                //wplayer.URL = $@"{AppDomain.CurrentDomain.BaseDirectory}\Music\Janji - Heroes Tonight (feat. Johnning) [NCS Release].mp3";
                wplayer.URL = $"{MusPath[0]}";
                Sec.Text = seC[0];
                Min.Text = miN[0];
                Hour.Text = houR[0];

                MessageBox.Show("時間到");
               

                //Path.GetFileName(filE);
                //$@"E:\Download\Janji - Heroes Tonight (feat. Johnning) [NCS Release].mp3";

            }
            
                //
        }
    }
}
