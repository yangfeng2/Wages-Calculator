using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.IO;
using System.Web.Script.Serialization;

namespace Wages_Calculator
{
    public partial class WaiterStaff : Form
    {
        
        public List<Staff> staffList = new List<Staff>();
        public Staff currentStaff = new Staff();

        public WaiterStaff(ref List<Staff> _staffList)
        {
            InitializeComponent();
            staffList = _staffList;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                staffList = new JavaScriptSerializer().Deserialize<List<Staff>>(File.ReadAllText("staff_data.soko"));
                Staff staff = new Staff();
                staff = new Staff(nameText.Text, genderText.Text, nationalityText.Text, Convert.ToInt32(tfnText.Text), Convert.ToInt32(wagesText.Text), positionBox.Text);
                staffList.Add(staff);
                File.WriteAllText("staff_data.soko", new JavaScriptSerializer().Serialize(staffList));
                MessageBox.Show("Staff Added !!");
                staffList = new JavaScriptSerializer().Deserialize<List<Staff>>(File.ReadAllText("staff_data.soko"));
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter the staff details !!", "Error:");
            }
        }

        //public Staff getStaff()
        //{
        //    return staff;
        //}
    }
}
