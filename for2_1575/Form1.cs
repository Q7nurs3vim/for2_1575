namespace for2_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 25; i < 76; i++)
            {
                lbSayi.Items.Add(i);
            }
        }
    }
}