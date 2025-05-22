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

namespace barlang
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        public class Barlang
        {
            public int azon { get; private set; }
            public string nev { get; private set; }
            public string telepules { get; private set; }
            public string vedettseg { get; set; }
            private int H = 0;
            private int M = 0;
            public int hossz
            {
                get
                {
                    return H;
                }
                set
                {
                    if (H <= value || value == 0)
                    {
                        H = value;
                    }
                    else { MessageBox.Show("A hossz nem lehet kisebb a korábbi értéknél"); }

                }
            }
            public int melyseg
            {
                get
                {
                    return M;
                }
                set
                {
                    if (M <= value)
                    {
                        M = value;
                    }
                    else { MessageBox.Show("A mélység nem lehet kisebb a korábbi értéknél"); }
                }
            }

            public Barlang(string line)
            {
                try
                {
                    string[] strings = line.Split(';');
                    azon = int.Parse(strings[0]);
                    nev = strings[1];
                    hossz = int.Parse(strings[2]);
                    melyseg = int.Parse(strings[3]);
                    telepules = strings[4];
                    vedettseg = strings[5];
                }
                catch (Exception)
                {
                    hossz = 0;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        List<Barlang> barlangok = new List<Barlang>();
        private void fileBtn_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        reader.ReadLine();
                        fileContent = reader.ReadToEnd();


                        string[] lines = fileContent.Split('\n');
                        for(int i = 0; i < lines.Length; i++)
                        {
                            Barlang tmp = new Barlang(lines[i]);
                            if (tmp.hossz != 0) barlangok.Add(tmp);
                        }

                        
                    }
                }
            }
           //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

        }

        int hossz = 0;
        int melyseg = 0;
        private void searchBtn_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(azonTxtbox.Text);
            bool valtozo = false;
            for (int i = 0; i < barlangok.Count; i++)
            {
                if (id == barlangok[i].azon)
                {
                    barlangNev.Text = barlangok[i].nev;
                    hosszTxtbox.Text = barlangok[i].hossz.ToString();
                    hossz = barlangok[i].hossz;
                    melysegTxtbox.Text = barlangok[i].melyseg.ToString();
                    melyseg = barlangok[i].melyseg;
                    valtozo = true;
                    
                }
            }
            if (valtozo == false)
            {
                MessageBox.Show("Ezzel az azonosítóvla nem lézetik barlang!");

            }
            saveBtn.Enabled = true;

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            /*if(hossz < int.Parse(hosszTxtbox.Text))
            {
                hossz = int.Parse(hosszTxtbox.Text);
                MessageBox.Show("Sikeres értéknövelés");
            }else if(hossz > int.Parse(hosszTxtbox.Text))
            {
                MessageBox.Show("A hossz nem lehet kisebb a korábbi értéknél!");
               
            }*/

            try
            {
                int id = int.Parse(azonTxtbox.Text);

                for (int i = 0;i < barlangok.Count; i++)
                {
                    if(id == barlangok[i].azon)
                    {
                        barlangok[i].hossz = int.Parse(hosszTxtbox.Text);
                        barlangok[i].melyseg = int.Parse(melysegTxtbox.Text);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Csak szám értéket tudsz megadni!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
