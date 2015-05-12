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
        bool isNegative=false;
        if (input[0] == '-')
        {
            isNegative = true;
        }
        char[] result = input.TrimStart('-').ToCharArray();
        Array.Reverse(result);
        double n = double.Parse(new string(result));
        return (isNegative ? -n : n);
    }
}
