namespace Wages_Calculator
{
    partial class WaiterStaff
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.genderText = new System.Windows.Forms.ComboBox();
            this.nationalityText = new System.Windows.Forms.TextBox();
            this.tfnText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.wagesText = new System.Windows.Forms.TextBox();
            this.positionBox = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gender: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "TFN Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nationality: ";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(298, 38);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(248, 38);
            this.nameText.TabIndex = 4;
            // 
            // genderText
            // 
            this.genderText.FormattingEnabled = true;
            this.genderText.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other"});
            this.genderText.Location = new System.Drawing.Point(298, 114);
            this.genderText.Name = "genderText";
            this.genderText.Size = new System.Drawing.Size(248, 39);
            this.genderText.TabIndex = 5;
            this.genderText.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // nationalityText
            // 
            this.nationalityText.Location = new System.Drawing.Point(298, 195);
            this.nationalityText.Name = "nationalityText";
            this.nationalityText.Size = new System.Drawing.Size(248, 38);
            this.nationalityText.TabIndex = 6;
            // 
            // tfnText
            // 
            this.tfnText.Location = new System.Drawing.Point(298, 277);
            this.tfnText.Name = "tfnText";
            this.tfnText.Size = new System.Drawing.Size(248, 38);
            this.tfnText.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 597);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 76);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(176, 76);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(230, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "Wages Per Hour:";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // wagesText
            // 
            this.wagesText.Location = new System.Drawing.Point(298, 384);
            this.wagesText.Name = "wagesText";
            this.wagesText.Size = new System.Drawing.Size(248, 38);
            this.wagesText.TabIndex = 11;
            // 
            // positionBox
            // 
            this.positionBox.FormattingEnabled = true;
            this.positionBox.Items.AddRange(new object[] {
            "Kitchen",
            "Hall"});
            this.positionBox.Location = new System.Drawing.Point(298, 479);
            this.positionBox.Name = "positionBox";
            this.positionBox.Size = new System.Drawing.Size(248, 74);
            this.positionBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 32);
            this.label6.TabIndex = 13;
            this.label6.Text = "Position:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // WaiterStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 858);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.positionBox);
            this.Controls.Add(this.wagesText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tfnText);
            this.Controls.Add(this.nationalityText);
            this.Controls.Add(this.genderText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "WaiterStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Waiter Staff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.ComboBox genderText;
        private System.Windows.Forms.TextBox nationalityText;
        private System.Windows.Forms.TextBox tfnText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox wagesText;
        private System.Windows.Forms.CheckedListBox positionBox;
        private System.Windows.Forms.Label label6;
    }
}