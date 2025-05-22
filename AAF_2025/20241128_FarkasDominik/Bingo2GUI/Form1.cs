using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo2GUI
{
    public partial class Form1 : Form
    {
        public TextBox[,] boxes = new TextBox[5, 5];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Bingo";
            Size = new Size(200, 300);
            ClientSize = new Size(200, 281);

            Button generateBtn = new Button();
            generateBtn.Text = "Kártya generálása";
            generateBtn.Size = new Size(150, 50);
            generateBtn.Location = new Point(25, 10);
            Controls.Add(generateBtn);
            generateBtn.Click += new System.EventHandler(generateBtn_Click);

            TextBox txtBoxfileName = new TextBox();
            txtBoxfileName.Text = "Mentés";
            txtBoxfileName.Size = new Size(150, 50);
            txtBoxfileName.Location = new Point(25, 211);
            txtBoxfileName.Text = "bingo.txt";
            Controls.Add(txtBoxfileName);

            Button saveBtn = new Button();
            saveBtn.Text = "Mentés";
            saveBtn.Size = new Size(150, 50);
            saveBtn.Location = new Point(25, 221);
            saveBtn.Click += new System.EventHandler(saveBtn_Click);
            Controls.Add(saveBtn);

            
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    boxes[i,j] = new TextBox();
                    boxes[i, j].Text = i.ToString() + j.ToString();
                    boxes[i, j].Size = new Size(25, 25);
                    boxes[i, j].Location = new Point(25 + j * 31, 60 + i * 31);
                    boxes[i, j].Visible = false;
                    boxes[i, j].AutoSize = false;
                    boxes[i, j].TextAlign = HorizontalAlignment.Center;

                    Controls.Add(boxes[i, j]);
                }
                
            }
        }
        private void generateBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    boxes[i, j].Visible = true;
                }
            }
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in boxes) item.Visible = true;
        }
    }
}
