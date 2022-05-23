namespace Johan_TicTacToe
{
    public partial class Form1 : Form
    {
        int flip = 1;
        
        public Form1()
        {
            InitializeComponent();
            pctOx1y1.Visible=false;
            pctXx1y1.Visible=false;
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
        private void pctOx1y1_Click(object sender, EventArgs e)
        {
            //pctOx1y1.Visible = false;
        }
        private void btn11_Click(object sender, EventArgs e)
        {
            btn11.Enabled = false;
            btn11.Visible = false;
            flip = flip + 1;
            if (flip % 2 == 0) 
            {
                //MessageBox.Show("0");
                pctOx1y1.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx1y1.Visible = true;
            }
            
            
        }
        private void btn33_Click(object sender, EventArgs e)
        {
            
        }

        private void pctXx1y1_Click(object sender, EventArgs e)
        {
            //pctXx1y1.Visible = false;
        }
    }
}