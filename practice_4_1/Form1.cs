using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_4_1
{
    public partial class Form1 : Form
    {
        int prev = -1, cur = 0;
        Button[] b = new Button[16];
        int[] imgIndex = new int[16];
        int[] isSame = new int[16];
        List<int> order = new List<int>();
        Random rng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
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
                b[i] = new Button();
                b[i].SetBounds(90 * (i/4) + 40, 90 * (i%4) + 60, 70, 85);
                b[i].ImageList = imageList1;
                b[i].ImageIndex = 8;
                imgIndex[i] = order[i]%8;
                int index = i;
                b[i].Click += (S, E) => btnClick(index);
                Controls.Add(b[i]);
            }
            btnResume.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 16; i++) if (isSame[i] == 0) b[i].Enabled = true;
            b[cur].ImageIndex = 8;
            b[prev].ImageIndex = 8;
            prev = -1;
            btnResume.Enabled = false;
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnResume.Enabled = false;
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
                }
                else
                {
                    cur = index;
                    for (int i = 0; i < 16; i++) if (i != prev && i != cur) b[i].Enabled = false;
                    btnResume.Enabled = true;
                }
            }
            else
            {
                prev = index;
            }
            for (int i = 0; i < 16; i++) if (isSame[i] == 0) return;
            for (int i = 0; i < 16; i++) b[i].Enabled = false;
            MessageBox.Show("你贏了");
        }
    }
}
