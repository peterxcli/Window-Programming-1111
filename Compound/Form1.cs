namespace Compound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Text = "";
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            double money = double.Parse(txtCapi.Text);//����
            double years = double.Parse(txtYear.Text);//�~��
            double yrate = double.Parse(txtRate.Text);//�~�Q�v
            double total;//���Q�M
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = "accumulated amount= NT$ " + total.ToString("#,#.0") + " ��";
            label4.Text += "\nTotal interest= NT$ " + (total - money).ToString("#,#.0") + " ��";//�`�Q��
        }
    }
}