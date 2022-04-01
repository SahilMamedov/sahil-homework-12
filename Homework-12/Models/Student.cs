using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_12
{
    class Student
    {
        private static int _Id { get; set; }
        public string _Name { get; set; }
        public string _SurName { get; set; }
        public int _Point { get; set; }
        public int _Age { get; set; }
        public int ID { get; set; }
        public Student(string name, string surname, int point, int age)
        {

            _Name = name;
            _SurName = surname;
            _Point = point;
            _Age = age;

            _Id++;

            ID = _Id;

        }
        public void ShowInfo()
        {
            Console.WriteLine($"Id: {_Id} Name: {_Name} Surname: {_SurName} Point: {_Point} Age: {_Age}");
        }

        public static bool operator >(Student stu1, Student stu2)
        {

           return stu1._Point > stu2._Point;

        }


        
        public static bool operator <(Student stu1, Student stu2)
        {

            return stu1._Point < stu2._Point;

        }



       

    }
}
