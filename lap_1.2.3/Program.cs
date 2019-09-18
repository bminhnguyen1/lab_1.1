using System;
using System.Collections.Generic;
using System.Text;

namespace lap_1._2._3
{
    class Student
    {
        private string name;
        private int age;
        private double grade;

        public Student(string name, int age, double grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public override string ToString()
        {
            string gradeComment = GetGradeComment();

            return $"{name} is {age} years old. {gradeComment}";
        }

        private string GetGradeComment()
        {
            if (grade >= 8)
            {
                return "Excellent student.";
            }
            else if (grade >= 6.5)
            {
                return "Advanced students.";
            }
            else if (grade >= 5)
            {
                return "Average student.";
            }
            else
            {
                return "Very nice person.";
            }
        }
    }
    class StudentSystem
    {
        private Dictionary<string, Student> students;

        public StudentSystem()
        {
            this.students = new Dictionary<string, Student>();
        }

        public void ParseCommand(string command)
        {
            var commandArgs = command.Split();

            switch (commandArgs[0])
            {
                case "Create":
                    AddStudent(commandArgs);
                    break;
                case "Show":
                    ShowStudent(commandArgs);
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }

        private void ShowStudent(string[] commandArgs)
        {
            string name = commandArgs[1];

            if (students.ContainsKey(name))
            {
                Student student = students[name];
                Console.WriteLine(student);
            }
        }

        private void AddStudent(string[] commandArgs)
        {
            string name = commandArgs[1];
            if (!students.ContainsKey(name))
            {
                int age = int.Parse(commandArgs[2]);
                double grade = double.Parse(commandArgs[3]);

                Student student = new Student(name, age, grade);
                students.Add(name, student);
            }
        }
    }


}