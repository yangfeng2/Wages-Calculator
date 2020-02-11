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
    public partial class ShowWages : Form
    {
        List<Staff> staffList = new List<Staff>();
        List<string> data = new List<string>();

        public ShowWages(ref List<Staff> _staffList)
        {
            InitializeComponent();
            staffList = _staffList;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void showWages()
        {
            double allStaffTotalWages = 0;

            foreach(Staff s in staffList)
            {
                data.Add("\nName: " + s.Name + ", Wage Per Hour: $" + s.Wages + "\n\n");
                data.Add("Monday: $" + Math.Round(s.MonWages,2) + "\nTuesday: $"+ Math.Round(s.TueWages, 2) + "\nWednesday: $"+ Math.Round(s.WedWages, 2) + "\nThursday: $"+ Math.Round(s.ThuWages, 2) + "\nFriday: $"+ Math.Round(s.FriWages, 2) + "\nSaturday: $"+ Math.Round(s.SatWages, 2) + "\nSunday: $"+ Math.Round(s.SunWages, 2) + "");
                data.Add("\n\nTotal Wages: $" + s.totalWages()+"\n\n");
                allStaffTotalWages += s.totalWages();
            }

            data.Add("\n\n\nAll Total Wages: $"+ Convert.ToString(Math.Round(allStaffTotalWages, 2)) + "");

            foreach(string s1 in data)
            {
                richTextBox1.AppendText(s1);
                Console.WriteLine();
            }

            
        }
    }
}
