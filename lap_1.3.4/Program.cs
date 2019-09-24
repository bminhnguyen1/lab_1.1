using System;
using System.Collections.Generic;
using System.Text;

namespace lap_1._3._3
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        private string FirstName
        {
            set
            {
                if (value.Length < 3) //nếu độ dài bé hơn 3 thì thông báo
                {
                    throw new ArgumentException("The first name length must be greater than 3 characters");
                }
                else
                {
                    this.firstName = value;
                }
            }
        }

        private string LastName
        {
            set
            {
                if (value.Length < 3) //nếu độ dài bé hơn 3 thì thông báo
                {
                    throw new ArgumentException("The last name length must be greater than 3 characters");
                }
                else
                {
                    this.lastName = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= 0) //tuoi phai lon hon 0
                {
                    throw new ArgumentException("Age cannot be zero or a negative integer!");
                }
                else
                {
                    this.age = value;
                }
            }
        }

        private decimal Salary
        {
            set
            {
                if (value < 460)    //salary must be lon hon 460 
                {
                    throw new ArgumentException("Salary must be greater than 460 !");
                }
                else
                {
                    this.salary = value;
                }
            }
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} receives {this.salary:F2} leva.";
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.age >= 30)
            {
                this.salary += this.salary * percentage / 100;
            }
            else
            {
                this.salary += this.salary * percentage / 200;
            }
        }
    }

    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam
        {
            get
            {
                return this.firstTeam;
            }
        }

        public IReadOnlyCollection<Person> ReserveTeam
        {
            get
            {
                return this.reserveTeam;
            }
        }

        public void AddPlayer(Person person)
        {
            if (person.Age < 40)
            {
                this.firstTeam.Add(person);
            }
            else
            {
                this.reserveTeam.Add(person);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number person");
            var lines = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter information as format: first name, last name, age, salary");
            var team = new Team("FRT");
            for (int i = 0; i < lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                                        cmdArgs[1],
                                        int.Parse(cmdArgs[2]),
                                        decimal.Parse(cmdArgs[3]));

                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");

            
            //var persons = new List<Person>();
            //Console.WriteLine("please enter information as format: first name, last name, age, salary");
            //for (int i = 0; i < lines; i++)
            //{
            //    var cmdArgs = Console.ReadLine().Split();
            //    try
            //    {
            //        var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]), decimal.Parse(cmdArgs[3]));
            //        persons.Add(person);
            //    }
            //    catch (ArgumentException ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            //Console.WriteLine("please enter percentage");
            //var percentage = decimal.Parse(Console.ReadLine());
            //persons.ForEach(p => p.IncreaseSalary(percentage));
            //persons.ForEach(p => Console.WriteLine(p.ToString()));

        }
    }
}
