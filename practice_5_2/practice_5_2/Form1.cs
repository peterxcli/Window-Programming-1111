using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_5_2
{
    public partial class Form1 : Form
    {
        string[] strCmd = new string[] { "攻擊", "移動", "技能", "待機", "結束"};
        Button[,] btnGrid;
        Button[] btnP1, btnP2;
        Button[] btnP1Control, btnP2Control;
        List<Chess> P1, P2;
        bool isP1 = true;
        bool isPrepareSession = false;
        int timerCount;
        int prepareIdx;
        int controlIdx;
        int chessIdx;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            btnGrid = new Button[8, 7];
            btnP1 = new Button[3];
            btnP2 = new Button[3];
            btnP1Control = new Button[5];
            btnP2Control = new Button[5];
            P1 = new List<Chess>();
            P2 = new List<Chess>();
            displayP1Turn.Visible = false;
            displayP2Turn.Visible = false;
            displayTimer.Visible = false;
            displayP1Status.Visible = false;
            displayP2Status.Visible = false;
            //displayP1Status.Text = displayP2Status.Text = "";
            displayP1Turn.Text = "P1";
            displayP2Turn.Text = "P2";
        }

        void init()
        {
            for (int i = 1; i < btnGrid.GetLength(0); i++)
            {
                for (int j = 1; j < btnGrid.GetLength(1); j++)
                {
                    btnGrid[i, j] = new Button();
                    btnGrid[i, j].SetBounds(50*j+200, 50*i+20, 50, 50);
                    int _i = i, _j = j;
                    btnGrid[i, j].Click += (s, e) => btnGrid_Click(_i, _j);
                    //btnGrid[i, j].Text = "";
                    Controls.Add(btnGrid[i, j]);
                    //btnGrid[i, j].Text = $"{i}, {j}";
                }
            }
            for (int i = 0; i < btnP1.Length; i++)
            {
                btnP1[i] = new Button();
                btnP1[i].SetBounds(70, 30*i+200, 100, 25);
                int index = i;
                btnP1[i].Click += (s, e) => btnP1_Click(index);
                btnP1[i].BringToFront();
                Controls.Add(btnP1[i]);
            }
            for (int i = 0; i < btnP2.Length; i++)
            {
                btnP2[i] = new Button();
                btnP2[i].SetBounds(650, 30 * i+200, 100, 25);
                int index = i;
                btnP2[i].Click += (s, e) => btnP2_Click(index);
                Controls.Add(btnP2[i]);
            }
            P1.Add(new Warrior());
            P1.Add(new Mage());
            P1.Add(new Ranger());
            P2.Add(new Warrior());
            P2.Add(new Mage());
            P2.Add(new Ranger());
            for (int i = 0; i < btnP1.Length; i++) btnP1[i].Text = $"{P1[i].character}: {(P1[i].hp > 0 ? 1 : 0)}顆";
            for (int i = 0; i < btnP2.Length; i++) btnP2[i].Text = $"{P2[i].character}: {(P2[i].hp > 0 ? 1 : 0)}顆";
            displayP1Turn.Visible = true;
            displayP2Turn.Visible = true;
            displayTimer.Visible = true;
            displayP1Status.Visible = false;
            displayP2Status.Visible = false;
        }
        void initFighting()
        {
            displayP1Status.Visible = true;
            displayP2Status.Visible = true;
            displayP1Turn.Text = "P1";
            displayP2Turn.Text = "P2";
            for (int i = 0; i < btnP1.Length; i++) btnP1[i].Dispose();
            for (int i = 0; i < btnP2.Length; i++) btnP2[i].Dispose();
            for (int i = 0; i < btnP1Control.Length; i++)
            {
                btnP1Control[i] = new Button();
                btnP1Control[i].SetBounds(70+50*(i%2), 30 * (i/2) + 350, (i==btnP1Control.Length-1 ? 95 : 45), 25);
                btnP1Control[i].Text = strCmd[i];
                int index = i;
                btnP1Control[i].Click += (s, e) => btnControl_Click(index);
                Controls.Add(btnP1Control[i]);
            }
            for (int i = 0; i < btnP2Control.Length; i++)
            {
                btnP2Control[i] = new Button();
                btnP2Control[i].SetBounds(650 + 50 * (i % 2), 30 * (i / 2) + 350, (i == btnP2Control.Length - 1 ? 95 : 45), 25);
                btnP2Control[i].Text = strCmd[i];
                int index = i;
                btnP2Control[i].Click += (s, e) => btnControl_Click(index);
                Controls.Add(btnP2Control[i]);
            }
            for (int i = 1; i < btnGrid.GetLength(0); i++) for (int j = 1; j < btnGrid.GetLength(1); j++) btnGrid[i, j].Enabled = true;
            isP1 = true;
            step();
        }

        void step()
        {
            for (int i = 0; i < btnP1Control.Length; i++) btnP1Control[i].Enabled = isP1;
            for (int i = 0; i < btnP2Control.Length; i++) btnP2Control[i].Enabled = !isP1;
            btnP1Control[btnP1Control.Length - 1].Enabled = false;
            btnP2Control[btnP2Control.Length - 1].Enabled = false;
            if (isP1)
            {
                displayTimer.Text = "P1 Turn";
            }
            else
            {
                displayTimer.Text = "P2 Turn";
            }
            warrior();
        }
        private string ChessToStatus(Chess chess)
        {
            return $"{chess.character}\nHP: {chess.hp}\nMP: {chess.mp}\nATK: {chess.atk}\nATK Range: {chess.atkRange}\nMOVE Range: {chess.moveRange}";
        }

        void warrior()
        {
            int idx = 0;
            chessIdx = 0;
            if (isP1)
            {
                if (P1[idx].hp <= 0) { mage(); return; }
                displayP1Status.Text = ChessToStatus(P1[idx]);
                displayP2Status.Text = "";
            }
            else
            {
                if (P2[idx].hp <= 0) { mage(); return; }
                displayP2Status.Text = ChessToStatus(P2[idx]);
                displayP1Status.Text = "";
            }
        }
        void mage()
        {
            int idx = 1;
            chessIdx = 1;
            if (isP1)
            {
                if (P1[idx].hp <= 0){ ranger(); return; }
                displayP1Status.Text = ChessToStatus(P1[idx]);
                displayP2Status.Text = "";
            }
            else
            {
                if (P2[idx].hp <= 0) { ranger(); return; }
                displayP2Status.Text = ChessToStatus(P2[idx]);
                displayP1Status.Text = "";
            }
        }
        void ranger()
        {
            int idx = 2;
            chessIdx = 2;
            if (isP1)
            {
                if (P1[idx].hp <= 0) {
                    for (int i = 0; i < btnP1Control.Length; i++) btnP1Control[i].Enabled = false;
                    btnP1Control[4].Enabled = true;
                    return;
                }
                displayP1Status.Text = ChessToStatus(P1[idx]);
                displayP2Status.Text = "";
            }
            else
            {
                if (P2[idx].hp <= 0) {
                    for (int i = 0; i < btnP2Control.Length; i++) btnP2Control[i].Enabled = false;
                    btnP2Control[4].Enabled = true;
                    return;
                }
                displayP2Status.Text = ChessToStatus(P2[idx]);
                displayP1Status.Text = "";
            }
        }

        void prepareSession()
        {
            prepareIdx = 0;
            if (isP1)
            {
                for (int i = 1; i < btnGrid.GetLength(0); i++) for (int j = 1; j < btnGrid.GetLength(1); j++) btnGrid[i, j].Enabled = (j <= btnGrid.GetLength(1) / 2);
                for (int i = 0; i < btnP1.Length; i++) btnP1[i].Enabled = true;
                for (int i = 0; i < btnP2.Length; i++) btnP2[i].Enabled = false;
                displayP1Turn.Text = $"P1\n{P1[prepareIdx].character}";
            }
            else
            {
                for (int i = 1; i < btnGrid.GetLength(0); i++) for (int j = 1; j < btnGrid.GetLength(1); j++) btnGrid[i, j].Enabled = (j > btnGrid.GetLength(1)/2);
                for (int i = 0; i < btnP1.Length; i++) btnP1[i].Enabled = false;
                for (int i = 0; i < btnP2.Length; i++) btnP2[i].Enabled = true;
                displayP2Turn.Text = $"P2\n{P2[prepareIdx].character}";
            }
            isPrepareSession = true;
            timerCount = 10;
            timer1.Enabled = true;
            
            
            displayTimer.Text = $"準備階段\n{timerCount}";
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnStart.Enabled = false;
            init();
            prepareSession();
        }
        private bool isAtkRange(int i, int j)
        {
            if (isP1)
            {
                return (
                        (i == P1[chessIdx].row && Math.Abs(P1[chessIdx].col - j) <= P1[chessIdx].atkRange)
                        ||
                        (j == P1[chessIdx].col && Math.Abs(P1[chessIdx].row - i) <= P1[chessIdx].atkRange)
                    );
            }
            else
            {
                return (
                        (i == P2[chessIdx].row && Math.Abs(P2[chessIdx].col - j) <= P2[chessIdx].atkRange)
                        ||
                        (j == P2[chessIdx].col && Math.Abs(P2[chessIdx].row - i) <= P2[chessIdx].atkRange)
                    );
            }
            
        }
        private bool isMoveRange(int i, int j)
        {
            if (isP1)
            {
                return (
                        (i == P1[chessIdx].row && Math.Abs(P1[chessIdx].col - j) <= P1[chessIdx].moveRange)
                        ||
                        (j == P1[chessIdx].col && Math.Abs(P1[chessIdx].row - i) <= P1[chessIdx].moveRange)
                    );
            }
            else
            {
                return (
                        (i == P2[chessIdx].row && Math.Abs(P2[chessIdx].col - j) <= P2[chessIdx].moveRange)
                        ||
                        (j == P2[chessIdx].col && Math.Abs(P2[chessIdx].row - i) <= P2[chessIdx].moveRange)
                    );
            }

        }
        void detectP2Result()
        {
            for (int i = 0; i < P2.Count; i++) if (P2[i].hp > 0) return;
            MessageBox.Show("P1贏了");
            Application.Exit();
        }
        void detectP1Result()
        {
            for (int i = 0; i < P1.Count; i++) if (P1[i].hp > 0) return;
            MessageBox.Show("P2贏了");
            Application.Exit();
        }
        private void btnGrid_Click(int i, int j)
        {
            if (isPrepareSession)
            {
                if (isP1)
                {
                    btnP1[prepareIdx].Enabled = false;
                    P1[prepareIdx].row = i;
                    P1[prepareIdx].col = j;
                    btnGrid[i, j].BackColor = Color.LightBlue;
                    btnGrid[i, j].Text = P1[prepareIdx].toStr();
                    btnP1[prepareIdx].Text = $"{P1[prepareIdx].character}: 0顆";
                }
                else
                {
                    btnP2[prepareIdx].Enabled = false;
                    P2[prepareIdx].row = i;
                    P2[prepareIdx].col = j;
                    btnGrid[i, j].BackColor = Color.LightPink;
                    btnGrid[i, j].Text = P2[prepareIdx].toStr();
                    btnP2[prepareIdx].Text = $"{P2[prepareIdx].character}: 0顆";
                }
            }
            else
            {
                if (controlIdx == 0)
                {
                    if (isP1)
                    {
                        if (isAtkRange(i, j))
                        {
                            for (int k = 0; k < P2.Count; k++)
                            {
                                if (P2[k].row == i && P2[k].col == j)
                                {
                                    P2[k].hp -= P1[chessIdx].atk;
                                    if (P2[k].hp <= 0)
                                    {
                                        btnGrid[P2[k].row, P2[k].col].BackColor = Color.White;
                                        btnGrid[P2[k].row, P2[k].col].Text = "";
                                    } 
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("超出攻擊範圍");
                            if (chessIdx == 0) { warrior(); return; }
                            else if (chessIdx == 1) { mage(); return; }
                            else if (chessIdx == 2) { ranger(); return; }
                        }
                    }
                    else
                    {
                        if (isAtkRange(i, j))
                        {
                            for (int k = 0; k < P1.Count; k++)
                            {
                                if (P1[k].row == i && P1[k].col == j)
                                {
                                    P1[k].hp -= P2[chessIdx].atk;
                                    if (P1[k].hp <= 0)
                                    {
                                        btnGrid[P1[k].row, P1[k].col].BackColor = Color.White;
                                        btnGrid[P1[k].row, P1[k].col].Text = "";
                                        P1[k].col = P1[k].row = -1;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("超出攻擊範圍");
                            if (chessIdx == 0) { warrior(); return; }
                            else if (chessIdx == 1) { mage(); return; }
                            else if (chessIdx == 2) { ranger(); return; }
                        }
                    }
                }
                else if (controlIdx == 1)
                {
                    if (isP1)
                    {
                        if (isMoveRange(i, j))
                        {
                            btnGrid[P1[chessIdx].row, P1[chessIdx].col].BackColor = Color.White;
                            btnGrid[P1[chessIdx].row, P1[chessIdx].col].Text = "";
                            btnGrid[i, j].BackColor = Color.LightBlue;
                            P1[chessIdx].row = i; P1[chessIdx].col = j;
                            btnGrid[i, j].Text = P1[chessIdx].toStr();
                        }
                        else
                        {
                            MessageBox.Show("超出移動範圍");
                            if (chessIdx == 0) { warrior(); return; }
                            else if (chessIdx == 1) { mage(); return; }
                            else if (chessIdx == 2) { ranger(); return; }
                        }
                    }
                    else
                    {
                        if (isMoveRange(i, j))
                        {
                            btnGrid[P2[chessIdx].row, P2[chessIdx].col].BackColor = Color.White;
                            btnGrid[P2[chessIdx].row, P2[chessIdx].col].Text = "";
                            btnGrid[i, j].BackColor = Color.LightPink;
                            P2[chessIdx].row = i; P2[chessIdx].col = j;
                            btnGrid[i, j].Text = P2[chessIdx].toStr();
                        }
                        else
                        {
                            MessageBox.Show("超出移動範圍");
                            if (chessIdx == 0) { warrior(); return; }
                            else if (chessIdx == 1) { mage(); return; }
                            else if (chessIdx == 2) { ranger(); return; }
                        }
                    }
                }
                else if (controlIdx == 2)
                {
                    if (isP1)
                    {
                        if (chessIdx == 0)
                        {
                            if (isAtkRange(i, j))
                            {
                                for (int k = 0; k < P2.Count; k++)
                                {
                                    if (P2[k].row == i && P2[k].col == j)
                                    {
                                        P1[chessIdx].hp += P1[chessIdx].atk / 2;
                                        P2[k].hp -= P1[chessIdx].atk;
                                        if (P2[k].hp <= 0)
                                        {
                                            btnGrid[P2[k].row, P2[k].col].BackColor = Color.White;
                                            btnGrid[P2[k].row, P2[k].col].Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P1[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                        else if (chessIdx == 1)
                        {
                            if (isAtkRange(i, j))
                            {
                                for (int k = 0; k < P2.Count; k++)
                                {
                                    if (P2[k].row == i && P2[k].col == j)
                                    {
                                        P2[k].hp -= P1[chessIdx].atk*2;
                                        if (P2[k].hp <= 0)
                                        {
                                            btnGrid[P2[k].row, P2[k].col].BackColor = Color.White;
                                            btnGrid[P2[k].row, P2[k].col].Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P1[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                        else if (chessIdx == 2)
                        {
                            P1[chessIdx].atkRange++;
                            if (isAtkRange(i, j))
                            {
                                P1[chessIdx].atkRange--;
                                for (int k = 0; k < P2.Count; k++)
                                {
                                    if (P2[k].row == i && P2[k].col == j)
                                    {
                                        P2[k].hp -= P1[chessIdx].atk;
                                        if (P2[k].hp <= 0)
                                        {
                                            btnGrid[P2[k].row, P2[k].col].BackColor = Color.White;
                                            btnGrid[P2[k].row, P2[k].col].Text = "";
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P1[chessIdx].atkRange--;
                                P1[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                    }
                    else
                    {
                        if (chessIdx == 0)
                        {
                            if (isAtkRange(i, j))
                            {
                                for (int k = 0; k < P1.Count; k++)
                                {
                                    if (P1[k].row == i && P1[k].col == j)
                                    {
                                        P2[chessIdx].hp += P2[chessIdx].atk / 2;
                                        P1[k].hp -= P2[chessIdx].atk;
                                        if (P1[k].hp <= 0)
                                        {
                                            btnGrid[P1[k].row, P1[k].col].BackColor = Color.White;
                                            btnGrid[P1[k].row, P1[k].col].Text = "";
                                            P1[k].col = P1[k].row = -1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P2[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                        else if (chessIdx == 1)
                        {
                            if (isAtkRange(i, j))
                            {
                                for (int k = 0; k < P1.Count; k++)
                                {
                                    if (P1[k].row == i && P1[k].col == j)
                                    {
                                        P1[k].hp -= P2[chessIdx].atk*2;
                                        if (P1[k].hp <= 0)
                                        {
                                            btnGrid[P1[k].row, P1[k].col].BackColor = Color.White;
                                            btnGrid[P1[k].row, P1[k].col].Text = "";
                                            P1[k].col = P1[k].row = -1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P2[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                        else if (chessIdx == 2)
                        {
                            P2[chessIdx].atkRange++;
                            if (isAtkRange(i, j))
                            {
                                P2[chessIdx].atkRange--;
                                for (int k = 0; k < P1.Count; k++)
                                {
                                    if (P1[k].row == i && P1[k].col == j)
                                    {
                                        P1[k].hp -= P2[chessIdx].atk;
                                        if (P1[k].hp <= 0)
                                        {
                                            btnGrid[P1[k].row, P1[k].col].BackColor = Color.White;
                                            btnGrid[P1[k].row, P1[k].col].Text = "";
                                            P1[k].col = P1[k].row = -1;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                P2[chessIdx].atkRange--;
                                P2[chessIdx].mp += 10;
                                MessageBox.Show("超出攻擊範圍");
                                if (chessIdx == 0) { warrior(); return; }
                                else if (chessIdx == 1) { mage(); return; }
                                else if (chessIdx == 2) { ranger(); return; }
                            }
                        }
                    }
                }

                detectP1Result();
                detectP2Result();

                if (chessIdx == 0) { mage(); return; }
                else if (chessIdx == 1) { ranger(); return; }
                else if (chessIdx == 2) {
                    for (int k = 0; k < btnP1Control.Length; k++) btnP1Control[k].Enabled = false;
                    for (int k = 0; k < btnP2Control.Length; k++) btnP2Control[k].Enabled = false;
                    btnP1Control[4].Enabled = isP1;
                    btnP2Control[4].Enabled = !isP1;
                    return;
                }
                return;
            }
        }

        private void btnControl_Click(int idx)
        {
            if (idx == 3)
            {
                if (chessIdx == 0) { mage(); return; }
                else if (chessIdx == 1) { ranger(); return; }
                else if (chessIdx == 2)
                {
                    for (int k = 0; k < btnP1Control.Length; k++) btnP1Control[k].Enabled = false;
                    for (int k = 0; k < btnP2Control.Length; k++) btnP2Control[k].Enabled = false;
                    btnP1Control[4].Enabled = isP1;
                    btnP2Control[4].Enabled = !isP1;
                    return;
                }
                return;
            }
            else if (idx == 4)
            {
                isP1 = !isP1;
                step();
                return;
            }
            else if (idx == 2)
            {
                if (isP1)
                {
                    if (P1[chessIdx].mp < 10)
                    {
                        if (chessIdx == 0) { mage(); return; }
                        else if (chessIdx == 1) { ranger(); return; }
                        else if (chessIdx == 2)
                        {
                            for (int k = 0; k < btnP1Control.Length; k++) btnP1Control[k].Enabled = false;
                            for (int k = 0; k < btnP2Control.Length; k++) btnP2Control[k].Enabled = false;
                            btnP1Control[4].Enabled = isP1;
                            btnP2Control[4].Enabled = !isP1;
                            return;
                        }
                        return;
                    }
                    else
                    {
                        P1[chessIdx].mp -= 10;
                        displayP1Status.Text = ChessToStatus(P1[chessIdx]);
                        if (chessIdx == 2)
                        {
                            P1[chessIdx].atkRange++;
                            displayP1Status.Text = ChessToStatus(P1[chessIdx]);
                            P1[chessIdx].atkRange--;
                        }
                    }
                }
                else
                {
                    if (P2[chessIdx].mp < 10)
                    {
                        if (chessIdx == 0) { mage(); return; }
                        else if (chessIdx == 1) { ranger(); return; }
                        else if (chessIdx == 2)
                        {
                            for (int k = 0; k < btnP1Control.Length; k++) btnP1Control[k].Enabled = false;
                            for (int k = 0; k < btnP2Control.Length; k++) btnP2Control[k].Enabled = false;
                            btnP1Control[4].Enabled = isP1;
                            btnP2Control[4].Enabled = !isP1;
                            return;
                        }
                        return;
                    }
                    else
                    {
                        P2[chessIdx].mp -= 10;
                        displayP2Status.Text = ChessToStatus(P2[chessIdx]);
                        if (chessIdx == 2)
                        {
                            P2[chessIdx].atkRange++;
                            displayP2Status.Text = ChessToStatus(P2[chessIdx]);
                            P2[chessIdx].atkRange--;
                        }
                    }
                }
            }
            controlIdx = idx;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerCount--;
            displayTimer.Text = $"準備階段\n{timerCount}";
            if (timerCount == 0 && isP1)
            {
                checkRemainChess();
                isP1 = false;
                prepareSession();
            }
            if (timerCount == 0 && !isP1)
            {
                checkRemainChess();
                isPrepareSession = false;
                timer1.Enabled = false;
                initFighting();
            }
        }

        private void checkRemainChess()
        {
            if (isP1)
            {
                for (int i = 0; i < P1.Count; i++)
                {
                    if (P1[i].row != -1 && P1[i].col != -1) continue;
                    for (int j = 1; j < btnGrid.GetLength(1); j++)
                    {
                        if (btnGrid[j, 1].Text == "")
                        {
                            btnGrid[j, 1].BackColor = Color.LightBlue;
                            
                            btnP1[i].Text = $"{P1[i].character}: 0顆";
                            btnP1[i].Enabled = false;
                            P1[i].row = j;
                            P1[i].col = 1;
                            btnGrid[j, 1].Text = P1[i].toStr();
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < P2.Count; i++)
                {
                    if (P2[i].row != -1 || P2[i].col != -1) continue;
                    for (int j = 1; j < btnGrid.GetLength(1); j++)
                    {
                        if (btnGrid[j, 6].Text == "")
                        {
                            btnGrid[j, 6].BackColor = Color.LightPink;
                            
                            btnP2[i].Text = $"{P2[i].character}: 0顆";
                            btnP2[i].Enabled = false;
                            P2[i].row = j;
                            P2[i].col = 6;
                            btnGrid[j, 6].Text = P2[i].toStr();
                            break;
                        }
                    }
                }
            }
        }

        private void btnP1_Click(int idx)
        {
            if (isPrepareSession)
            {
                prepareIdx = idx;
                displayP1Status.Text = P1[idx].character;
                displayP1Turn.Text = $"P1\n{P1[prepareIdx].character}";
            }
        }
        private void btnP2_Click(int idx)
        {
            if (isPrepareSession)
            {
                prepareIdx = idx;
                displayP2Status.Text = P2[idx].character;
                displayP2Turn.Text = $"P2\n{P2[prepareIdx].character}";
            }
        }

    }
}
