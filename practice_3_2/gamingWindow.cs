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

namespace practice_3_2
{
    public partial class gamingWindow : Form
    {
        private Game game;
        private bool isPicking = true;
        private int from, to;
        public gamingWindow(string[] input)
        {
            InitializeComponent();
            game = new Game(input);
            render();
        }
        private void render()
        {
            List<List<string> > stacks = new List<List<string> >(new List<string>[4]);
            for (int i = 0; i < stacks.Count; i++)
            {
                stacks[i] = new List<string> (new string[16]);
                var str = game.output(i);
                for(int j = 0; j < str.Length; j++)
                {
                    stacks[i][15-j] = str[j].ToString();
                }
                for (int k = 0; k < 16-str.Length; k++) stacks[i][k] = "";
            }
            stack0.Lines = stacks[0].ToArray();
            stack1.Lines = stacks[1].ToArray();
            stack2.Lines = stacks[2].ToArray();
            stack3.Lines = stacks[3].ToArray();
            btnStack0.Text = "選取";
            btnStack1.Text = "選取";
            btnStack2.Text = "選取";
            btnStack3.Text = "選取";
            btnStack0.Enabled = game.canTake(0);
            btnStack1.Enabled = game.canTake(1);
            btnStack2.Enabled = game.canTake(2);
            btnStack3.Enabled = game.canTake(3);
            displayResult.Text = "...";
            isPicking = true;
            this.ActiveControl = btnMenu;
            if (game.win()) doWin();

        }
        private void doWin()
        {
            btnStack0.Text = "贏";
            btnStack1.Text = "贏";
            btnStack2.Text = "贏";
            btnStack3.Text = "贏";
            btnStack0.Enabled = false;
            btnStack1.Enabled = false;
            btnStack2.Enabled = false;
            btnStack3.Enabled = false;
            displayResult.Text = "你贏了";
            this.ActiveControl = btnMenu;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            menuWindow menu = new menuWindow();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }
        private void doSelect()
        {
            btnStack0.Text = "放置";
            btnStack1.Text = "放置";
            btnStack2.Text = "放置";
            btnStack3.Text = "放置";
            btnStack0.Enabled = game.canPlace(0);
            btnStack1.Enabled = game.canPlace(1);
            btnStack2.Enabled = game.canPlace(2);
            btnStack3.Enabled = game.canPlace(3);
            this.ActiveControl = btnMenu;
        }

        private void btnStack0_Click(object sender, EventArgs e)
        {
            if (isPicking)
            {
                doSelect();
                isPicking = false;
                from = 0;
            }
            else
            {
                to = 0;
                game.move(from, to);
                render();
            }
        }

        private void btnStack1_Click(object sender, EventArgs e)
        {
            if (isPicking)
            {
                doSelect();
                isPicking = false;
                from = 1;
            }
            else
            {
                to = 1;
                game.move(from, to);
                render();
            }
        }

        private void btnStack2_Click(object sender, EventArgs e)
        {
            if (isPicking)
            {
                doSelect();
                isPicking = false;
                from = 2;
            }
            else
            {
                to = 2;
                game.move(from, to);
                render();
            }
        }

        private void btnStack3_Click(object sender, EventArgs e)
        {
            if (isPicking)
            {
                doSelect();
                isPicking = false;
                from = 3;
            }
            else
            {
                to = 3;
                game.move(from, to);
                render();
            }
        }

    }
}
