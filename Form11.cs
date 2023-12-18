using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 2;
            if (checkBox2.Checked == true)
                i++;
            if (checkBox9.Checked == true)
                i++;
            if (checkBox13.Checked == true)
                i++; 
            if (checkBox18.Checked == true)
                i++; 
            if (checkBox25.Checked == true)
                i++;
            if (checkBox29.Checked == true)
                i++; 
            if (checkBox6.Checked == true)
                i++;
            if (checkBox32.Checked == true)
                i++;
            MessageBox.Show(i.ToString());
            
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
