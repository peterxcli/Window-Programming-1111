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
    public partial class menuWindow : Form
    {
        public menuWindow()
        {
            InitializeComponent();
            initSubComponent();
            this.ActiveControl = btnStart;
        }
        public void initSubComponent()
        {
            displayInputStatus.Text = "請輸入測資";
            inStack1.Text = "1 1 2";
            inStack2.Text = "2 2";
            inStack3.Text = "";
            inStack4.Text = "3 3 3 1";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
                {"1", 0},
                {"2", 0},
                {"3", 0},
            };
            List<string> stacks = new List<string>() { inStack1.Text, inStack2.Text, inStack3.Text, inStack4.Text };
            foreach (string stack in stacks)
            {
                if (stack.StartsWith(" ") || stack.Split(new char[1]{' ' }).Length > 4 )
                {
                    displayInputStatus.Text = "測資錯誤";
                    return;
                }
                foreach(var item in stack)
                {
                    if (item != ' ' && !Char.IsDigit(item))
                    {
                        displayInputStatus.Text = "測資錯誤";
                        return;
                    }
                    if (dic.ContainsKey(item.ToString())) dic[item.ToString()]++;
                }
            }
            foreach (var item in dic)
            {
                if (item.Value != 3)
                {
                    displayInputStatus.Text = "測資錯誤";
                    return;
                }
            }
            displayInputStatus.Text = "測資正確";
            //for (int i = 0; i < stacks.Count; i++) Debug.WriteLine(stacks[i]);
            gamingWindow gw = new gamingWindow(stacks.ToArray());
            this.Hide();
            gw.ShowDialog();
            this.Close();
            //Application.Exit();
        }
    }
}