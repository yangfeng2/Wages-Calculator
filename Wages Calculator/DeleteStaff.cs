using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Wages_Calculator
{
    public partial class DeleteStaff : Form
    {
        public List<Staff> staffList;

        public DeleteStaff()
        {
            InitializeComponent();
            staffList = new JavaScriptSerializer().Deserialize<List<Staff>>(File.ReadAllText("staff_data.soko"));
            listBox1.DataSource = staffList;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Staff staff = (Staff)listBox1.SelectedItem;
            staffList.Remove(staff);
            File.WriteAllText("staff_data.soko", new JavaScriptSerializer().Serialize(staffList));
            MessageBox.Show("Staff Deleted !!");
            this.Close();
        }
    }
}
