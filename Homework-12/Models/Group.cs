using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework_12
{
    class Group
    {
        private static string _No = "AP101";
        public string NO { get; set; }

        //private int No = 101;      2-ci variant
        public static int Num { get; set; }
        public Group()
        {

            // Console.WriteLine($"AP{ No++}");   2-ci variant


            string digits = new string(_No.Where(char.IsDigit).ToArray());
            string letters = new string(_No.Where(char.IsLetter).ToArray());

            int number;
            int.TryParse(digits, out number);

            Num++;

            _No = letters + (++number).ToString();
            number += Num;
         
              NO = _No;


            
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
        }      //  sort elemekcun arashdirma link
               //   https://www.codegrepper.com/code-examples/csharp/c%23+how+to+sort+a+list+by+property


        public List<Student> Sort()
        {

            List<Student> SortStudentList = Students.OrderBy(student => student._Point).ToList();
            Console.WriteLine();
            Console.WriteLine("Sort olunmush Array");
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
