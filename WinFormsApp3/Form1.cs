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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Form2 frm2 = new Form2();


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            panel1.BackColor = Color.FromArgb(78, 184, 206);
            textBox1.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.PasswordChar = '*';
            panel2.BackColor = Color.FromArgb(78, 184, 206);
            textBox2.ForeColor = Color.FromArgb(78, 184, 206);

            panel1.BackColor = Color.WhiteSmoke;
            textBox1.ForeColor = Color.WhiteSmoke;

            panel3.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;

        }

        
        
        //Form3 frm3 = new Form3();
        //Form4 frm4 = new Form4();


        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            panel3.BackColor = Color.FromArgb(78, 184, 206);
            textBox3.ForeColor = Color.FromArgb(78, 184, 206);

            panel2.BackColor = Color.WhiteSmoke;
            textBox2.ForeColor = Color.WhiteSmoke;

            panel1.BackColor = Color.WhiteSmoke;
            textBox3.ForeColor = Color.WhiteSmoke;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label2.Text = frm2.Left.ToString();
            frm2.Left += 10;
            if(frm2.Left >= 835)
            {
                timer1.Stop();
                this.TopMost = false;
                frm2.TopMost = true;
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //label2.Text = frm2.Left.ToString();
            frm2.Left -= 10;
            if(frm2.Left <=760)
            {
                timer2.Stop();
            }

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            frm2.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
