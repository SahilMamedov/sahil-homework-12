using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Homework_12
{
    class Group
    {
        private static string _No { get; set; }
        public string NO { get; set; }

        //public string no
        //{
        //    get
        //    {
        //        return _No;
        //    }
        //    set
        //    {
        //        string str = "AP101";
        //        string digits = new string(value.Where(char.IsDigit).ToArray());
        //        string letters = new string(value.Where(char.IsLetter).ToArray());

        //        int number;
        //        if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
        //        {
        //            Console.WriteLine("Something weired happened");
        //        }

        //        value = letters + (++number).ToString();
        //        _No = value;

        //    }
        //}

       // private Student[] Students;
        
    public Group()
        {

            string No = "AP101";
            string digits = new string(No.Where(char.IsDigit).ToArray());
            string letters = new string(No.Where(char.IsLetter).ToArray());

            int number;
            if (!int.TryParse(digits, out number)) //int.Parse would do the job since only digits are selected
            {
                Console.WriteLine("Something weired happened");
            }

            No = letters + (++number).ToString();
            //  No =No + No;

           // _No = _No;
            NO = No; 
            //students = new Student[0];

           
        }

       private List<Student> Students = new List<Student>();
        public void AddStudent(Student student)
        {
            
            Students.Add(student);


        }
        public void GetAllStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------");
                Console.WriteLine();
                Console.WriteLine($"ID: {student.ID} \n" +
                    $"Name: {student._Name} \n" +
                    $"Surname: {student._SurName} \n" +
                    $"Point: {student._Point} \n" +
                    $"Age: {student._Age}");
            }
        }
        public List<Student> Sort()
        {

            List<Student> SortStudentList = Students.OrderBy(o => o._Point).ToList();
            foreach (Student student in SortStudentList)
            {
                Console.WriteLine();
                Console.WriteLine($"ID: {student.ID} \n" +
                    $"Name: {student._Name} \n" +
                    $"Surname: {student._SurName} \n" +
                    $"Age: {student._Age} \n" +
                    $"Point: {student._Point}");
            }
            
            return SortStudentList;
        }


    }
}
