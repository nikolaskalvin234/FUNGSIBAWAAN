using System;

namespace fungsi_bawaan
{
    class Program
    {
        static void Main(string[] args)
        {
        int x, y;
        x = 10;
        y = 15;
        int sum = Add(x,y);
            Console.WriteLine($"Sum is {sum}");
            Console.ReadKey();

        }
static int Add(int a, int b)
{
    int sum = a + b;
    return sum;
}
    }
}