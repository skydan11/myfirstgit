using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 newfrm = new Form1();
            newfrm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      /*  private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button2.Enabled = false;
                checkBox2.Checked = false;
            }
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                button2.Enabled = true;


            }
            if (checkBox2.Checked == false)
            {
                button2.Enabled = false;
            }
        }
        */
        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button2.Enabled = false;
                checkBox2.Checked = false;
            }
            if (checkBox1.Checked == false)
            {
                button2.Enabled = false;
            }

        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                button2.Enabled = true;


            }
            if (checkBox2.Checked == false)
            {
                button2.Enabled = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
