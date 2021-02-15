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
    public partial class XNOR_TB_3 : Form
    {
        public XNOR_TB_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked) || (!checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)  ||
                (checkBox1.Checked && !checkBox2.Checked && checkBox3.Checked) ||
                (checkBox1.Checked && checkBox2.Checked && !checkBox3.Checked))
            {
                label37.Text = "1";
            }
            else
            {
                label37.Text = "0";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
