using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boolean_And_Or
{
    public partial class And_Or_2 : Form
    {
        public And_Or_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (chkBox1.Checked || chkBox2.Checked)
            {
                picResult.Visible = true;
            }
        }

        private void chkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox1.Checked)
            {
                picOn1.Visible = true;
            }
            else
            {
                picOn1.Visible = false;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void picOn2_Click(object sender, EventArgs e)
        {

        }

        private void chkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBox2.Checked)
            {
                picOn2.Visible = true;
            }
            else
            {
                picOn2.Visible = false;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (chkBox1.Checked && chkBox2.Checked)
            {
                picResult.Visible = true;
            }
            else
            {
                picResult.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked || checkBox2.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                Or_On.Visible = true;
            }
            else
            {
                Or_On.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Or_on1.Visible = true;
            }
            else
            {
                Or_on1.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            And_TB_2 form3 = new And_TB_2();
            form3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
          

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Or_TB_2 form4 = new Or_TB_2();
            form4.Show();
        }

        private void picOn1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
