using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace practice_7_1
{
    public partial class Form1 : Form
    {
        List<string> toDoList = new List<string>();
        List<bool> isComplete = new List<bool>();
        string[] prev;
        string filename = "";
        public Form1()
        {
            InitializeComponent();
            btnCloseSearch.Visible = false;
            render();
        }

        void render()
        {
            txtToDo.Lines = new string[0];
            string[] tmp = new string[toDoList.Count];
            for (int i = 0; i < toDoList.Count; i++)
            {
                string t = (isComplete[i] ? "✓" : "  ");
                tmp[i] = $"[{t}]   {toDoList[i]}";
            }
            txtToDo.Lines = tmp;
        }

        private void menuNew_Click(object sender, EventArgs e)
        {
            filename = "";
            toDoList.Clear();
            render();
        }

        void readFile(string _filename)
        {
            if (!File.Exists(_filename)) return;
            try
            {
                toDoList.Clear();
                using (StreamReader sr = new StreamReader(_filename))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        isComplete.Add((line[0] == '+' ? true : false));
                        toDoList.Add(line.Substring(1, line.Length-1));
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        void writeFile(string _filename)
        {
            if (_filename == "") return;
            using (StreamWriter sw = new StreamWriter(_filename))
            {
                for (int i = 0; i < toDoList.Count; i++)
                {
                    sw.WriteLine($"{(isComplete[i] ? "+" : "-")}{toDoList[i]}");
                }
            }
        }

        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            if (!File.Exists(filename)) { filename = ""; return; }
            readFile(filename);
            render();
        }

        private void menuSave_Click(object sender, EventArgs e)
        {
            if (filename == "")
            {
                menuSaveAs_Click(sender, e);
            }
            else
            {
                writeFile(filename);
            }
        }

        private void menuSaveAs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Todo Files(*.todo)|*.todo|Text Files(*.txt)|*.txt|All Files(*.*)|*.*";
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog();
            //txtToDo.Text = saveFileDialog1.FileName;
            writeFile(saveFileDialog1.FileName);
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) { txtToDo.Font = fontDialog1.Font; }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "新增代辦事項";
            this.Enabled = false;
            form2.FormClosing += (_s, _e) => onForm2ClosingAdd(_s, _e);
            form2.ShowDialog();
        }

        void onForm2ClosingAdd(object sender, EventArgs e)
        {
            Form2 form2 = (Form2)sender;
            if(form2.isConfirmed)
            {
                toDoList.Add(form2.getItemName());
                isComplete.Add(false);
                render();
            }
            this.Enabled = true;
        }
        void onForm2ClosingFinish(object sender, EventArgs e)
        {
            Form2 form2 = (Form2)sender;
            if (form2.isConfirmed)
            {
                //toDoList.Add(form2.getItemName());
                int idx = toDoList.IndexOf(form2.getItemName());
                if (idx != -1) isComplete[idx] = true;
                render();
            }
            this.Enabled = true;
        }

        void onForm2ClosingDelete(object sender, EventArgs e)
        {
            Form2 form2 = (Form2)sender;
            if (form2.isConfirmed)
            {
                //toDoList.Add(form2.getItemName());
                int idx = toDoList.IndexOf(form2.getItemName());
                if (idx != -1)
                {
                    toDoList.RemoveAt(idx);
                    isComplete.RemoveAt(idx);
                }
                render();
            }
            this.Enabled = true;
        }

        void onForm2ClosingFind(object sender, EventArgs e)
        {
            Form2 form2 = (Form2)sender;
            if (form2.isConfirmed)
            {
                menuStrip1.Enabled = false;
                btnCloseSearch.Visible = true;
                btnAdd.Visible = false;
                btnFinish.Visible = false;
                prev = (string[])txtToDo.Lines.Clone();
                txtToDo.Lines = new string[0];
                List<string> tmp = new List<string>();
                for (int i = 0; i < toDoList.Count; i++)
                {
                    if (toDoList[i].IndexOf(form2.getItemName()) == -1) continue;
                    string t = (isComplete[i] ? "✓" : "  ");
                    tmp.Add($"[{t}]   {toDoList[i]}");
                }
                txtToDo.Lines = tmp.ToArray();
            }
            this.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "代辦事項";
            this.Enabled = false;
            form2.FormClosing += (_s, _e) => onForm2ClosingFinish(_s, _e);
            form2.ShowDialog();
        }

        private void menuDisplayAll_Click(object sender, EventArgs e)
        {
            render();
        }

        void renderUnfinished()
        {
            txtToDo.Lines = new string[0];
            List<string> tmp = new List<string>();
            for (int i = 0; i < toDoList.Count; i++)
            {
                if (isComplete[i]) continue;
                string t = (isComplete[i] ? "✓" : "  ");
                tmp.Add($"[{t}]   {toDoList[i]}");
            }
            txtToDo.Lines = tmp.ToArray();
        }

        private void menuDisplayUnfinushed_Click(object sender, EventArgs e)
        {
            renderUnfinished();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            btnAdd_Click(sender, e);
        }

        private void menuFinish_Click(object sender, EventArgs e)
        {
            btnFinish_Click(sender, e);
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "代辦事項";
            this.Enabled = false;
            form2.FormClosing += (_s, _e) => onForm2ClosingDelete(_s, _e);
            form2.ShowDialog();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Text = "代辦事項";
            this.Enabled = false;
            form2.FormClosing += (_s, _e) => onForm2ClosingFind(_s, _e);
            form2.ShowDialog();
        }

        private void btnCloseSearch_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            txtToDo.Lines = prev;
            prev = new string[0];
            btnCloseSearch.Visible = false;
            btnAdd.Visible = true;
            btnFinish.Visible = true;
        }
    }
}
