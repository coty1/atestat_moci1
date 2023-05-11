using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace X0
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void enable_false()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
        }
        void score()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X","X0",MessageBoxButtons.OK,MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button1.Text == "X" && button4.Text == "X" && button7.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button4.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button1.Text == "X" && button5.Text == "X" && button9.Text == "X")
            {
                button1.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
            {
                button5.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
                button8.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button3.Text == "X" && button6.Text == "X" && button9.Text == "X")
            {
                button6.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                button5.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button4.Text == "X" && button5.Text == "X" && button6.Text == "X")
            {
                button4.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button6.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            if (button7.Text == "X" && button8.Text == "X" && button9.Text == "X")
            {
                button7.BackColor = Color.Pink;
                button8.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul X", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label5.Text);
                label5.Text = Convert.ToString(plusone + 1);
                enable_false();
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////////////
            if (button1.Text == "0" && button2.Text == "0" && button3.Text == "0")
            {
                button1.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button1.Text == "0" && button4.Text == "0" && button7.Text == "0")
            {
                button1.BackColor = Color.Pink;
                button4.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button1.Text == "0" && button5.Text == "0" && button9.Text == "0")
            {
                button1.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button2.Text == "0" && button5.Text == "0" && button8.Text == "0")
            {
                button5.BackColor = Color.Pink;
                button2.BackColor = Color.Pink;
                button8.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button3.Text == "0" && button6.Text == "0" && button9.Text == "0")
            {
                button6.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button3.Text == "0" && button5.Text == "0" && button7.Text == "0")
            {
                button5.BackColor = Color.Pink;
                button7.BackColor = Color.Pink;
                button3.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button4.Text == "0" && button5.Text == "0" && button6.Text == "0")
            {
                button4.BackColor = Color.Pink;
                button5.BackColor = Color.Pink;
                button6.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }
            if (button7.Text == "0" && button8.Text == "0" && button9.Text == "0")
            {
                button7.BackColor = Color.Pink;
                button8.BackColor = Color.Pink;
                button9.BackColor = Color.Pink;

                MessageBox.Show("Castigatorul este Jucatorul 0", "X0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(label4.Text);
                label4.Text = Convert.ToString(plusone+1);
                enable_false();
            }


        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button1.Text = "X";
                checker = true;
            }
            else {
                button1.Text = "0";
                checker = false;
            }
            score();
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button2.Text = "X";
                checker = true;
            }
            else
            {
                button2.Text = "0";
                checker = false;
            }
            score();
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button3.Text = "X";
                checker = true;
            }
            else
            {
                button3.Text = "0";
                checker = false;
            }
            score();
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button4.Text = "X";
                checker = true;
            }
            else
            {
                button4.Text = "0";
                checker = false;
            }
            score();
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button5.Text = "X";
                checker = true;
            }
            else
            {
                button5.Text = "0";
                checker = false;
            }
            score();
            button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button6.Text = "X";
                checker = true;
            }
            else
            {
                button6.Text = "0";
                checker = false;
            }
            score();
            button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button7.Text = "X";
                checker = true;
            }
            else
            {
                button7.Text = "0";
                checker = false;
            }
            score();
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button8.Text = "X";
                checker = true;
            }
            else
            {
                button8.Text = "0";
                checker = false;
            }
            score();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                button9.Text = "X";
                checker = true;
            }
            else
            {
                button9.Text = "0";
                checker = false;
            }
            score();
            button9.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try{
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            label5.Text = "0";
            label4.Text = "0";

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;}
        catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try {
 
            
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button10.Enabled = true;

            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;}
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Confirma daca vrei sa parasesti jocul", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (iExit == DialogResult.OK)
                    Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
