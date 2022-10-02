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
            double money = double.Parse(txtCapi.Text);//本金
            double years = double.Parse(txtYear.Text);//年期
            double yrate = double.Parse(txtRate.Text);//年利率
            double total;//本利和
            total = money * Math.Pow((1 + yrate / 100), years);
            label4.Text = "accumulated amount= NT$ " + total.ToString("#,#.0") + " 元";
            label4.Text += "\nTotal interest= NT$ " + (total - money).ToString("#,#.0") + " 元";//總利息
        }
    }
}