using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstForm
{
   
    public partial class Form1 : Form
    {
        public void muvelet()
        {
            double value1 = Convert.ToDouble(textBox1.Text);
            double value2 = Convert.ToDouble(textBox2.Text);


            if (plusz.Checked == true)
            {
                textBox3.Text = Convert.ToString(value1 + value2);
                textBox2.BackColor = Color.White;
            }

            if (minusz.Checked == true)
            {
                textBox3.Text = Convert.ToString(value1 - value2);
                textBox2.BackColor = Color.White;
            }

            if (szorzas.Checked == true)
            {
                textBox3.Text = Convert.ToString(value1 * value2);
                textBox2.BackColor = Color.White;
            }

            if (osztas.Checked == true)
            {
                textBox3.Text = Convert.ToString(value1 / value2);
                if (value2 == 0) 
                {
                    textBox3.Text = "";
                    textBox2.BackColor = Color.Red;
                }
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //btnExit.Enabled = false; //Nem használható
            btnExit.Visible = true; //Láthatóság
            btnExit.Text = "Exit"; //Átírja a textet

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Bezárja a programot
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           /* radioButton1.Text = "Nincs";
            radioButton2.Text = "Kiválasztva";
            if (radioButton1.Checked == true)
            {
                btnExit.Enabled = false;
            }
            else btnExit.Enabled = true;*/

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            /*radioButton1.Text = "Kiválasztva";
            radioButton2.Text = "Nincs";
            if (radioButton1.Checked == true)
            {
                btnExit.Enabled = false;
            }
            else btnExit.Enabled = true;*/
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void plusz_CheckedChanged(object sender, EventArgs e)
        {
            muvelet();
        }

        private void minusz_CheckedChanged(object sender, EventArgs e)
        {
            muvelet();
        }

        private void szorzas_CheckedChanged(object sender, EventArgs e)
        {
            muvelet();
        }

        private void osztas_CheckedChanged(object sender, EventArgs e)
        {
            muvelet();
        }
    }
}
