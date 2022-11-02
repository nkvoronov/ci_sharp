namespace WinFormsApp1
{
    public partial class fmTest : Form
    {
        public fmTest()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lbTitle.Text = "clk";
            MessageBox.Show("Привет !!!!");
        }
    }
}