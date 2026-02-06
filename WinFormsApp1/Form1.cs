namespace WinFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtNum1.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            txtResult.Text = (a + b) + "";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            txtResult.Text = (a - b) + "";
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            txtResult.Text = (a * b) + "";
        }

        private void btnQuotien_Click(object sender, EventArgs e)
        {
            int.TryParse(txtNum1.Text, out int a);
            int.TryParse(txtNum2.Text, out int b);
            if (b == 0)
            {
                MessageBox.Show("Number 2 must not be zero", "Error Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double d = Convert.ToDouble(a) / b;
                txtResult.Text = d + "";
            }
        }
    }
}
