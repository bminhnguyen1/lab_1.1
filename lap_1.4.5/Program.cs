using System;
using System.Collections.Generic;
using System.Text;

namespace lap_1._4._5
{
    class StackOfStrings
    {
        private List<string> data;

        public void Push(string item)
        {
            data.Add(item);
        }

        public string Pop()
        {
            string item = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return item;
        }

        public string Peek()
        {
            return data[data.Count - 1];
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
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
