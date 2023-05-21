namespace TDD2
{
    partial class UC_showTable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DT_table = new DataGridView();
            TB_name = new DataGridViewTextBoxColumn();
            TB_id = new DataGridViewTextBoxColumn();
            TB_email = new DataGridViewTextBoxColumn();
            TB_phone = new DataGridViewTextBoxColumn();
            TB_avg = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DT_table).BeginInit();
            SuspendLayout();
            // 
            // DT_table
            // 
            DT_table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DT_table.Columns.AddRange(new DataGridViewColumn[] { TB_name, TB_id, TB_email, TB_phone, TB_avg });
            DT_table.Location = new Point(80, 31);
            DT_table.Margin = new Padding(3, 2, 3, 2);
            DT_table.Name = "DT_table";
            DT_table.RowHeadersWidth = 51;
            DT_table.RowTemplate.Height = 29;
            DT_table.Size = new Size(678, 355);
            DT_table.TabIndex = 0;
            DT_table.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TB_name
            // 
            TB_name.HeaderText = "Name";
            TB_name.MinimumWidth = 6;
            TB_name.Name = "TB_name";
            TB_name.Width = 125;
            // 
            // TB_id
            // 
            TB_id.HeaderText = "ID";
            TB_id.MinimumWidth = 6;
            TB_id.Name = "TB_id";
            TB_id.Width = 125;
            // 
            // TB_email
            // 
            TB_email.HeaderText = "Email";
            TB_email.MinimumWidth = 6;
            TB_email.Name = "TB_email";
            TB_email.Width = 125;
            // 
            // TB_phone
            // 
            TB_phone.HeaderText = "Phone";
            TB_phone.MinimumWidth = 6;
            TB_phone.Name = "TB_phone";
            TB_phone.Width = 125;
            // 
            // TB_avg
            // 
            TB_avg.HeaderText = "Average";
            TB_avg.MinimumWidth = 6;
            TB_avg.Name = "TB_avg";
            TB_avg.Width = 125;
            // 
            // UC_showTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DT_table);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UC_showTable";
            Size = new Size(847, 464);
            Load += UC_showTable_Load;
            ((System.ComponentModel.ISupportInitialize)DT_table).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DT_table;
        private DataGridViewTextBoxColumn TB_name;
        private DataGridViewTextBoxColumn TB_id;
        private DataGridViewTextBoxColumn TB_email;
        private DataGridViewTextBoxColumn TB_phone;
        private DataGridViewTextBoxColumn TB_avg;
    }
}
