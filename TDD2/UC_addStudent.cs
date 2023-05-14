using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TDD2
{
    public partial class UC_addStudent : UserControl
    {
        

        public UC_addStudent()
        {
            InitializeComponent();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttn_insert_Click(object sender, EventArgs e)
        {
            int[] grades = new int[5];


            string name = TB_name.Text;
            string last = TB_lastName.Text;
            string phone = TB_Phone.Text;
            string id = TB_ID.Text;
            string email = TB_email.Text;
            if (name == "" || last == "" || phone == "" || id == "" || email == "")
            {
                MessageBox.Show("All Student details are requierd!");
                return;
            }

            string grade1 = TB_g1.Text;
            string grade2 = TB_g2.Text;
            string grade3 = TB_g3.Text;
            string grade4 = TB_g4.Text;
            string grade5 = TB_g5.Text;


            // valid not empty
            if (grade1 != "" && grade2 != "" && grade3 != "" &&  grade4 != "" && grade5 != "")
            {
                if (validGrades(grade1) && validGrades(grade2) && validGrades(grade3) &&
                     validGrades(grade4) && validGrades(grade5))
                {
                    grades[0] = int.Parse(grade1);
                    grades[1] = int.Parse(grade2);
                    grades[2] = int.Parse(grade3);
                    grades[3] = int.Parse(grade4);
                    grades[4] = int.Parse(grade5);
                }
                else return;
            }
            else 
            {
                MessageBox.Show("All Student grades are requierd!");
                return;
            }
            


            Student s = new Student(name, last, id, email, phone,0, grades);

            bool isValid = validFields(s);
            if (isValid)
            {
                Student.arrStudents.Add(s); 
                MessageBox.Show(s.ToString()+" added succsefully!");
            }

        }

        public bool validID_PHONE(string id, int num, string msg)
        {
            int numDigits = id.Count(c => Char.IsDigit(c));
            int n;
            if (int.TryParse(id, out n) && numDigits == num)
                return true;

            MessageBox.Show(msg + " not valid!");
            return false;
        }

        public bool validLetters(string name)
        {
            int numDigits = name.Count(c => Char.IsDigit(c));

            if (numDigits != 0)
            {
                MessageBox.Show("NAME contain only letters!");
                return false;
            }

            return true;

        }

        public bool validEmail(string email)
        {
            if(email.Contains("@") && email.IndexOf("@") != 0 && email.IndexOf("@") != email.Length -1)
                return true;    

            MessageBox.Show("email not valid!");
            return false;
        }

        public bool validFields(Student student)
        {
            //valid name
            bool isNameValid = validLetters(student.name);
            bool isLastNameValid = validLetters(student.lastName);
            bool isIDValid = validID_PHONE(student.ID, 9, "ID");
            bool isPhoneValid = validID_PHONE(student.phone, 10, "PHONE");
            bool isEmailValid = validEmail(student.email);

            if (isEmailValid &&isNameValid && isLastNameValid && isIDValid && isPhoneValid)
                return true;

            return false;
        }
        private bool validGrades(string num)
        {
            int numDigits = num.Count(c => Char.IsDigit(c));
            // valid only digits
            if (numDigits == num.Length)
            {
                int parseNum = int.Parse(num);
                if (parseNum < 0 || (parseNum > 100 && parseNum != 777))
                {
                    MessageBox.Show("grade must be in range(0-100) or 777");
                    return false;

                }
                return true;
            }
            MessageBox.Show("grade contain only digits");
            return false;
           
        }
    }
}
