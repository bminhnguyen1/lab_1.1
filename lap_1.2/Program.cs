using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("please enter number star: ");
        int countstar = int.Parse(Console.ReadLine());
        Console.WriteLine("result:");
        for (int i = 1; i <= countstar; i++)
        {
            PrintRow(countstar, i);
        }

        for (int i = countstar - 1; i >= 1; i--)
        {
            PrintRow(countstar, i);
        }


    }

    private static void PrintRow(int countstar, int i)
    {
        for (int j = 1; j <= countstar - i; j++) //tao khoan trang 
        {
            Console.Write(" ");
        }

        for (int j = 1; j <= i; j++) //in *
        {
            Console.Write("* ");
        }

        Console.WriteLine();
    }
}