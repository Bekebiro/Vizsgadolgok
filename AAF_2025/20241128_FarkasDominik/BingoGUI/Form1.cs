using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGUI
{
    public partial class Form1 : Form
    {
        List<string> list = new List<string>();
        public Form1()
        {
            InitializeComponent();
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;

            textBox13.Enabled = false;

            
        }
        
        private void generateBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible == false)
            {
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox11.Visible = true;
                textBox12.Visible = true;
                textBox13.Visible = true;
                textBox14.Visible = true;
                textBox15.Visible = true;
                textBox16.Visible = true;
                textBox17.Visible = true;
                textBox18.Visible = true;
                textBox19.Visible = true;
                textBox20.Visible = true;
                textBox21.Visible = true;
                textBox22.Visible = true;
                textBox23.Visible = true;
                textBox24.Visible = true;
                textBox25.Visible = true;
            }
            else 
            { 
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                textBox5.Text = string.Empty;
                textBox6.Text = string.Empty;
                textBox7.Text = string.Empty;
                textBox8.Text = string.Empty;
                textBox9.Text = string.Empty;
                textBox10.Text = string.Empty;
                textBox11.Text = string.Empty;
                textBox12.Text = string.Empty;
                textBox14.Text = string.Empty;
                textBox15.Text = string.Empty;
                textBox16.Text = string.Empty;
                textBox17.Text = string.Empty;
                textBox18.Text = string.Empty;
                textBox19.Text = string.Empty;
                textBox20.Text = string.Empty;
                textBox21.Text = string.Empty;
                textBox22.Text = string.Empty;
                textBox23.Text = string.Empty;
                textBox24.Text = string.Empty;
                textBox25.Text = string.Empty;
            }

            
            Random rand = new Random();
            List<int> ints = new List<int>();
            for (int i = 0; i < 16; i++)
            {
            ints.Add(i); 
            }

            textBox1.Text = rand.Next(ints.Count).ToString();
            textBox10.Text = rand.Next(ints.Count).ToString();
            textBox15.Text = rand.Next(ints.Count).ToString();
            textBox20.Text = rand.Next(ints.Count).ToString();
            textBox25.Text = rand.Next(ints.Count).ToString();

            textBox2.Text = rand.Next(16, 31).ToString();
            textBox9.Text = rand.Next(16, 31).ToString();
            textBox14.Text = rand.Next(16, 31).ToString();
            textBox19.Text = rand.Next(16, 31).ToString();
            textBox24.Text = rand.Next(16, 31).ToString();

            textBox3.Text = rand.Next(31, 46).ToString();
            textBox8.Text = rand.Next(31, 46).ToString();
            textBox18.Text = rand.Next(31, 46).ToString();
            textBox23.Text = rand.Next(31, 46).ToString();

            textBox4.Text = rand.Next(46, 61).ToString();
            textBox7.Text = rand.Next(46, 61).ToString();
            textBox12.Text = rand.Next(46, 61).ToString();
            textBox17.Text = rand.Next(46, 61).ToString();
            textBox22.Text = rand.Next(46, 61).ToString();

            textBox5.Text = rand.Next(61, 76).ToString();
            textBox6.Text = rand.Next(61, 76).ToString();
            textBox11.Text = rand.Next(61, 76).ToString();
            textBox16.Text = rand.Next(61, 76).ToString();
            textBox21.Text = rand.Next(61, 76).ToString();


           
            list.Add(textBox1.Text);
            list.Add(textBox2.Text);
            list.Add(textBox3.Text);
            list.Add(textBox4.Text);
            list.Add(textBox5.Text);
            list.Add(textBox6.Text);
            list.Add(textBox7.Text);
            list.Add(textBox8.Text);
            list.Add(textBox9.Text);
            list.Add(textBox10.Text);
            list.Add(textBox11.Text);
            list.Add(textBox12.Text);
            list.Add(textBox13.Text);
            list.Add(textBox14.Text);
            list.Add(textBox15.Text);
            list.Add(textBox16.Text);
            list.Add(textBox17.Text);
            list.Add(textBox18.Text);
            list.Add(textBox19.Text);
            list.Add(textBox20.Text);
            list.Add(textBox21.Text);
            list.Add(textBox22.Text);
            list.Add(textBox23.Text);
            list.Add(textBox24.Text);
            list.Add(textBox25.Text);


        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
           StreamWriter writer = new StreamWriter(fileNameTxtBox.Text + ".txt");
           for (int i = 0; i < list.Count; i++)
            {
                writer.WriteLine(list[i].ToString() + ";");
            }
           writer.Close();
        }
    }
}
