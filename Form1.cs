using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Form frmMain { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                var newform = new Form2();
                newform.Show();
            }
            if (checkBox2.Checked == true)
            {
                var newform = new Form3();
                newform.Show();
            }
            if (checkBox3.Checked == true)
            {
                var newform = new Form4();
                newform.Show();
            }
            if (checkBox4.Checked == true)
            {
                var newform = new Form5();
                newform.Show();
            }
            if (checkBox5.Checked == true)
            {
                var newform = new Form6();
                newform.Show();
            }
            if (checkBox6.Checked == true)
            {
                var newform = new Form7();
                newform.Show();
            }
            if (checkBox7.Checked == true)
            {
                var newform = new Form10();
                newform.Show();
            }
            if (checkBox8.Checked == true)
            {
                var newform = new Form9();
                newform.Show();
            }
            if (checkBox9.Checked == true)
            {
                var newform = new Form8();
                newform.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Process.Start("https://www.canva.com/design/DAF1Y9aFd0M/93FeJWJu4d0vT9n-Ovh9eg/edit?utm_content=DAF1Y9aFd0M&utm_campaign=designshare&utm_medium=link2&utm_source=sharebutton");
            }
            if (checkBox2.Checked == true)
            {
                Process.Start("https://youtu.be/16HagG-_iL4?si=WQvoIEDZd0PgKPKk");
            }
            if (checkBox3.Checked == true)
            {
                Process.Start("https://youtu.be/Ze5ag7DdNpw?si=UmYvQWFYsjd8YiEC");
            }
            if (checkBox4.Checked == true)
            {
                Process.Start("https://youtu.be/rHTzuWKAH-k?si=3QBHfeUJfvhveNAn");
            }
            if (checkBox5.Checked == true)
            {
                Process.Start("https://youtu.be/75JrAx4hBC0?si=d8MzzeBExIbanQV7");
            }
            if (checkBox6.Checked == true)
            {
                Process.Start("https://youtu.be/Y7cd26QBsdE?si=K3RD_-YkYBpfOWmA");
            }
            if (checkBox7.Checked == true)
            {
                Process.Start("https://youtu.be/XfyGv-xwjlI?si=r3ZkL-FKuWe9qTYa");
            }
            if (checkBox8.Checked == true)
            {
                Process.Start("");
            }
            if (checkBox9.Checked == true)
            {
                Process.Start("https://youtu.be/HRojNa5RXL4?si=y5hAmzluhGnWD2A5");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var newform = new Form11();
            newform.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
