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

namespace uzenetKodolo
{
    public partial class Form1 : Form
    {
       
            string uzenetKezd = "xxx";
            string uzenetVeg = ".-+.";
            string elvalaszto = ".x.";
            string vege = ".-.-.+.+.";

        

        public class Uzenet
        {
            public long ido;
            public string uzenet;
            public byte ip1;
            public byte ip2;

        }


        public void Kodolas ()
        {
            
        }
        public Form1()
        {
            InitializeComponent();

            kuldoNevTxtBox.Text = "János";
            kuldoIpTxtBox.Text = "192.168.10.10";
            vevoNevTxtBox.Text = "Lajos";
            vevoIpTxtBox.Text = "192.168.10.5";

            uzenetTxtBox.Text = "Gyere át";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kuldesBtn_Click(object sender, EventArgs e)
        {
            string kuldoNev = kuldoNevTxtBox.Text;
            string kuldoIp = kuldoIpTxtBox.Text;
            string vevoNev = vevoNevTxtBox.Text;
            string vevoIp = vevoIpTxtBox.Text;

            string uzenet = uzenetTxtBox.Text;

            string[] split1 = kuldoIp.Split('.');
            string elsoResz = split1[0];
            string masodikResz = split1[1];
            string harmadikResz = split1[2];
            string negyedikResz = split1[3];

            int first = int.Parse(elsoResz);
            int second = int.Parse(masodikResz);
            int third = int.Parse(harmadikResz);
            int fourth = int.Parse(negyedikResz);

            string[] split2 = vevoIp.Split('.');
            string elsoResz2 = split1[0];
            string masodikResz2 = split2[1];
            string harmadikResz2 = split2[2];
            string negyedikResz2 = split2[3];

            int first2 = int.Parse(elsoResz2);
            int second2 = int.Parse(masodikResz2);
            int third2= int.Parse(harmadikResz2);
            int fourth2 = int.Parse(negyedikResz2);


            string splitteltKuldoIp = Convert.ToString(first, 2) + Convert.ToString(second, 2) + Convert.ToString(third, 2) + Convert.ToString(fourth, 2);
            string splitteltVevoIp = Convert.ToString(first2, 2) + Convert.ToString(second2, 2) + Convert.ToString(third2, 2) + Convert.ToString(fourth2, 2);

            DateTime dateTime = dateTimePicker1.Value;

            long date = dateTime.Ticks;

            //label6.Text = $"Üzenet küldője: {kuldoNev}\n Ip címe: {kuldoIp}\n Vevő neve: {vevoNev}\n Ip címe: {vevoIp}\n Küldés dátuma: {dateTime}\n A küldött üzenet: {uzenet}\n";

            
            StreamWriter writer = new StreamWriter("uzenet.txt", true);
            writer.AutoFlush = true;
            //string file = "H:\\2024-2025\\Asztali Alkalmazás Fejlesztés\\20250306_FarkasDominik\\uzenetKodolo\\bin\\Debug";
            //string file = "C:\\Users\\FarkasDominik\\Downloads\\20250306_FarkasDominik\\uzenetKodolo\\bin\\Debug\\uzenet.txt";
            //string tartalom = File.ReadAllText(file);
            writer.WriteLine($"{uzenetKezd}{date}{elvalaszto}{uzenet}{elvalaszto}{splitteltKuldoIp}{elvalaszto}{splitteltVevoIp}{uzenetVeg}");
            /*if(!tartalom.Contains($"{vege}"))
            {
                writer.Write($"{vege}");
            }*/
            writer.Close();

        }
    }
}
