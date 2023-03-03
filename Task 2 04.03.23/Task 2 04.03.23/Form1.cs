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

namespace Task_2_04._03._23
{
    public partial class Form1 : Form
    {
        public class Guest
        {
            public int num;
            public string FirstName;
            public string LastName;
            public DateTime arrival;
            public DateTime departure;
            public DateTime DateOfBirth;
            public byte payment;
            public int animals;
        }

        public static void ReadFile(string path, List<Guest> guests)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    Guest guest = new Guest();
                    string text = reader.ReadLine();
                    string[] list = new string[7];
                    list = text.Split(' ');
                    guest.num = int.Parse(list[0]);
                    guest.FirstName = list[1];
                    guest.LastName = list[2];
                    guest.arrival = DateTime.Parse(list[3]);
                    guest.departure = DateTime.Parse(list[4]);
                    guest.DateOfBirth = DateTime.Parse(list[5]);
                    guest.payment = byte.Parse(list[6]);
                    guest.animals = int.Parse(list[7]);

                    guests.Add(guest);
                }
            }
        }
        public Form1()
        {
            InitializeComponent();

            Yandex.TextChanged += Yandex_TextChanged;
            listBox.MouseDoubleClick += listBox_MouseDoubleClick;
            All.CheckedChanged += radioButton1_CheckedChanged;

        }

        private void DateTime_Label(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            for (int i = 0; i < listOfGuests.Count; i++)
            {
                Guest guest = new Guest();
                guest = listOfGuests[i];
                listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            for (int i = 0; i < listOfGuests.Count; i++)
            {
                Guest guest = new Guest();
                guest = listOfGuests[i];
                if (DateTime.Now < guest.arrival)
                {
                    listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
                }
                else
                {
                    continue;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            for (int i = 0; i < listOfGuests.Count; i++)
            {
                Guest guest = new Guest();
                guest = listOfGuests[i];
                if (DateTime.Now > guest.departure)
                {
                    listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
                }
                else
                {
                    continue;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            for (int i = 0; i < listOfGuests.Count; i++)
            {
                Guest guest = new Guest();
                guest = listOfGuests[i];
                if (DateTime.Now > guest.arrival && DateTime.Now < guest.departure)
                {
                    listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
                }
                else
                {
                    continue;
                }
            }
        }

        private void Form1_load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Enabled = true;
            timer1.Start();
            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            for (int i = 0; i < listOfGuests.Count; i++)
            {
                Guest guest = new Guest();
                guest = listOfGuests[i];
                listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateAndTime.Text = DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void DateAndTime_Click(object sender, EventArgs e)
        {

        }


        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem == null)
            {
                return;
            }
            string selectedGuest = listBox.SelectedItem.ToString();
            string path = @"Guests.txt";
                List<Guest> listOfGuests = new List<Guest>();
                ReadFile(path, listOfGuests);
                foreach (Guest a in listOfGuests)
                {
                    string str = a.FirstName + " " + a.LastName;
                    if (selectedGuest.Contains(str))
                    {
                        RoomNum.Text = "Номер: " + a.num.ToString();
                        if (DateTime.Now < a.arrival)
                        {
                            sta.Text = "Бронь";
                        }
                        else if (DateTime.Now > a.arrival && DateTime.Now < a.departure)
                        {
                            sta.Text = "Постоялец";
                        }
                        else if (DateTime.Now > a.departure)
                        {
                            sta.Text = "Архивный";
                        }
                        FIO.Text = a.FirstName + " " + a.LastName;
                        Arrival.Text = a.arrival.ToString("d");
                        Departure.Text = a.departure.ToString("d");
                        try
                        {
                            pictureBox1.Image = Image.FromFile("C:" + a.FirstName + " " + a.LastName + ".jpg");
                        }
                        catch
                        {
                            continue;
                        }
                    }


                }
            }


        private void Yandex_TextChanged(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(Yandex.Text))
            {
                string path = @"Guests.txt";
                List<Guest> listOfGuests = new List<Guest>();
                ReadFile(path, listOfGuests);
                for (int i = 0; i < listOfGuests.Count; i++)
                {
                    Guest guest = new Guest();
                    guest = listOfGuests[i];
                }
            }
            else
            {
                string path = @"Guests.txt";
                List<Guest> listOfGuests = new List<Guest>();
                ReadFile(path, listOfGuests);
                for (int i = 0; i < listOfGuests.Count; i++)
                {
                    Guest guest = new Guest();
                    guest = listOfGuests[i];
                    if(guest.FirstName.StartsWith(Yandex.Text) || guest.LastName.StartsWith(Yandex.Text) || guest.num.Equals(Yandex.Text))
                    {
                        listBox.Items.Add(guest.num + " " + guest.FirstName + " " + guest.LastName);
                    }
                }
            }
        }

        void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GoForm2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(FIO.Text);
            newForm.Show();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RoomNum_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
