using System;
using System.Collections.Generic; //can de su dung list<>
using System.Linq;      //can de su dung order by, then by,...

namespace lap_1._3._1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
        }

        public override string ToString()  //override cho phep ghi de du lieu len lop cha
        {
            return $"{this.FirstName} {this.lastName} is {this.Age} years old.";
        }
    }
    class Program
    {
        static void Main()
        {
            Console.WriteLine("please enter number person");
            var lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            Console.WriteLine("please enter information as format: first name, last name, age");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                persons.Add(person);
            }
            Console.WriteLine("please chose active 1 if u want to show all information");
            int c = int.Parse(Console.ReadLine());
            if (c == 1)
            {
                persons.OrderBy(p => p.FirstName)
                       .ThenBy(p => p.Age)
                       .ToList()
                       .ForEach(p => Console.WriteLine(p.ToString()));
            }
        }

    }
}
