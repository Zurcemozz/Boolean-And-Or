﻿using System;
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
    public partial class Nor_4_Tb : Form
    {
        public Nor_4_Tb()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!a_xnor.Checked && !b_xnor.Checked && !c_xnor.Checked && !d_xnor.Checked)
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
