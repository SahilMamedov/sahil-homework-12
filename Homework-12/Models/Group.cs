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
        private static int _No = 101;
        public string NO { get; set; }

        

    public Group()
        {

            Console.WriteLine($"AP{ _No++}");
           

           
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
