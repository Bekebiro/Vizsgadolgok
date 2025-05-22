using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Xsl;
using static hotel_250130.Form1;

namespace hotel_250130
{
    //sorszam szobaszam elsonap utolsonap letszam reggeli azonostio

    //Statisztika: teljes bevetel evente, szazalekos foglaltsag szobankent, komplett szalloda foglaltsag 

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        internal class Price
        {
            public string type;
            public DateTime timestart;
            public DateTime timeend;
            public int price;

            public Price(string oneLine)
            {
                string[] parts = oneLine.Split(';');
                this.type = parts[0];
                this.timestart = DateTime.Parse(parts[1]);
                this.timeend = DateTime.Parse(parts[2]);
                this.price = int.Parse(parts[3]);
            }
        }

        internal class Appointments
        {
            public int year;
            public int id;
            public int room;
            public int firstdayyear;
            public int lastdayyear;
            public int guests;
            public string breakfast;
            public string name;


            public Appointments(int year, string oneLine)
            {
                this.year = year;

                string[] parts = oneLine.Split(' ');
                this.id = int.Parse(parts[0]);
                this.room = int.Parse(parts[1]);
                this.firstdayyear = int.Parse(parts[2]);
                this.lastdayyear = int.Parse(parts[3]);
                this.guests = int.Parse(parts[4]);
                this.breakfast = parts[5];
                this.name = parts[6];

                this.breakfast = parts[5] == "1" ? "kell" : "nemkell";
            }
        }
        internal class writeAppointments
        {
            public int id;
            public int room;
            public int firstdayyear;
            public int lastdayyear;
            public int guests;
            public string breakfast;
            public string name;

            public writeAppointments(int id, int room, int firstdayyear, int lastdayyear, int guests, string breakfast, string name)
            {
                this.id = id;
                this.room = room;
                this.firstdayyear = firstdayyear;
                this.lastdayyear = lastdayyear;
                this.guests = guests;
                this.breakfast = breakfast;
                this.name = name;
            }
        }
        
        public int getDayF(int month)
        {
            int valueDay = 0;
            for (int i = 1; i <= month; i++)
            {
                valueDay += months[i];
            }
            return valueDay;
        }

        public DateTime convertYearDay(int getDay, int id)
        {
            try
            {
                int year = appointments[id].year;
                int month = 0;
                int day = 0;

                for (int i = 1; i < 13; i++)
                {
                    if (getDay <= getDayF(i))
                    {
                        month = i;
                        day = getDay - getDayF(i - 1);
                        break;
                    }
                }

                if (day < 1 || day > DateTime.DaysInMonth(year, month))
                {
                    throw new ArgumentOutOfRangeException("Invalid day value for the given month and year.");
                }

                return new DateTime(year, month, day);
            }
            catch (Exception e)
            {
                return new DateTime(2023, 1, 1);

            }
        }

        private string reservationName = "";
        private CheckBox[,] reservationGrid;
        private bool isUpdatingComboBoxes = false;
        private DateTime searchedTime = new DateTime();
        private List<Price> prices = new List<Price>();
        private List<Appointments> appointments = new List<Appointments>();
        public static Dictionary<int, int> months = new Dictionary<int, int>()
         {
            { 1, 31},
            { 2, 28},
            { 3, 31 },
            { 4, 30 },
            { 5, 31 }, 
            { 6, 30 },
            { 7, 31 },
            { 8, 31 },
            { 9, 30 },
            { 10, 31 },
            { 11, 30 },
            { 12, 31 }
          };

      


