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
using System.IO;
using AxWMPLib;

namespace practice_6_2
{
    public partial class Form1 : Form
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        Button[] keys = new Button[16];
        string[] values = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#", "❌", "📱", "⬅️" };
        string[] rowPath = new string[] { "697", "770", "852", "941" };
        string[] colPath = new string[] { "1209", "1336", "1477" };
        //((ISupportInitialize)(_row)).BeginInit();
        AxWindowsMediaPlayer[] row = new AxWindowsMediaPlayer[4];
        AxWindowsMediaPlayer[] col = new AxWindowsMediaPlayer[3];
        bool trigger = false;

        public Form1()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            displayNumber.Font = new Font("標楷體", 20, FontStyle.Bold);
            displayNumber.Text = "Telephone";
            histoty.Text = "";
            for (int i = 0; i < row.Length; i++)
            {
                row[i] = new AxWindowsMediaPlayer();
                row[i].BeginInit();
                Telephone.Controls.Add(row[i]);
                row[i].EndInit();
                row[i].Visible = false;
                row[i].URL = new FileInfo($"../../audio/{rowPath[i]}.wav").FullName;
                row[i].settings.setMode("loop", true);
                row[i].Ctlcontrols.stop();
            }
            for (int i = 0; i < col.Length; i++)
            {
                col[i] = new AxWindowsMediaPlayer();
                col[i].BeginInit();
                Telephone.Controls.Add(col[i]);
                col[i].EndInit();
                col[i].Visible = false;
                col[i].URL = new FileInfo($"../../audio/{colPath[i]}.wav").FullName;
                col[i].settings.setMode("loop", true);
                col[i].Ctlcontrols.stop();
            }
            for (int i = 1; i <= 15; i++)
            {
                keys[i] = new Button();
                keys[i].Text = values[i-1];
                keys[i].Font = new Font("標楷體", 20, FontStyle.Bold);
                keys[i].SetBounds(100 + 70 * ((i-1) % 3), 100 + 70 * ((i-1) / 3), 60, 60);
                Telephone.Controls.Add(keys[i]);
                int idx = i;
                keys[i].MouseDown += (s, e) => Keys_MouseDown(values[idx - 1], idx);
                keys[i].MouseUp += (s, e) => Keys_MouseUp(values[idx - 1], idx);
            }
        }
        private void reRender()
        {
            displayNumber.Font = new Font("標楷體", 20, FontStyle.Bold);
            displayNumber.Text = "Telephone";
            for (int i = 1; i <= 15; i++)
            {
                keys[i].Text = values[i - 1];
                keys[i].Enabled = true;
            }
        }
        private void Keys_MouseDown(string value, int idx)
        {
            //displayNumber.Text = row[(idx - 1) / 3].SoundLocation + " " + col[(idx - 1) % 3].SoundLocation;
            if (idx <= 12)
            {
                if (displayNumber.Text == "Telephone") displayNumber.Text = "";
                displayNumber.Text += value;
                row[(idx - 1) / 3].Ctlcontrols.play();
                col[(idx - 1) % 3].Ctlcontrols.play();
            }
            else
            {
                if (idx == 15 && displayNumber.Text != "Telephone" && displayNumber.Text != "")
                {
                    displayNumber.Text = displayNumber.Text.Substring(0, displayNumber.Text.Length - 1);
                }
                else if (idx == 14)
                {
                    if (keys[14].Text == "📱")
                    {
                        for (int i = 1; i < keys.Length; i++) if (i != 14) keys[i].Enabled = false;
                        keys[14].Text = "📵";
                        histoty.Text += displayNumber.Text + "\n";
                    }
                    else
                    {
                        reRender();
                    }
                }
                else if (idx == 13)
                {
                    displayNumber.Text = "";
                }
            }
        }
        private void Keys_MouseUp(string value, int idx)
        {
            for (int i = 0; i < row.Length; i++) row[i].Ctlcontrols.stop();
            for (int i = 0; i < col.Length; i++) col[i].Ctlcontrols.stop();
            //displayNumber.Text = "Telephone";
            if (idx <= 12)
            {
                row[(idx - 1) / 3].Ctlcontrols.stop();
                col[(idx - 1) % 3].Ctlcontrols.stop();
            }
        }
        

        private void mainTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (keys[14].Text != "📱") return;
            if (trigger) return;
            
            if (mainTab.SelectedIndex == 0)
            {
                //displayNumber.Text = e.KeyData.ToString();
                
                if (e.Shift && e.KeyCode == Keys.D8) //*
                {
                    Keys_MouseDown("*", 10);
                    trigger = true;
                }
                else if (e.Shift && e.KeyCode == Keys.D3) //#
                {
                    Keys_MouseDown("#", 12);
                    trigger = true;
                }
                else if (e.KeyCode == Keys.Back) //backspace
                {
                    Keys_MouseDown("⬅️", 15);
                }
                else if (e.KeyCode == Keys.Enter && keys[14].Text == "📱")
                {
                    Keys_MouseDown("📱", 14);
                }
                else if (!e.Shift && e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
                {
                    string v = (e.KeyValue - 48).ToString();
                    int idx = Array.IndexOf(values, v) + 1;
                    Keys_MouseDown(v, idx);
                    trigger = true;
                }
                //displayNumber.Text = e.KeyData.ToString();
            }
            
        }

        private void mainTab_KeyUp(object sender, KeyEventArgs e)
        {
            if (!trigger) return;
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                string v = (e.KeyValue - 48).ToString();
                int idx = Array.IndexOf(values, v) + 1;
                Keys_MouseUp(v, idx);
                trigger = false;
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            string path = inputFilename.Text;
            if (path == "")
            {
                MessageBox.Show("Empty String");
                return;
            }
            if (!File.Exists(path))
            {
                MessageBox.Show("Directory Not Found");
                return;
            }
            var writer = new StreamWriter(File.OpenWrite(path));
            writer.WriteLine(histoty.Text);
            FileInfo fileInfo = new FileInfo(path);
            MessageBox.Show($"Done\n{fileInfo.FullName}");
            writer.Close();
        }
    }
}
