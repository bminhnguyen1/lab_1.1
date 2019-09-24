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
            string gradeComment = studentAssessment();

            return $"{name} is {age} years old. {gradeComment}";
        }

        private string studentAssessment()
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
                return "Not good student.";
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

        public void MenuCommand(string command)
        {

            var commandArray = command.Split(' ');
            Console.WriteLine(commandArray[0]);
            switch (commandArray[0])
            {
                case "Create":
                    AddStudent(commandArray);
                    break;
                case "Show":
                    ShowStudent(commandArray);
                    break;
                case "Exit":
                    Environment.Exit(0);
                    break;
            }
        }

        private void ShowStudent(string[] commandArray)
        {
            string name = commandArray[1];

            if (students.ContainsKey(name))
            {
                Student student = students[name];
                Console.WriteLine(student);
            }
        }

        private void AddStudent(string[] commandArray)
        {
            string name = commandArray[1];
            if (!students.ContainsKey(name))
            {
                int age = int.Parse(commandArray[2]);
                double grade = double.Parse(commandArray[3]);

                Student student = new Student(name, age, grade);
                students.Add(name, student);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem system = new StudentSystem();

            while (true)
            {
                Console.WriteLine("Please choose commamd u want to");
                Console.WriteLine("1. Create student");
                Console.WriteLine("2. SHow student");
                int choosecommand = Int32.Parse(Console.ReadLine());
                switch (choosecommand)
                {
                    case 1:
                        Console.WriteLine("Please enter like fomat: Create Name Age Grade");
                        break;
                    case 2:
                        Console.WriteLine("Please enter like format: Show Name");
                        break;
                }
                string command = Console.ReadLine();
                system.MenuCommand(command);
            }
        }
    }

}