using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_2
{
    public partial class Form1 : Form
    {
        int prev = -1, cur = 0, score = 100;
        Button[] b = new Button[16];
        int[] imgIndex = new int[16];
        int[] isSame = new int[16];
        List<int> order = new List<int>();
        Random rng = new Random();
        string name = "";
        //Dictionary<string, int> histories = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            name = inputName.Text;
            if (name == "")
            {
                MessageBox.Show("名稱不能為空白", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (name.Length < 3 || name.Length > 10) {
                MessageBox.Show("名稱不合格式( >= 3 && <= 10)", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < b.Length; i++) b[i].Visible = true;
            inputName.Enabled = false;
            btnResume.Enabled = false;
            btnStart.Enabled = false;
        }
        void btnClick(int index)
        {
            if (index == prev) return;
            b[index].ImageIndex = imgIndex[index];
            if (prev != -1)
            {
                if (imgIndex[prev] == imgIndex[index])
                {
                    isSame[prev] = isSame[index] = 1;
                    b[prev].Enabled = false;
                    b[index].Enabled = false;
                    prev = -1;
                    score += 10;
                }
                else
                {
                    cur = index;
                    for (int i = 0; i < 16; i++) if (i != prev && i != cur) b[i].Enabled = false;
                    btnResume.Enabled = true;
                    score -= 5;
                }
            }
            else
            {
                prev = index;
            }
            labelScore.Text = "分數: " + score;
            for (int i = 0; i < 16; i++) if (isSame[i] == 0) return;
            for (int i = 0; i < 16; i++) b[i].Enabled = false;
            scoreboard.Text += name + " 得分為: " + score + "\n\n";
            var op = MessageBox.Show("分數 : " + score, "遊戲結束", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);
            if (op == DialogResult.Retry) init();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++) if (isSame[i] == 0) b[i].Enabled = true;
            b[cur].ImageIndex = 8;
            b[prev].ImageIndex = 8;
            prev = -1;
            btnResume.Enabled = false;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            var op = MessageBox.Show("確定要離開遊戲嗎?", "離開遊戲", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (op == DialogResult.Yes) Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++) b[i] = new Button();
            for (int i = 0; i < 16; i++)
            {
                b[i].SetBounds(90 * (i / 4) + 40, 90 * (i % 4) + 60, 70, 85);
                b[i].ImageList = imageList1;
                int index = i;
                b[i].Click += (S, E) => btnClick(index);
                tabPage1.Controls.Add(b[i]);
            }
            init();
            scoreboard.Text = "";
        }
        void init()
        {
            for (int i = 0; i < 16; i++) b[i].Visible = false;
            for (int i = 0; i < 16; i++) b[i].Enabled = true;
            score = 100;
            prev = -1;
            labelScore.Text = "分數: " + score;
            labelName.Text = "名稱: ";
            inputName.Text = "";
            labelScore.Visible = true;
            labelName.Visible = true;
            btnResume.Enabled = false;
            inputName.Enabled = true;
            btnStart.Enabled = true;
            order.Clear();
            for (int i = 0; i < 16; i++) order.Add(i);
            int n = order.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = order[k];
                order[k] = order[n];
                order[n] = value;
            }
            for (int i = 0; i < 16; i++)
            {
                isSame[i] = 0;
                b[i].ImageIndex = 8;
                imgIndex[i] = order[i] % 8;
            }
        }
    }
}
