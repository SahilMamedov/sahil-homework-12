using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("Sahil", "Mamedov", 55, 24);
            Student stu2 = new Student("Ugur", "Eliyev", 67, 23);
            Student stu3 = new Student("Lorem", "Ipsum", 98, 21);
            Student stu4 = new Student("Mamed", "Mamedov", 50, 29);

            Console.WriteLine(stu1 < stu2);
            Console.WriteLine(stu1 > stu4);
            Console.WriteLine(stu3 > stu2);
            Console.WriteLine(stu1 < stu3);

            Group group = new Group();
            Group group2 = new Group();
            Group group3 = new Group();
            Console.WriteLine(group.NO);
            Console.WriteLine(group2.NO);
            Console.WriteLine(group3.NO);
           

            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.AddStudent(stu3);
            group.AddStudent(stu4);
            group.GetAllStudents();
            group.Sort();


           // Group group1 = new Group();
            //Console.WriteLine(group.NO);
           


           
        }
    }
}
