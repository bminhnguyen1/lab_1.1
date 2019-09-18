using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_AdvancedProgramming
{
    class BankAccount
    {
        private int id;
        private decimal balance;

        public int Id;
        public decimal Balance;

        public BankAccount(int id)
        {
            Id = id;
        }

        public BankAccount(int id, decimal balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount) //action deposit amount to account
        {
            if (amount < 0)
            {
                Console.WriteLine("The amount is not valid. Amount must be greater than 0");
            }
            else Balance = Balance + amount;
        }

        public void Withdraw(decimal amount) //action withdraw amount to account
        {
            if (amount > Balance) //so tien can rut phai nho hon so du trong account
            {
                Console.WriteLine("Can't withdraw, The amount in the account is not enough");
            }
            else if (amount < 0) //so tien rut phai la so duong
            {
                Console.WriteLine("amount withdraw must greatew than 0");
            }
            else Balance = Balance - amount;
        }

        public override string ToString()
        {
            Console.WriteLine("Id: {0}", Id);
            Console.WriteLine("Balance: {0}", Balance);
            return base.ToString();
        }

        public void Print(int id)
        {

        }
    }

    class Person
    {
        string name;
        int age;
        List<BankAccount> accounts;

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public Person(string n, int a, List<BankAccount> acc)
        {
            name = n;
            age = a;
            accounts = acc;
        }

        public decimal GetBalance()
        {
            decimal sum;
            sum = accounts.Sum(x => x.Balance);
            return sum;
        }
    }
    class Program
    {
        List<BankAccount> accounts;
        public Program()
        {
            accounts = new List<BankAccount>();
        }

        public bool IsIdExists(int id)
        {

            return accounts.Exists(x => x.Id == id);
        }

        public void AddBankAccount(int id)
        {
            accounts.Add(new BankAccount(id));
        }
        static void Main(string[] args)
        {
            
            Program myProgram = new Program();

            Console.WriteLine("please choose action you want to do");
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Print");
            Console.WriteLine("5. End");

            Console.Write("Enter your command: ");
            int chooseMenu = Convert.ToInt32(Console.ReadLine());
            int chooseId;
            int chooseAmount;
            Console.WriteLine("Command: {0}", chooseMenu);
            while (chooseMenu != 5)
            {
                if (chooseMenu > 5 || chooseMenu < 0)
                {
                    Console.WriteLine("Invalid command");

                }
                else
                {
                    switch (chooseMenu)
                    {
                        case 1:                                                         //create account
                            Console.WriteLine("Please enter ID account:");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account already exists...");
                            }
                            else
                            {
                                Console.WriteLine("Account created successfully...");

                                myProgram.AddBankAccount(chooseId);
                            }
                            break;
                        case 2:                                                         //deposit money
                            Console.Write("Please enter ID account: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Deposit(chooseAmount);
                                Console.WriteLine("After deposit");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 3:                                                        //withdraw money
                            Console.Write("Please enter ID account: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Please enter amount: ");
                            chooseAmount = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).Withdraw(chooseAmount);
                                Console.WriteLine("After withdraw");
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;                                                   //show information account
                        case 4:
                            Console.Write("Please enter ID account: ");
                            chooseId = Convert.ToInt32(Console.ReadLine());
                            if (!myProgram.IsIdExists(chooseId))
                            {
                                Console.WriteLine("Account does not exist");
                            }
                            else
                            {
                                myProgram.accounts.Find(x => x.Id == chooseId).ToString();
                            }
                            break;
                        case 5: break;
                        default:
                            break;
                    }
                    if (chooseMenu == 5) break;
                }
                Console.Write("Enter your command: ");
                chooseMenu = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("END PROGRAM");

            List<BankAccount> listAccounts = new List<BankAccount>();
            listAccounts.Add(new BankAccount(1, 10));
            listAccounts.Add(new BankAccount(2, 10));
            listAccounts.Add(new BankAccount(3, 10));
            listAccounts.Add(new BankAccount(4, 10));
            listAccounts.Add(new BankAccount(5, 10));

            Person myPerson = new Person("Peter", 10, listAccounts);

            Console.WriteLine("Sum: {0}", myPerson.GetBalance());


            Console.Read();



        }
    }
}