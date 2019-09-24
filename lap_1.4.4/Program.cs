using System;
using System.Collections.Generic;
using System.Text;

namespace lap_1._4._4
{
    class RandomList : List<string>
    {
        private Random random;

        public string RandomString()
        {
            int index = random.Next(0, this.Count);
            string element = this[index];
            this.RemoveAt(index);
            return element;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
