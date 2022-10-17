using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_5_1
{
    public partial class Form1 : Form
    {
        Button[] btnKeys;
        string word = "";
        int timeCounter = 0, errorCounter = 0;
        Dictionary<string, int> dict;
        public Form1()
        {
            InitializeComponent();
            btnKeysInit();
            timer1.Interval = 1000;
            dict = new Dictionary<string, int>();
            timer1.Tick += (s, e) => timer1_Tick(s, e);
        }
        void btnKeysInit()
        {
            btnKeys = new Button[26];
            for (int i = 0; i < 26; i++)
            {
                btnKeys[i] = new Button();
                int idx = i;
                btnKeys[i].KeyPress += (s, e) => OnKeyPress(s, e);
                this.Controls.Add(btnKeys[i]);
            }
        }
        void renderMenu()
        {
            dict.Clear();
            word = "";
            errorCounter = timeCounter = 0;

            label1.Visible = true;
            label2.Visible = true;
            btnStart.Visible = true;
            inputWord.Visible = true;
            

            for (int i = 0; i < 26; i++) btnKeys[i].Visible = false;
            displayErrorTime.Visible = false;
            displayTime.Visible = false;
            displayAnswer.Visible = false;

            btnStart.Enabled = true;
            inputWord.Enabled = true;

            label1.Text = "猜英文單字\n";
            label1.Text += "6次猜錯機會";
            label1.Font = new Font("標楷體", 20, FontStyle.Bold);
            inputWord.Text = "";

        }

        void renderPlayground()
        {
            for (int i = 0; i < 26; i++) btnKeys[i].Visible = true;
            for (int i = 0; i < 26; i++) btnKeys[i].Enabled = true;
            for (int i = 0; i < 26; i++) btnKeys[i].BackColor = Color.White;
            displayErrorTime.Visible = true;
            displayTime.Visible = true;
            displayAnswer.Visible = true;
            displayAnswer.Font = new Font("Arial", 12, FontStyle.Bold);

            label1.Visible = false;
            label2.Visible = false;
            btnStart.Visible = false;
            inputWord.Visible = false;

            btnStart.Enabled = false;
            inputWord.Enabled = false;

            char c = 'A';
            for (int i = 0; i < 26; i++, c++)
            {
                btnKeys[i].SetBounds(50 * (i % 10) + 150 + (i/10 == 2? 100:0), 50 * (i / 10) + 60, 40, 40);
                btnKeys[i].Text = c.ToString();
                btnKeys[i].Font = new Font("Arial", 12, FontStyle.Bold);
            }
            
            timer1.Enabled = true;
            displayTime.Text = "時間: " + timeCounter.ToString();
            displayErrorTime.Text = "猜錯次數: " + errorCounter.ToString();
            showResult();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            renderMenu();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            word = inputWord.Text;
            if (word == "") return;
            word = word.ToUpper();
            renderPlayground();
        }

        private void inputWord_TextChanged(object sender, EventArgs e)
        {
            string tmp = inputWord.Text;
            tmp = Regex.Replace(tmp, "[^a-zA-Z]+", "");
            inputWord.Text = tmp;
            inputWord.SelectionStart = tmp.Length;
            inputWord.SelectionLength = 0;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Length != Regex.Replace(e.KeyChar.ToString(), "[^a-zA-Z]+", "").Length) return;
            e.KeyChar.ToString();
            processAfterGuess(e.KeyChar.ToString().ToUpper());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeCounter++;
            displayTime.Text = "時間: " + timeCounter.ToString();
        }

        void processAfterGuess(string ch)
        {
            if (dict.ContainsKey(ch)) return;

            dict.Add(ch.ToString(), 1);

            if (word.IndexOf(ch.ToString()) == -1)
            {
                btnKeys[char.Parse(ch) - 'A'].Visible = false;
                btnKeys[char.Parse(ch) - 'A'].Enabled = false;
                errorCounter++;
                /*
                todo: guess wrong char
                */
            }
            else
            {
                btnKeys[char.Parse(ch) - 'A'].BackColor = Color.LightGreen;
            }
            showResult();

        }

        void showResult()
        {
            displayAnswer.Text = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (dict.ContainsKey(word[i].ToString())) displayAnswer.Text += word[i];
                else displayAnswer.Text += "_";
                displayAnswer.Text += (i == word.Length - 1 ? "" : "  ");
            }
            displayErrorTime.Text = "猜錯次數: " + errorCounter.ToString();
            if (isLose())
            {
                timer1.Enabled = false;
                MessageBox.Show("You Lose !");
                renderMenu();
            }
            else if (isWin())
            {
                timer1.Enabled = false;
                MessageBox.Show("花費時間: " + timeCounter + "\n" + "猜錯 " + errorCounter + "次" , "You win !");
                renderMenu();
            }
        }

        bool isWin()
        {
            foreach(var item in word) if (!dict.ContainsKey(item.ToString())) return false;
            return true;
        }

        bool isLose()
        {
            return errorCounter >= 6;
        }
    }
}
