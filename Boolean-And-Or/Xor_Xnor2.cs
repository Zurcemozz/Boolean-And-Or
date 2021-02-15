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
    public partial class Xor_Xnor2 : Form
    {
        public Xor_Xnor2()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(!checkBox1.Checked && !checkBox2.Checked)
            {
                andOn7.Visible = false;
            }else if(!checkBox1.Checked && checkBox2.Checked)
            {
                andOn7.Visible = true;
            }else if(checkBox1.Checked && !checkBox2.Checked)
            {
                andOn7.Visible = true;
            }
            else if(checkBox2.Checked && checkBox1.Checked)
            {
                andOn7.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XOR_TB_2 xor2 = new XOR_TB_2();
            xor2.Show();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                orOn6.Visible = true;
            }
            else
            {
                orOn6.Visible = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                orOn7.Visible = true;
            }
            else
            {
                orOn7.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XNOR_TB2 xnor2 = new XNOR_TB2();
            xnor2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((!checkBox5.Checked && !checkBox6.Checked) || (checkBox5.Checked && checkBox6.Checked))
            {
                orOn9.Visible = true;
            }
            else
            {
                orOn9.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
