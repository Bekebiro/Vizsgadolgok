using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Torpedo
{
    public partial class Form1 : Form
    {
        public CheckBox[,] boxes = new CheckBox[10,10];

        public Form1()
        {
            InitializeComponent();
            btnSave.Enabled = false;
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    boxes[i, j] = new CheckBox();
                    boxes[i, j].Size = new Size(20, 20);
                    boxes[i, j].Location = new Point(60 + i * 20, 100 + j * 20);

                    this.Controls.Add(boxes[i, j]);
                }
            }
           



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i=0; i < 10; i++)
            {
                for(int j=0; j <10; j++)
                {
                    boxes[i, j].Checked = false;
                }
            }
            
        }

        private void txtBoxFileName_TextChanged(object sender, EventArgs e)
        {
            
            if (txtBoxFileName.Text == "")
            {
                btnSave.Enabled = false;
            }
            else
            {
                btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {

                }
            }
            StreamWriter writer = new StreamWriter(txtBoxFileName.Text + ".txt", true);
            for (int i=0;i<10;i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    string a = Convert.ToString(boxes[i,j].Checked ? 1 : 0);
                    writer.Write(a);
                }
            }
            writer.WriteLine();
            writer.Close();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    boxes[i, j].Checked = false;
                }
            }
            MessageBox.Show("Sikeres mentés!");
        }
    }
}
