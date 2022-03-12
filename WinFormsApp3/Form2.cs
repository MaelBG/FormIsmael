using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
