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
    public partial class Nand_Nor3 : Form
    {
        public Nand_Nor3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                andOn7.Visible = false;
            }
            else
            {
                andOn7.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nand_TB_3 truth_table_nand_3 = new Nand_TB_3();
            truth_table_nand_3.Show();
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

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                orOn8.Visible = true;
            }
            else{
                orOn8.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkBox4.Checked || checkBox5.Checked || checkBox6.Checked)
            {
                orOn9.Visible = false;
            }
            else
            {
                orOn9.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nor_TB_3 nor_truth_3 = new Nor_TB_3();
            nor_truth_3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
