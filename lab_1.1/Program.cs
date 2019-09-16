using System;

namespace lab_1._1
{
    class BankAcoount
    {
        public int Id { get; private set; }
        public int Balance { get; private set; }

        private int id;
        private int balance;

        static void Main(string[] args)
        {
            BankAcoount acc = new BankAcoount();

            acc.Id = 1;
            acc.Balance = 15;

            Console.WriteLine($"Account {acc.Id}, balance {acc.Balance}");
        }
    }
}
