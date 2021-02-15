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
    public partial class Nand_Nor2 : Form
    {
        public Nand_Nor2()
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
            if(checkBox1.Checked && checkBox2.Checked)
            {
                andOn7.Visible = false;
            }
            else
            {
                andOn7.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkBox5.Checked || checkBox6.Checked)
            {
                orOn9.Visible = false;
            }
            else
            {
                orOn9.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nand_TB_2 nan2 = new Nand_TB_2();
            nan2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nor_TB2 nor_2 = new Nor_TB2();
            nor_2.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
