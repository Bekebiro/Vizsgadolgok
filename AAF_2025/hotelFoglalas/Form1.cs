using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;

namespace hotelFoglalas
{
    //sorszám, szobaszám, elsonap, utolsonap, letszam, reggeli, nev
    //stat: éves teljes bevétel, éves %-os foglalatság szobánként + komplett szálloda, éves reggelik száma, vendégek száma, vendégéjszaka
  
    public partial class Form1 : Form
    {
        public Dictionary<string, int> honapok = new Dictionary<string, int>()
        {
            {"január", 31},
            {"február", 28},
            {"március", 31},
            {"április", 30},
            {"május", 31},
            {"június", 30},
            {"július", 31},
            {"augusztus", 31},
            {"szeptember", 30},
            {"október", 31},
            {"november", 30},
            {"december", 31},
        };


        public class Foglalas
        {
            public int sorSzam;
            public int szobaSzam;
            public int elsoNap;
            public int utolsoNap;
            public int letSzam;
            public string reggeli;
            public string nev;
            public int year;

            public Foglalas(string lines, int year)
            {
                string[] parts = lines.Split(' ');
               
                this.sorSzam = int.Parse(parts[0]);
                this.szobaSzam = int.Parse(parts[1]);
                this.elsoNap = int.Parse(parts[2]);
                this.utolsoNap = int.Parse(parts[3]);
                this.letSzam = int.Parse(parts[4]);
                this.reggeli = parts[5];
                this.nev = parts[6];

                this.reggeli = parts[5] == "1" ? "1" : "0";
                
                this.year = year;
            }

            public class Arak
            {
                public string szezon;
                public DateTime szezonkezd;
                public DateTime szezonzar;
                public int ar;

                public Arak(string lines2)
                {
                    string[] parts2 = lines2.Split(';');
                    this.szezon = parts2[0];
                    this.szezonkezd = DateTime.Parse(parts2[1]);
                    this.szezonzar = DateTime.Parse(parts2[2]);
                    this.ar = int.Parse(parts2[3]);
                }
            }
        }



        public Form1()
        {
            InitializeComponent();

            string[] evek = { };
            List<string> list = new List<string>(evek);
            for (int i = 2023; i < 2051; i++)
            {
                list.Add(i.ToString());
            }
            evek = list.ToArray();
            comboBoxEv.Items.AddRange(evek);

            



            foreach (var s in honapok) {comboBoxHonap.Items.Add(s.Key);}
           
            
            
        }
       
        Panel panel = new Panel();
        public void MatrixMaker()
        {
            List<Foglalas> foglalas = new List<Foglalas>();
            StreamReader reader = new StreamReader("foglalas.txt", Encoding.UTF8);
            int year3 = 0;
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (line == null) { return; }

                if (line.Length == 4 && int.TryParse(line, out int year2))
                {
                    year3 = year2;
                    continue;
                }
                foglalas.Add(new Foglalas(reader.ReadLine(), year3));
            }

            reader.Close();

            panel.Controls.Clear();
            string keys = comboBoxHonap.Text;
            panel.Size = new Size(1000, 1000);
            panel.Location = new Point(0, 0);

            int dictionary = 0;
            if(honapok.TryGetValue(keys, out int value)) { dictionary = value; }
            CheckBox[,] checkBoxes = new CheckBox[dictionary, 27];
            for (int i = 0; i < dictionary; i++)
            {
                Label label = new Label();
                label.Text = (i + 1).ToString();
                label.Location = new Point(50 + i * 20, 50);
                label.Size = new Size(20, 20);
                panel.Controls.Add(label);
                for (int j = 0; j < 27; j++)
                {
                    
                    Label label2 = new Label();
                    label2.Text = (j+1).ToString();
                    label2.Location = new Point(30, 70 + j *20);
                    label2.Size = new Size(20, 20);
                    panel.Controls.Add(label2);

                    checkBoxes[i, j] = new CheckBox();
                    checkBoxes[i, j].Location = new Point(50 + i * 20, 70 + j * 20);
                    checkBoxes[i, j].Size = new Size(20, 20);
                    checkBoxes[i, j].BackColor = Color.Green;

                    /*if (foglalas[j].szobaSzam == 19) 
                    {
                        checkBoxes[i, j].BackColor = Color.Red;
                    }*/
                    
                    panel.Controls.Add(checkBoxes[i, j]);

                   
                }

               
            }
          

            Controls.Add(panel);
        }

        private void btnKilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxEv_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatrixMaker();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           comboBoxEv.SelectedIndex = 0;
           comboBoxHonap.SelectedIndex = 0;
            
        }

        private void comboBoxHonap_SelectedIndexChanged(object sender, EventArgs e)
        {
            MatrixMaker();
        }
    }
}
