namespace Johan_TicTacToe
{
    public partial class Form1 : Form
    {
        int flip = 1;
        
        public Form1()
        {
            InitializeComponent();
            //First Row
            pctOx1y1.Visible=false;
            pctXx1y1.Visible=false;

            pctOx2y1.Visible = false;
            pctXx2y1.Visible = false;

            pctOx3y1.Visible = false;
            pctXx3y1.Visible = false;

            //Second Row
            pctOx1y2.Visible = false;
            pctXx1y2.Visible = false;

            pctOx2y2.Visible = false;
            pctXx2y2.Visible = false;

            pctOx3y2.Visible = false;
            pctXx3y2.Visible = false;

            //Third Row
            pctOx1y3.Visible = false;
            pctXx1y3.Visible = false;

            pctOx2y3.Visible = false;
            pctXx2y3.Visible = false;

            pctOx3y3.Visible = false;
            pctXx3y3.Visible = false;
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

        private void btn21_Click(object sender, EventArgs e)
        {
            btn21.Enabled = false;
            btn21.Visible = false;
            flip = flip + 1;
            if (flip % 2 == 0)
            {
                //MessageBox.Show("0");
                pctOx2y1.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx2y1.Visible = true;
            }
        }
    }
}