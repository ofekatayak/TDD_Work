using System.Data;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using System.Diagnostics.Eventing.Reader;

namespace TDD2
{
    public partial class Home : Form
    {
        Font LargeFont = new Font("Arial", 25);

        public Home()
        {
            InitializeComponent();
            uC_addStudent1.Hide();
            uC_showTable1.Hide();
        }
        private bool checkLimits(int num)
        {
            if (num < 0 || (num > 100 && num != 777))
            {
                return false;

            }
            return true;
        }
        private void invalidGrade(bool x, string s)
        {
            if (!x)
            {
                MessageBox.Show("invalid grade in grade " + s);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Btn_home_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }


        private void uC_addStudent1_Load(object sender, EventArgs e)
        {

        }



        private void labe_addStudent_Click(object sender, EventArgs e)
        {
            uC_addStudent1.Show();
            uC_addStudent1.BringToFront();
        }

        private void lable_addRandom_Click(object sender, EventArgs e)
        {
            string[] namesArr = new string[] {"Matan","Ofek","Soli","Kobi","Tamar","Omer","Eti",
            "Fhatma","Joni","Rahcel","Hai","Lir","Linoy","Patrik","Loei","Osher","Yohai","Astar","Eden"};

            string[] lastNamesArr = new string[] {"Kalifa","Atayak","Coheck","Gabay","Sabag","Levi","Kadosh",
            "Jalabia","Amitay","Bargil","Maimon","Pinker","Panker","Karlokker","Woof","Alon","Ohayon","Malul","Gueta"};


            List<Student> rndStudents = new List<Student>();
            for (int i = 0; i < 10000; i++)
            {
                //rnd id
                Random rnd = new Random();
                int randomId = rnd.Next(100000000, 999999999);

                //rnd phone
                Random rndString = new Random();
                string rndPhone = "";
                for (int j = 0; j <= 10; j++)
                    rndPhone += rndString.Next(0, 9).ToString();

                //rnd name 
                int rndNameIndex = rnd.Next(namesArr.Length);
                int rndLastIndex = rnd.Next(lastNamesArr.Length);
                string rndName = namesArr[rndNameIndex];
                string rndLastName = lastNamesArr[rndLastIndex];
                string rndFullName = rndName + rndLastName;

                //rndEmail
                string rndEmail = rndFullName + "@gmail.com";

                // rand average
                float rndAverage = rnd.Next(40, 100);
                Student newStudent = new Student(rndName, rndLastName, randomId.ToString(), rndEmail, rndPhone, rndAverage);
                Student.arrStudents.Add(newStudent);
            }


        }

        private void label_showTable_Click(object sender, EventArgs e)
        {
            uC_addStudent1.Hide();
            uC_showTable1.Show();   
            uC_showTable1.BringToFront(); 
            uC_showTable1.showTableData();
        }

        
    }



}