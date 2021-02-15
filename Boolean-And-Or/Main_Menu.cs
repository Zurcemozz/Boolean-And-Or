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
    public partial class Main_Menu : Form
    {
        private const int CB_SETCUEBANNER = 0x1703;

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)] string lParam);
        public Main_Menu()
        {

            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 2)
            {
                AND_OR_4 and4 = new AND_OR_4();
                and4.Show();
            }
            if (comboBox1.SelectedIndex == 0)
            {
                And_Or_2 and_1 = new And_Or_2();
                and_1.Show();
            }
            if (comboBox1.SelectedIndex == 1)
            {
                And_Or_3 and_3 = new And_Or_3();
                and_3.Show();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox2.SelectedIndex == 2)
            {
                Nor_Nand_4 nornand4 = new Nor_Nand_4();
                nornand4.Show();
            }
            if (comboBox2.SelectedIndex == 1) {
                Nand_Nor3 nand_3 = new Nand_Nor3();
                nand_3.Show();
            }
            if (comboBox2.SelectedIndex == 0)
            {
                Nand_Nor2 nand_2 = new Nand_Nor2();
                nand_2.Show();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if(comboBox3.SelectedIndex == 2)
            {
                Xor_Xnor4 xorxo4 = new Xor_Xnor4();
                xorxo4.Show();
            }
            if(comboBox3.SelectedIndex == 1)
            {
                Xor_Xnor3 xnorxnand3 = new Xor_Xnor3();
                xnorxnand3.Show();
            }
            if(comboBox3.SelectedIndex == 0)
            {
                Xor_Xnor2 xorxand2 = new Xor_Xnor2();
                xorxand2.Show();
            }
        }

        private void Main_Menu_Load(object sender, EventArgs e)
        {
            SendMessage(this.comboBox1.Handle, CB_SETCUEBANNER, 0, "--Select--");
            SendMessage(this.comboBox2.Handle, CB_SETCUEBANNER, 0, "--Select--");
            SendMessage(this.comboBox3.Handle, CB_SETCUEBANNER, 0, "--Select--");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
