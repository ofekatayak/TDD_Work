using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NuGet;
using TDD2;

namespace TDD2.Tests
{
    [TestClass()]
    public class StudentTests
    {
        //unit test for BubbleSort method
        //[TestMethod()]
        //public void bubbleSortArray()
        //{
        //    Student s1, s2, s3, s4;
        //    s1 = new Student("Ofek", "Atayak", "209529106", "ofek@gmail.com", "0527026913", 90);
        //    s2 = new Student("Matan", "Kalifa", "209542106", "matan@gmail.com", "0527016913", 82);
        //    s3 = new Student("Sahar", "Gabay", "201747106", "sahar@gmail.com", "0525369133", 85);
        //    s4 = new Student("Omer", "Cohen", "219285406", "omer@gmail.com", "052231613", 93);
        //    List<Student> array  = new List<Student>();
        //    array.Add(s1);
        //    array.Add(s2);
        //    array.Add(s3);
        //    array.Add(s4);
        //    List<Student> expected = new List<Student>();
        //    expected.Add(s2);
        //    expected.Add(s3);
        //    expected.Add(s1);
        //    expected.Add(s4);
        //    Student.bubbleSortArray(array);
        //    CollectionAssert.AreEqual(expected, array);
        //}

        //unit test for the better sort methood(quick sort)
        [TestMethod()]
        public void mergeSortTest()
        {
            Student s1, s2, s3, s4;
            s1 = new Student("Ofek", "Atayak", "209529106", "ofek@gmail.com", "0527026913", 90);
            s2 = new Student("Matan", "Kalifa", "209542106", "matan@gmail.com", "0527016913", 82);
            s3 = new Student("Sahar", "Gabay", "201747106", "sahar@gmail.com", "0525369133", 85);
            s4 = new Student("Omer", "Cohen", "219285406", "omer@gmail.com", "052231613", 93);
            List<Student> array = new List<Student>();
            array.Add(s1);
            array.Add(s2);
            array.Add(s3);
            array.Add(s4);
            List<Student> expected = new List<Student>();
            expected.Add(s4);
            expected.Add(s1);
            expected.Add(s3);
            expected.Add(s2);
            Student.mergeSort(array);
            CollectionAssert.AreEqual(expected, array);
        }

        //unit test for the average methood
        [TestMethod()]
        public void calculateAvarege() {
            int[] grades = new int[] { 100, 60, 70, 50, 80 };
            float avg , expectedAvg = 72;
            avg = Student.calculateAvarege(grades);
            Assert.AreEqual(expectedAvg, avg);
        }
    }
}