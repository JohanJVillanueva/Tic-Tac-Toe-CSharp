namespace Johan_TicTacToe
{
    public partial class Form1 : Form
    {
        int flip = 1;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Enabled = false;
            btn11.Visible = false;
            flip = flip + 1;
            if (flip % 2 == 0) 
            {
                MessageBox.Show("0");
            }
            else
            {
                MessageBox.Show("X");
            }
            
            
        }
    }
}