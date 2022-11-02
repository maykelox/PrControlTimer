namespace PrControlTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblhora.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToLongTimeString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int num = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            num = num + 1;
            if(num % 2==0)
            {
                lbla.Visible = true;
                lblb.Visible = false;
            }
            else
            {
                lbla.Visible = false;
                lblb.Visible = true;
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}