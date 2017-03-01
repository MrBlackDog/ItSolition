using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["tabPage2"];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox4.Text)
                MessageBox.Show("Пароли не совпадают");
            else
                tabControl1.SelectedTab = tabControl1.TabPages["tabPage4"];
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = null;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            textBox6.Text = null;
        }
    }
}
