using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarkasDominikDolgozat_20241017
{
    public partial class Form1 : Form
    {
        private void LNKOLKKT()
        {
            int number1 = Convert.ToInt32(txtbox1.Text);
            int number2 = Convert.ToInt32(txtbox2.Text);

            bool chechked = radioBtn1.Checked;

            while (number1 != number2)
            {
                if(number1 > number2)
                {
                    number1 = number1 - number2;
                }
                else
                {
                    number2 = number2 - number1;
                }
            }

            int eredmeny = 0;
            if (chechked)
            {
                eredmeny = number1;
            }
            else
            {
                eredmeny = number2;
            }

            if (!chechked)
            {

            }

            resultBox.Text = "Eredmény: " + eredmeny;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void txtbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void kilepBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void szamolBtn_Click(object sender, EventArgs e)
        {
            LNKOLKKT();
        }
    }
}
