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
    public partial class Nor_Nand_4 : Form
    {
        public Nor_Nand_4()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                andOn4.Visible = true;
            }
            else
            {
                andOn4.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                andOn5.Visible = true;
            }
            else
            {
                andOn5.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                andOn6.Visible = true;
            }
            else
            {
                andOn6.Visible = false;
            }
        }

        private void andXor8_CheckedChanged(object sender, EventArgs e)
        {
            if (andXor8.Checked)
            {
                pictureBox6.Visible = true;
            }
            else
            {
                pictureBox6.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && andXor8.Checked)
            {
                andOn7.Visible = false;
            }
            else
            {
                andOn7.Visible = true;
            }
        }

        private void a_xnor_CheckedChanged(object sender, EventArgs e)
        {
            if (a_xnor.Checked)
            {
                orOn6.Visible = true;
            }
            else
            {
                orOn6.Visible = false;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void b_xnor_CheckedChanged(object sender, EventArgs e)
        {
            if (b_xnor.Checked)
            {
                orOn7.Visible = true;
            }
            else
            {
                orOn7.Visible = false;
            }
        }

        private void c_xnor_CheckedChanged(object sender, EventArgs e)
        {
            if (c_xnor.Checked)
            {
                orOn8.Visible = true;
            }
            else
            {
                orOn8.Visible = false;
            }
        }

        private void d_xnor_CheckedChanged(object sender, EventArgs e)
        {
            if (d_xnor.Checked)
            {
                pictureBox8.Visible = true;
            }
            else
            {
                pictureBox8.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!a_xnor.Checked && !b_xnor.Checked && !c_xnor.Checked && !d_xnor.Checked)
            {
                orOn9.Visible = true;
            }
            else
            {
                orOn9.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nor_4_Tb nornad4 = new Nor_4_Tb();
            nornad4.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nand_TB_4 nortad = new Nand_TB_4();
            nortad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nor_Nand_4_Load(object sender, EventArgs e)
        {

        }
    }
}
