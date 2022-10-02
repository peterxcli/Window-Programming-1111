using System.ComponentModel.Design;
using System.Security.Principal;

namespace practice_3_1
{
    public partial class Form1 : Form
    {
        public List<Account> accounts;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            switchMode(true);
            initAllContent();
            accounts = new List<Account>();
        }
        public List<string> accountsToString(ref List<Account> tmp, string searchStr)
        {
            List<string> ret = new List<string>();
            foreach (Account account in tmp)
            {
                if (searchStr != "" && account.link.IndexOf(searchStr) == -1) continue;
                ret.Add("�s��: " + account.link + "\n");
                ret.Add("�ϥΪ�: " + account.user + "\n");
                ret.Add("�K�X: " + account.password + "\n");
                ret.Add("=================================\n");
            }
            return ret;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            displayZone.Clear();
            string searchStr = searchStringInput.Text;
            displayZone.Lines = accountsToString(ref accounts, searchStr).ToArray();
        }

        private void btnDisplayInsecure_Click(object sender, EventArgs e)
        {
            displayZone.Clear();
            List<string> res = new List<string>();
            for (int i = 0; i < accounts.Count; i++)
            {
                for (int j = 0; j < accounts.Count; j++)
                {
                    if (i == j || accounts[i].password != accounts[j].password) continue;
                    res.Add("�s��: " + accounts[i].link + "\n");
                    res.Add("�ϥΪ�: " + accounts[i].user + "\n");
                    res.Add("�K�X: " + accounts[i].password + "\n");
                    res.Add("=================================\n");
                }
            }
            displayZone.Lines = res.ToArray();
        }

        private void initAllContent()
        {
            searchStringInput.Clear();
            displayZone.Clear();
            displayModifyStatus.Text = "���ݫ��O";
            modifyLinkInput.Clear();
            modifyUserInput.Clear();
            modifyPasswordInput.Clear();
        }

        /// <summary>
        ///  true: home, false: modify
        /// </summary>
        private void switchMode(bool mode)
        {
            searchStringInput.Enabled = (mode ? true : false);
            btnSearch.Enabled = (mode ? true : false);
            btnDisplayInsecure.Enabled = (mode ? true : false);
            displayZone.Visible = (mode ? true : false);
            btnSwitchModify.Visible = (mode ? true : false);
            btnSwitchHome.Visible = (mode ? false : true);
            label4Link.Visible = (mode ? false : true);
            label4User.Visible = (mode ? false : true);
            label4Password.Visible = (mode ? false : true);
            modifyLinkInput.Visible = (mode ? false : true);
            modifyUserInput.Visible = (mode ? false : true);
            modifyPasswordInput.Visible = (mode ? false : true); 
            displayModifyStatus.Visible = (mode ? false : true);
            btnInsert.Visible = (mode ? false : true);
            btnRemove.Visible = (mode ? false : true);
        }

        private void btnSwitchModify_Click(object sender, EventArgs e)
        {
            initAllContent();
            switchMode(false);
        }

        private void btnSwitchHome_Click(object sender, EventArgs e)
        {
            initAllContent();
            switchMode(true);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string link = modifyLinkInput.Text;
            string user = modifyUserInput.Text;
            string password = modifyPasswordInput.Text;
            if (link == "" || user == "" || password == "")
            {
                displayModifyStatus.Text = "Don't leave blank. Please retry";
                return;
            }
            foreach (Account account in accounts)
            {
                if (account.link == link && account.user == user)
                {
                    displayModifyStatus.Text = "�b���w�s�b";
                    return;
                }
            }
            accounts.Add(new Account(link, user, password));
            displayModifyStatus.Text = "�s�W����";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string link = modifyLinkInput.Text;
            string user = modifyUserInput.Text;
            string password = modifyPasswordInput.Text;
            if (link == "" || user == "" || password == "")
            {
                displayModifyStatus.Text = "Don't leave blank. Please retry";
                return;
            }
            foreach (Account account in accounts)
            {
                if (account.link == link && account.user == user && account.password == password)
                {
                    displayModifyStatus.Text = "�R������";
                    accounts.Remove(account);
                    return;
                }
            }
            displayModifyStatus.Text = "�b�����s�b�αK�X���~";
        }

        private void modifyLinkInput_TextChanged(object sender, EventArgs e)
        {
            displayModifyStatus.Text = "��J��...";
        }

        private void modifyUserInput_TextChanged(object sender, EventArgs e)
        {
            displayModifyStatus.Text = "��J��...";
        }

        private void modifyPasswordInput_TextChanged(object sender, EventArgs e)
        {
            displayModifyStatus.Text = "��J��...";
        }
    }
}