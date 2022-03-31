using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Group
    {
        private string _No { get; set; }
        //public string No
        //{
        //    get
        //    {

        //    }
        //    set
        //    {
                
                
              
        //    }
        //}
        public int num { get; set; }
        private Student[] Students;
        public Group(string gropuNo)
        {
            _No = gropuNo;

           
            Students = new Student[0];


        }

        int a = 0;
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            {
                Students[a] = student;
                a++;
            }
                

        }
        public void GetAllStudents()
        {
            foreach (var item in Students)
            {
                Console.WriteLine($"ID: {item.ID} \n" +
                    $" Name: {item._Name} \n" +
                    $"Surname: {item._SurName} \n" +
                    $"Point: {item._Point} \n" +
                    $"Age: {item._Age}");
            }
        }


    }
}
