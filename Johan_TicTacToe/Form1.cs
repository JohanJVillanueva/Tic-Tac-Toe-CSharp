namespace Johan_TicTacToe
{
    public partial class Form1 : Form
    {
        bool flip = false;
        int count = 0;

        public Form1()
        {
            
            InitializeComponent();

            //First Row
            pctOx1y1.Visible = false;
            pctXx1y1.Visible = false;

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
            Application.Restart();
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            flip = !flip;
            if (flip)
            {
                lblStart.Text = ("Game will start with 0");
                //MessageBox.Show("Game will start with 0");
                btnMenu.BackgroundImage = Properties.Resources.menu2;
                
                

            }
            else
            {
                lblStart.Text = ("Game will start with X");
                //MessageBox.Show("Game will start with X");
                btnMenu.BackgroundImage = Properties.Resources.menu1;

            }

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
            btnMenu.Enabled = false;

           
     
            if (flip)
            {
                //MessageBox.Show("0");
                pctOx1y1.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx1y1.Visible = true;
            }

            //AI CODE FOR 0
            

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible) { 
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }


            flip = !flip;

        }
        private void btn33_Click(object sender, EventArgs e)
        {
            btn33.Enabled = false;
            btn33.Visible = false;
            btnMenu.Enabled = false;


            if (flip)
            {
                //MessageBox.Show("0");
                pctOx3y3.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx3y3.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void pctXx1y1_Click(object sender, EventArgs e)
        {
            //pctXx1y1.Visible = false;
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            btn21.Enabled = false;
            btn21.Visible = false;
            btnMenu.Enabled = false;


            if (flip)
            {
                //MessageBox.Show("0");
                pctOx2y1.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx2y1.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void btn31_Click(object sender, EventArgs e)
        {
            btn31.Enabled = false;
            btn31.Visible = false;
            btnMenu.Enabled = false;
   

            if (flip)
            {
                //MessageBox.Show("0");
                pctOx3y1.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx3y1.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            btn12.Enabled = false;
            btn12.Visible = false;
            btnMenu.Enabled = false;
     

            if (flip)
            {
                //MessageBox.Show("0");
                pctOx1y2.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx1y2.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            btn22.Enabled = false;
            btn22.Visible = false;
            btnMenu.Enabled = false;
           

            if (flip)
            {
                //MessageBox.Show("0");
                pctOx2y2.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx2y2.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void btn32_Click(object sender, EventArgs e)
        {
            btn32.Enabled = false;
            btn32.Visible = false;
            btnMenu.Enabled = false;
           

            if (flip)
            {
                //MessageBox.Show("0");
                pctOx3y2.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx3y2.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                } 

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            btn13.Enabled = false;
            btn13.Visible = false;
            btnMenu.Enabled = false;


            if (flip)
            {
                //MessageBox.Show("0");
                pctOx1y3.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx1y3.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }
            flip = !flip;
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            btn23.Enabled = false;
            btn23.Visible = false;
            btnMenu.Enabled = false;


            if (flip)
            {
                //MessageBox.Show("0");
                pctOx2y3.Visible = true;

            }
            else
            {
                //MessageBox.Show("X");
                pctXx2y3.Visible = true;
            }

            //AI CODE FOR 0

            if (pctOx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctOx1y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! 0");
                    }
                }
            }

            if (pctOx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctOx2y2.Visible)
                {
                    if (pctOx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctOx3y2.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctOx2y2.Visible)
                {
                    if (pctOx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctOx2y1.Visible)
                {
                    if (pctOx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctOx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctOx2y2.Visible)
                {
                    if (pctOx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctOx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctOx2y3.Visible)
                {
                    if (pctOx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! 0");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            //AI Code for X

            if (pctXx1y1.Visible)
            {
                //0XX
                //0XX
                //0XX
                if (pctXx1y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //0XX
                //X0X
                //XX0
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx3y1.Visible)
                    {
                        //MessageBox.Show("We have a winner! X");
                    }
                }
            }

            if (pctXx2y1.Visible)
            {
                //X0X
                //X0X
                //X0X
                if (pctXx2y2.Visible)
                {
                    if (pctXx2y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx3y1.Visible)
            {
                //XX0
                //XX0
                //XX0
                if (pctXx3y2.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //XX0
                //X0X
                //0XX
                if (pctXx2y2.Visible)
                {
                    if (pctXx1y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }

                //000
                //XXX
                //XXX
                if (pctXx2y1.Visible)
                {
                    if (pctXx1y1.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }
            if (pctXx1y2.Visible)
            {
                //XXX
                //000
                //XXX
                if (pctXx2y2.Visible)
                {
                    if (pctXx3y2.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            if (pctXx1y3.Visible)
            {
                //XXX
                //XXX
                //000
                if (pctXx2y3.Visible)
                {
                    if (pctXx3y3.Visible)
                    {
                        MessageBox.Show("We have a winner! X");
                        Application.Restart();
                        Environment.Exit(0);
                    }
                }
            }

            count = count + 1;
            if (count == 9)
            {
                MessageBox.Show("Draw");
                Application.Restart();
                Environment.Exit(0);
            }

            flip = !flip;
        }



        private void lblStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}