namespace Wages_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWaiterStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculateWageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Friday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewButtonColumn();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1726, 52);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addWaiterStaffToolStripMenuItem,
            this.saveStaffToolStripMenuItem,
            this.loadStaffToolStripMenuItem,
            this.calculateWageToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(136, 48);
            this.addToolStripMenuItem.Text = "Setting";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // addWaiterStaffToolStripMenuItem
            // 
            this.addWaiterStaffToolStripMenuItem.Name = "addWaiterStaffToolStripMenuItem";
            this.addWaiterStaffToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.addWaiterStaffToolStripMenuItem.Text = "Add Staff";
            this.addWaiterStaffToolStripMenuItem.Click += new System.EventHandler(this.addWaiterStaffToolStripMenuItem_Click);
            // 
            // saveStaffToolStripMenuItem
            // 
            this.saveStaffToolStripMenuItem.Name = "saveStaffToolStripMenuItem";
            this.saveStaffToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.saveStaffToolStripMenuItem.Text = "Delete Staff";
            this.saveStaffToolStripMenuItem.Click += new System.EventHandler(this.saveStaffToolStripMenuItem_Click);
            // 
            // loadStaffToolStripMenuItem
            // 
            this.loadStaffToolStripMenuItem.Name = "loadStaffToolStripMenuItem";
            this.loadStaffToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.loadStaffToolStripMenuItem.Text = "Load Staff";
            this.loadStaffToolStripMenuItem.Click += new System.EventHandler(this.loadStaffToolStripMenuItem_Click);
            // 
            // calculateWageToolStripMenuItem
            // 
            this.calculateWageToolStripMenuItem.Name = "calculateWageToolStripMenuItem";
            this.calculateWageToolStripMenuItem.Size = new System.Drawing.Size(448, 54);
            this.calculateWageToolStripMenuItem.Text = "Calculate Wage";
            this.calculateWageToolStripMenuItem.Click += new System.EventHandler(this.calculateWageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(104, 48);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday,
            this.Sunday});
            this.dataGridView.DataSource = this.staffBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 52);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 102;
            this.dataGridView.RowTemplate.Height = 40;
            this.dataGridView.Size = new System.Drawing.Size(1726, 863);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "Monday";
            this.Monday.MinimumWidth = 12;
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Monday.Text = "Add";
            this.Monday.Width = 150;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "Tuesday";
            this.Tuesday.MinimumWidth = 12;
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Tuesday.Text = "Add";
            this.Tuesday.Width = 150;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "Wednesday";
            this.Wednesday.MinimumWidth = 12;
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Wednesday.Text = "Add";
            this.Wednesday.Width = 150;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "Thursday";
            this.Thursday.MinimumWidth = 12;
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Thursday.Text = "Add";
            this.Thursday.Width = 150;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "Friday";
            this.Friday.MinimumWidth = 12;
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Friday.Text = "Add";
            this.Friday.Width = 150;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "Saturday";
            this.Saturday.MinimumWidth = 12;
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Saturday.Text = "Add";
            this.Saturday.Width = 150;
            // 
            // Sunday
            // 
            this.Sunday.HeaderText = "Sunday";
            this.Sunday.MinimumWidth = 12;
            this.Sunday.Name = "Sunday";
            this.Sunday.ReadOnly = true;
            this.Sunday.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Sunday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Sunday.Text = "Add";
            this.Sunday.Width = 150;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataSource = typeof(Wages_Calculator.Staff);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1726, 915);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWaiterStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.ToolStripMenuItem loadStaffToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Monday;
        private System.Windows.Forms.DataGridViewButtonColumn Tuesday;
        private System.Windows.Forms.DataGridViewButtonColumn Wednesday;
        private System.Windows.Forms.DataGridViewButtonColumn Thursday;
        private System.Windows.Forms.DataGridViewButtonColumn Friday;
        private System.Windows.Forms.DataGridViewButtonColumn Saturday;
        private System.Windows.Forms.DataGridViewButtonColumn Sunday;
        private System.Windows.Forms.ToolStripMenuItem calculateWageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveStaffToolStripMenuItem;
    }
}

