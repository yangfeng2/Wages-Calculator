using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wages_Calculator
{
    public partial class AddTime : Form
    {
        List<Staff> staffList = new List<Staff>();
        int CurrentIndex = 0;
        string CurrentDay;
        Form1 form1;

        public AddTime()
        {
            InitializeComponent();
        }

        public void addList(List<Staff> waiterStaffs)
        {
            staffList = waiterStaffs;
        }


        public void currentIndex(int i)
        {
            CurrentIndex = i;
        }

        public void castForm (Form1 _form1)
        {
            form1 = _form1;
        }

        public void currentDay(string day)
        {
            CurrentDay = day;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int StartHour = Convert.ToInt32(textBox1.Text);
            int StartMin = Convert.ToInt32(textBox3.Text);
            int EndHour = Convert.ToInt32(textBox2.Text);
            int EndMin = Convert.ToInt32(textBox4.Text);

            DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, StartHour, StartMin,0);
            DateTime end = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, EndHour, EndMin, 0);
            Console.WriteLine(staffList[CurrentIndex].showDetails());
            if (CurrentDay == "Monday")
            {
                staffList[CurrentIndex].MonStart = start;
                staffList[CurrentIndex].MonEnd = end;
                staffList[CurrentIndex].CalculateWages("Monday");

            }
            if (CurrentDay == "Tuesday")
            {
                staffList[CurrentIndex].TueStart = start;
                staffList[CurrentIndex].TueEnd = end;
                staffList[CurrentIndex].CalculateWages("Tuesday");

            }
            if (CurrentDay == "Wednesday")
            {
                staffList[CurrentIndex].WedStart = start;
                staffList[CurrentIndex].WedEnd = end;
                staffList[CurrentIndex].CalculateWages("Wednesday");

            }
            if (CurrentDay == "Thursday")
            {
                staffList[CurrentIndex].ThuStart = start;
                staffList[CurrentIndex].ThuEnd = end;
                staffList[CurrentIndex].CalculateWages("Thursday");

            }
            if (CurrentDay == "Friday")
            {
                staffList[CurrentIndex].FriStart = start;
                staffList[CurrentIndex].FriEnd = end;
                staffList[CurrentIndex].CalculateWages("Friday");

            }
            if (CurrentDay == "Saturday")
            {
                staffList[CurrentIndex].SaturStart = start;
                staffList[CurrentIndex].SatEnd = end;
                staffList[CurrentIndex].CalculateWages("Saturday");

            }
            if (CurrentDay == "Sunday")
            {
                staffList[CurrentIndex].SunStart = start;
                staffList[CurrentIndex].SunEnd = end;
                staffList[CurrentIndex].CalculateWages("Sunday");

            }

            this.Close();
            form1.showWorkingTime(StartHour, StartMin, EndHour, EndMin);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
