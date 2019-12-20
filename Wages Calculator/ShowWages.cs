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
            foreach(Staff s in staffList)
            {
                data.Add("\nName: "+s.Name+", Wage Per Hour: $"+s.Wages+"\n\n");
                data.Add("Monday: $" + Math.Round(s.MonWages,2) + "\nTuesday: $"+s.TueWages+"\nWednesday: $"+s.WedWages+"\nThursday: $"+s.ThuWages+"\nFriday: $"+s.FriWages+"\nSaturday: $"+s.SatWages+"\nSunday: $"+s.SunWages+"");
            }

            foreach(string s1 in data)
            {
                richTextBox1.AppendText(s1);
            }
        }
    }
}
