using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LastDigitOfNumber
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var word = GetNumAsWord(n);
        Console.WriteLine(word);
    }

    private static string GetNumAsWord(int n)
    {
        string[] units = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        while (!(n >= 0 && n <= 9))
        {
            n %= 10;
        }
        return units[n];
    }
}
