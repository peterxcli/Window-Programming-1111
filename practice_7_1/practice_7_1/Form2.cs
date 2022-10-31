using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_7_1
{
    public partial class Form2 : Form
    {
        public bool isConfirmed = false;
        public Form2()
        {
            InitializeComponent();
        }
        public string getItemName()
        {
            return itemName.Text;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            isConfirmed = false;
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (itemName.Text == "")
            {
                MessageBox.Show("請輸入事項");
                return;
            }
            isConfirmed = true;
            this.Close();
        }
    }
}
