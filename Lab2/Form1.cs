namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_BT1_Click(object sender, EventArgs e)
        {
            BT1 form = new BT1();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_BT2_Click(object sender, EventArgs e)
        {
            BT2 form = new BT2();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void btn_BT3_Click(object sender, EventArgs e)
        {
            BT3 form = new BT3();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
