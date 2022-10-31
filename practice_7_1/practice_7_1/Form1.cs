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
        string filename = "";
        public Form1()
        {
            InitializeComponent();
            render();
        }

        void render()
        {
            txtToDo.Lines = new string[0];
            txtToDo.Lines = toDoList.ToArray();
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
                        toDoList.Add(line);
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
                foreach (var item in toDoList)
                {
                    sw.WriteLine(item);
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
            this.Enabled = false;
            form2.FormClosing += (_s, _e) => onForm2Closing(_s, _e);
            form2.ShowDialog();
        }

        void onForm2Closing(object sender, EventArgs e)
        {
            Form2 form2 = (Form2)sender;
            if(form2.isConfirmed)
            {
                toDoList.Add(form2.getItemName());
                render();
            }
            this.Enabled = true;
        }
    }
}
