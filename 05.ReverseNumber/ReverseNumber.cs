using System;

class ReverseNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var n = ReversedNum(input);
        Console.WriteLine(n);
    }

    private static double ReversedNum(string input)
    {
        char[] num = input.ToCharArray();
        Array.Reverse(num);
        double n = double.Parse(new string(num));
        return n;
    }
}