        public void handleAppointmentsGrid(Panel panel, int month2, int year2)
        {
            panel.Controls.Clear();

            int keytoDictionary = months[month2]; //comboBox2.Text
            CheckBox[,] checkBoxes = new CheckBox[keytoDictionary, 27];
            for (int i = 0; i < keytoDictionary; i++)
            {
                Label label = new Label();
                label.Location = new Point(25 + i * 20, 0);
                label.Size = new Size(20, 20);
                label.Text = (i + 1).ToString();
                panel.Controls.Add(label);
                for (int j = 0; j < 27; j++)
                {
                    if (i == 0)
                    {
                        Label label1 = new Label();
                        label1.Location = new Point(0, 26 + j * 20);
                        label1.Size = new Size(20, 18);
                        label1.Text = (j + 1).ToString();
                        panel.Controls.Add(label1);
                    }

                    checkBoxes[i, j] = new CheckBox();
                    checkBoxes[i, j].Location = new Point(25 + i * 20, 25 + j * 20);
                    checkBoxes[i, j].Size = new Size(20, 20);
                    checkBoxes[i, j].Text = (j + 1).ToString();
                    panel.Controls.Add(checkBoxes[i, j]);


                    checkBoxes[i, j].BackColor = Color.Green;

                }
            }
            reservationGrid = checkBoxes;

            foreach (var appointment in appointments)
            {
                int year = appointment.year;
                int month = month2; //comboBox2.Text


                if (year == year2) //comboBox1.Text
                {
                    DateTime startDate = convertYearDay(appointment.firstdayyear, appointment.id - 1);
                    label6.Text = startDate.ToString();
                    DateTime endDate = convertYearDay(appointment.lastdayyear, appointment.id - 1);

                    if (startDate.Month == month || endDate.Month == month)
                    {
                        int startDay = startDate.Month == month ? startDate.Day : 1;
                        int endDay = endDate.Month == month ? endDate.Day : months[month];

                        for (int day = startDay; day <= endDay; day++)
                        {
                            
                            int roomIndex = appointment.room - 1;
                            if (roomIndex >= 0 && roomIndex < 27)
                            {
                                checkBoxes[day -1, roomIndex].Checked = true;
                                checkBoxes[day -1, roomIndex].Enabled = false;
                                checkBoxes[day -1, roomIndex].BackColor = Color.Red;
                            }
                        }
                    }
                }
               
            }
        }
        public bool handleReservations(CheckBox[,] checkBoxes, int month2)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill out all the necessary fields.");
                return false;

            }

            DateTime startDate2 = dateTimePicker1.Value;
            DateTime endDate2 = dateTimePicker2.Value;

            int startDay2 = startDate2.Day;
            int endDay2 = endDate2.Day;
            int startMonth = startDate2.Month;

            for (int day = startDay2; day <= endDay2; day++)
            {
                int roomNumber = int.Parse(textBox1.Text);

                if (checkBoxes[day - 1, roomNumber - 1].Checked == true)
                {
                    MessageBox.Show("The room is already booked for the selected date.");
                    return false;
                }

                if (startMonth == month2)
                {
                    checkBoxes[day - 1, roomNumber - 1].BackColor = Color.Yellow;
                }
            }
            string breakfast22 = checkBox1.Checked ? "1" : "0";
            int room = int.Parse(textBox1.Text);
            int startDay22 = dateTimePicker1.Value.Day + getDayF(dateTimePicker1.Value.Month - 1);
            int endDay22 = dateTimePicker2.Value.Day + getDayF(dateTimePicker2.Value.Month - 1); 
            int guests = int.Parse(textBox2.Text);

            using (StreamWriter write_appointments = new StreamWriter("foglalas.txt", true))
            {
                writeAppointments newAppointment = new writeAppointments(appointments.Count + 1, room, startDay22, endDay22, guests, breakfast22, reservationName);
                write_appointments.WriteLine($"{newAppointment.id} {newAppointment.room} {newAppointment.firstdayyear} {newAppointment.lastdayyear} {newAppointment.guests} {newAppointment.breakfast} {newAppointment.name}");
                //handle years maybe, no space between names, error handling for name textbox etc.
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            #region Date&Time
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            button2.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            checkBox1.Visible = false;
            textBox2.Visible = false;


            #endregion

            #region ComboBox
            comboBox1.Items.Add("2023");
            comboBox1.Items.Add("2024");

            for (int i = 1; i < 13; i++)
            {
                comboBox2.Items.Add(i);
            }
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;

            #endregion
            #region dateTimePicker
            dateTimePicker1.Value = new DateTime(2023, 1, 1);
            dateTimePicker2.Value = new DateTime(2023, 1, 2);
            /*dateTimePicker1.MinDate = new DateTime(2023, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(2024, 12, 31);
            dateTimePicker2.MinDate = new DateTime(2023, 1, 1);
            dateTimePicker2.MaxDate = new DateTime(2024, 12, 31);*/

            
            #endregion
            #region ReadPrices
            StreamReader read_prices = new StreamReader("arak.txt");
            while (!read_prices.EndOfStream)
            {
                prices.Add(new Price(read_prices.ReadLine()));
            }
            read_prices.Close();
            #endregion

            #region ReadAppointments
            StreamReader read_appointments = new StreamReader("foglalas.txt");
            int currentYear = 0;
            while (!read_appointments.EndOfStream)
            {
                string line = read_appointments.ReadLine();
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }
                string trimmed = line.Trim();
                if (trimmed.Length == 4 && int.TryParse(trimmed, out int possibleYear))
                {
                    currentYear = possibleYear;
                    continue;
                }
                appointments.Add(new Appointments(currentYear, line));
            }
            handleAppointmentsGrid(panel1, int.Parse(comboBox2.Text), int.Parse(comboBox1.Text));
            read_appointments.Close();
            #endregion
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBoxes) return;

            searchedTime = new DateTime(int.Parse(comboBox1.Text), 1, 1);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isUpdatingComboBoxes) return;

            searchedTime = new DateTime(int.Parse(comboBox1.Text), int.Parse(comboBox2.Text), 1);
            handleAppointmentsGrid(panel1, int.Parse(comboBox2.Text), int.Parse(comboBox1.Text));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
            dateTimePicker2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label10.Visible = true;
            label9.Visible = true;
            checkBox1.Visible = true;
            textBox2.Visible = true;
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return;
            }
            double totalPrice = 0;
            double mainPriceBreakfast = 0;
            int totalDays = (dateTimePicker2.Value - dateTimePicker1.Value).Days;
            label6.Text = " start: " + dateTimePicker1.Value.ToString() + "\n end: " +  dateTimePicker2.Value.ToString() + "\n room number: " +  textBox1.Text + "\n total number of days: " + totalDays;

            foreach (var prices in prices)
            {
                if (prices.type.ToLower() == "fő" && prices.timestart.Year == dateTimePicker1.Value.Year) 
                { 
                    mainPriceBreakfast = prices.price * 0.1;
                }
                if (prices.timestart <= dateTimePicker1.Value && prices.timeend >= dateTimePicker2.Value)
                {
                    totalPrice += prices.price * totalDays * int.Parse(textBox2.Text);
                }
            }
                if (int.Parse(textBox2.Text) > 2)
                {
                    totalPrice += 1100;
                }
                if (checkBox1.Checked)
                {
                    totalPrice += mainPriceBreakfast * int.Parse(textBox2.Text);
                }

            label5.Text = totalPrice.ToString() + " Ft";
            handleReservations(reservationGrid, int.Parse(comboBox2.Text));
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 27)
                {
                    MessageBox.Show("Invalid room number. Please enter a number between 1 and 27.");
                    textBox1.Clear();
                }
            }
            catch (Exception)
            {
                textBox1.Clear();            
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try {
                if (int.Parse(textBox2.Text) > 3 || int.Parse(textBox2.Text) < 1)
                {
                    textBox2.Clear();
                    MessageBox.Show("Invalid room number. Please enter a number between 1 and 27.");
                }; 
            }
            catch (Exception)
            {
                textBox2.Clear();
            }
        }

        private int previousMonth = -1;
        private int previusYear = -1;
        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);

            int newMonth = dateTimePicker1.Value.Month;
            int newYear = dateTimePicker1.Value.Year;

            if (newMonth != previousMonth || newYear != previusYear)
            {
                
                isUpdatingComboBoxes = true;

                comboBox1.Text = newYear.ToString();
                comboBox2.Text = newMonth.ToString();
                
                handleAppointmentsGrid(panel1, newMonth, newYear);

                previousMonth = newMonth;
                previusYear = newYear;

                isUpdatingComboBoxes = false;
            }
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Invalid date. The end date must be greater than the start date.");
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
            }
            if (dateTimePicker2.Value.Month > dateTimePicker1.Value.Month || dateTimePicker2.Value.Year > dateTimePicker1.Value.Year)
            {
                MessageBox.Show("Invalid date. The end date must be in the same month as the start date.");
                dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
            }
        }

        
        void button3_Click(object sender, EventArgs e)
        {
            Dictionary<int, double> yearlyIncome = new Dictionary<int, double>();

            foreach (var appointment in appointments)
            {
                int year = appointment.year;

                if (!yearlyIncome.ContainsKey(year))
                {
                    yearlyIncome[year] = 0;
                }

                double breakfastPayment = 0;

                DateTime startDate = convertYearDay(appointment.firstdayyear, appointment.id - 1);
                DateTime endDate = convertYearDay(appointment.lastdayyear, appointment.id - 1);

                int totalDays = (endDate - startDate).Days;

                foreach (var prices in prices)
                {
                    if (prices.type.ToLower() == "fő" && prices.timestart.Year == year)
                    {
                        breakfastPayment = prices.price * 0.1;
                    }
                    if (prices.timestart <= startDate && prices.timeend >= endDate)
                    {
                        yearlyIncome[year] += prices.price * totalDays * appointment.guests;
                    }
                }
                if (appointment.guests > 2)
                {
                    yearlyIncome[year] += 1100;
                }
                if (appointment.breakfast == "kell")
                {
                    yearlyIncome[year] += breakfastPayment * appointment.guests;
                }
            }

            using (StreamWriter statistics = new StreamWriter("statistics.txt"))
            {
                foreach (var entry in yearlyIncome)
                {
                    statistics.WriteLine($"Year: {entry.Key}, Income: {entry.Value} HUF");
                    MessageBox.Show($"Year: {entry.Key}, Income: {entry.Value} HUF \n The Ask was succesfull!");
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            reservationName = textBox3.Text;
        }
    }
    }