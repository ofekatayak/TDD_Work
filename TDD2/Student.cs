using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD2
{
    public class Student
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public string ID { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public float avg { get; set; }
        public static List<Student> arrStudents = new List<Student>(); 
        public Student(string name, string lastName, string id, string email, string phone, float avg = 0, int[] grades = null)
        {

            this.name = name;
            this.lastName = lastName;
            this.ID = id;
            this.email = email;
            this.phone = phone;
            if (avg == 0)
            {
                this.avg = calculateAvarege(grades);
            }
            else
                this.avg = avg;
            
        }

        public static float calculateAvarege(int[] grades)
        {
            float sum = 0;
            for (int i = 0; i < grades.Length; i++)
                if (grades[i] != null)
                    sum += grades[i];
            return sum/grades.Length;
        }

        public string ToString()
        {
            return "Name: " + this.name + " " + this.lastName + "\n" + "id " + this.ID + "\n" + "email:" + this.email + "\n" + "Phone:"  +this.phone + "\n" +"Average:"+ this.avg + "\n";       

        }

        //public static void bubbleSortArray(List<Student> list) // bubble sort n^2
        //{
        //    for (int i = 0; i < list.Count; i++)
        //    {
        //        for (int j = i + 1; j < list.Count; j++)
        //        {
        //            if (list[i].avg > list[j].avg)
        //                swap(list,i, j);
        //        }
        //    }
        //}

        public static void mergeSort(List<Student> list) //quick sort nlogn
        {
            if (list.Count > 1)
            {
                int middleIndex = list.Count / 2;
                List<Student> leftList = list.GetRange(0, middleIndex);
                List<Student> rightList = list.GetRange(middleIndex, list.Count - middleIndex);
                mergeSort(leftList);
                mergeSort(rightList);   

                int i = 0 , j = 0 ,k = 0;
                while (i < leftList.Count && j < rightList.Count)
                {
                    if (leftList[i].avg > rightList[j].avg)
                    {
                        list[k] = leftList[i++];
                    }
                    else 
                    {
                        list[k] = rightList[j++];
                    }
                    k++;
                }

                while (i < leftList.Count)
                {
                    list[k] = leftList[i];
                    i++;
                    k++;
                }
                while (j < rightList.Count)
                {
                    list[k] = rightList[j];
                    j++;k++;
                }

            }
        }

        public static void swap(List<Student> list, int i, int j)
        {
            Student temp = list[j];
            list[j] = list[i];
            list[i] = temp;
        }
    }
}
