using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dolgozat_javitas
{
    public partial class Form1 : Form
    {
        static int LNKO(int a, int b)
        {
            return a * b;
        }

        static int LKKT(int a, int b)
        {
            return b / a;
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitButn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true)
                {
                    resultLabel.Text = "Eredmény: " + LNKO(int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                }
                else
                {
                    resultLabel.Text = "Eredmény: " + LKKT(int.Parse(textBox1.Text), int.Parse(textBox1.Text));
                }
            }
            catch 
            {
                resultLabel.Text = "Hibás adat";
            }
           
        }
    }
}
