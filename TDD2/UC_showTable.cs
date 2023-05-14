using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDD2
{
    public partial class UC_showTable : UserControl
    {
        public UC_showTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void showTableData()
        {
            float before =  DateTime.Now.Millisecond;
            Student.mergeSort(Student.arrStudents);
            float after = DateTime.Now.Millisecond; 
            float runTime = after - before;
            MessageBox.Show("" + runTime);
            for (int i = 0; i < Student.arrStudents.Count; i++)
            {
                Student s = Student.arrStudents[i];
                DT_table.Rows.Add(s.name + " " + s.lastName, s.ID, s.email, s.phone, s.avg.ToString());
            }

        }

        

        private void UC_showTable_Load(object sender, EventArgs e)
        {

        }
    }
}
