namespace TDD2
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel4 = new Panel();
            label_showTable = new Label();
            panel3 = new Panel();
            lable_addRandom = new Label();
            panel2 = new Panel();
            labe_addStudent = new Label();
            label1 = new Label();
            uC_addStudent1 = new UC_addStudent();
            uC_showTable1 = new UC_showTable();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 629);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label_showTable);
            panel4.Location = new Point(26, 419);
            panel4.Name = "panel4";
            panel4.Size = new Size(224, 60);
            panel4.TabIndex = 6;
            // 
            // label_showTable
            // 
            label_showTable.AutoSize = true;
            label_showTable.FlatStyle = FlatStyle.Flat;
            label_showTable.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_showTable.Location = new Point(55, 17);
            label_showTable.Name = "label_showTable";
            label_showTable.Size = new Size(119, 28);
            label_showTable.TabIndex = 0;
            label_showTable.Text = "Show Table";
            label_showTable.Click += label_showTable_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lable_addRandom);
            panel3.Location = new Point(26, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(224, 60);
            panel3.TabIndex = 5;
            // 
            // lable_addRandom
            // 
            lable_addRandom.AutoSize = true;
            lable_addRandom.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lable_addRandom.Location = new Point(55, 17);
            lable_addRandom.Name = "lable_addRandom";
            lable_addRandom.Size = new Size(130, 28);
            lable_addRandom.TabIndex = 0;
            lable_addRandom.Text = "Add Random";
            lable_addRandom.Click += lable_addRandom_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(labe_addStudent);
            panel2.Location = new Point(26, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(224, 60);
            panel2.TabIndex = 4;
            // 
            // labe_addStudent
            // 
            labe_addStudent.AutoSize = true;
            labe_addStudent.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            labe_addStudent.Location = new Point(46, 17);
            labe_addStudent.Name = "labe_addStudent";
            labe_addStudent.Size = new Size(126, 28);
            labe_addStudent.TabIndex = 0;
            labe_addStudent.Text = "Add Student";
            labe_addStudent.Click += labe_addStudent_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Script MT Bold", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(70, 34);
            label1.Name = "label1";
            label1.Size = new Size(107, 44);
            label1.TabIndex = 3;
            label1.Text = "Menu";
            // 
            // uC_addStudent1
            // 
            uC_addStudent1.BackColor = Color.White;
            uC_addStudent1.Location = new Point(280, 25);
            uC_addStudent1.Name = "uC_addStudent1";
            uC_addStudent1.Size = new Size(909, 580);
            uC_addStudent1.TabIndex = 1;
            // 
            // uC_showTable1
            // 
            uC_showTable1.Location = new Point(280, 25);
            uC_showTable1.Name = "uC_showTable1";
            uC_showTable1.Size = new Size(883, 559);
            uC_showTable1.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1215, 629);
            Controls.Add(uC_showTable1);
            Controls.Add(uC_addStudent1);
            Controls.Add(panel1);
            Name = "Home";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel4;
        private Label label_showTable;
        private Panel panel3;
        private Label lable_addRandom;
        private Panel panel2;
        private Label labe_addStudent;
        private Label label1;
        private UC_addStudent uC_addStudent1;
        private UC_showTable uC_showTable1;
    }
}