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
    public partial class Form1 : Form
    {

        public List<Staff> staffList = new List<Staff>();
        public int currentRow = 0;
        public int currentCollumn = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void AddToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void showWorkingTime(int startHour, int startMin, int EndHour, int EndMin)
        {
            dataGridView[currentCollumn, currentRow].Value = "" + startHour + ":" + startMin + " - " + EndHour + ":" + EndMin + "";
        }


        private void addWaiterStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaiterStaff waiterStaff = new WaiterStaff(ref staffList);
            waiterStaff.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //staffBindingSource.Add(new Staff() { Name = "Yang" });
            //staffBindingSource.Add(new Staff() { Name = "Carmen" });
        }

        private void loadStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {

            staffList = new JavaScriptSerializer().Deserialize<List<Staff>>(File.ReadAllText("staff_data.soko"));



            staffBindingSource.Clear();
            foreach (Staff s in staffList)
                staffBindingSource.Add(s);
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView.Columns[e.ColumnIndex].Name == "Monday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Monday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Tuesday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Tuesday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Wednesday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Wednesday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Thursday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Thursday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Friday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Friday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Saturday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Saturday");
                addTime.castForm(this);
                addTime.Show();
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Sunday")
            {
                currentCollumn = e.ColumnIndex;
                currentRow = e.RowIndex;

                AddTime addTime = new AddTime();
                addTime.addList(staffList);
                addTime.currentIndex(e.RowIndex);
                addTime.currentDay("Sunday");
                addTime.castForm(this);
                addTime.Show();
            }
        }

        private void calculateWageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWages showWages = new ShowWages(ref staffList);
            showWages.Show();
            showWages.showWages();
        }

        private void saveStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStaff deleteStaff = new DeleteStaff();
            deleteStaff.Show();
            staffBindingSource.Clear();
        }
    }
}
