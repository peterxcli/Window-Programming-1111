using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace practice_6_1
{
    public partial class Form1 : Form
    {
        Button[] btns;
        bool playsecond = false;
        int tempo = 4;
        int bpm = 60;
        int beat = 4;
        int beatIdx = 0;
        bool isStart = false;
        //string path = @"C:\Users\peter\OneDrive\文件\成大\視窗程式設計\week7\awaken.wav";
        //SoundPlayer player = new SoundPlayer();
        SoundPlayer ding = new SoundPlayer(@"..\..\assets\audio\ding.wav");
        SoundPlayer dong = new SoundPlayer(@"..\..\assets\audio\dong.wav");
        SoundPlayer doo = new SoundPlayer(@"..\..\assets\audio\doo.wav");


        public Form1()
        {
            InitializeComponent();
            btns = new Button[8];
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i] = new Button();
                Controls.Add(btns[i]);
            }
            timer1.Interval = 60000 / bpm;
            comboBox1.Text = "4";
            show4();
            timer1.Stop();
            label2.Text = $"{bpm} BPM";
        }

        private void show4()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Visible = (i < 4);
                btns[i].BackColor = Color.White;
                btns[i].SetBounds(80 + 130 * i, 125, 40, 40);
            }
        }
        private void show8()
        {
            for (int i = 0; i < btns.Length; i++)
            {
                btns[i].Visible = true;
                btns[i].BackColor = Color.White;
                btns[i].SetBounds(80 + 60 * i, 125, 40, 40);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempo == 8)
            {
                if (!playsecond)
                {
                    int prev = (beatIdx - 1 + beat) % beat;
                    btns[prev].BackColor = Color.White;
                    if (beatIdx == 0) ding.Play(); else dong.Play();
                    btns[beatIdx].BackColor = Color.LightGreen;
                    beatIdx = (beatIdx + 1 + beat) % beat;
                }
                else
                {
                    doo.Play();
                }
                playsecond = !playsecond;
            }
            else
            {
                int prev = (beatIdx - 1 + beat) % beat;
                btns[prev].BackColor = Color.White;
                if (beatIdx == 0) ding.Play(); else dong.Play();
                btns[beatIdx].BackColor = Color.LightGreen;
                beatIdx = (beatIdx + 1 + beat) % beat;
            }
            
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!isStart)
            {
                timer1.Start();
                isStart = true;
                btnStart.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                isStart = false;
                btnStart.Text = "Start";
            }
            if (beat == 4) show4();
            else show8();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (!isStart) return;
            tempo = 4;
            timer1.Interval = 60000 / bpm / (tempo / 4);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (!isStart) return;
            tempo = 8;
            timer1.Interval = 60000 / bpm / (tempo / 4);
            playsecond = false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            bpm = trackBar1.Value;
            label2.Text = $"{bpm} BPM";
            timer1.Interval = 60000 / bpm / (tempo/4);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            beat = int.Parse(comboBox1.Text);
            if (beat == 4) show4();
            else show8();
            beatIdx = 0;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = "ding.wav";
            //sp.PlayLooping();
            //sp.Play();
        }
    }
}
