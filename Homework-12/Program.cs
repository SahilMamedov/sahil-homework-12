using System;

namespace Homework_12
{
    class Program
    {
        static void Main(string[] args)
        {

            Student stu1 = new Student("sahil", "mamedov", 90, 25);
            Student stu2 = new Student("ugur", "eliyev", 99, 27);
            Student stu3 = new Student("orxan", "semedov", 98, 21);
            Student stu4 = new Student("ayaz", "imanov", 50, 35);

            Group group = new Group("AP313");
            group.AddStudent(stu1);
            group.AddStudent(stu2);
            group.AddStudent(stu3);
            group.AddStudent(stu4);

            group.GetAllStudents();
        }
    }
}
