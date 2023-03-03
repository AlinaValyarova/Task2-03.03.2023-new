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
    public partial class Form2 : Form
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
        public Form2(string str)
        {
            InitializeComponent();

            string path = @"Guests.txt";
            List<Guest> listOfGuests = new List<Guest>();
            ReadFile(path, listOfGuests);
            foreach(Guest a in listOfGuests)
            {
                string find = a.FirstName + " " + a.LastName;
                if(find.Contains(str))
                {
                    FIO.Text = find;
                    Birthdate.Text = a.DateOfBirth.ToString("d");
                    numberOfDays.Text = (a.departure - a.arrival).TotalDays.ToString();
                    if(a.animals == 1)
                    {
                        checkBox.Checked = true;
                    }
                    else
                    {
                        checkBox.Checked = false;
                    }
                    switch (a.payment)
                    {
                        case 1:
                            payment.Text = "наличные";
                            continue;
                        case 2:
                            payment.Text = "карта";
                            continue;
                    }
                }
            }
        }

        public void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
