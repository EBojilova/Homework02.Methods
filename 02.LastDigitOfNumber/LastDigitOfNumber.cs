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
        string[] units = {"zero", "one", "two", "thre", "four", "five", "six", "seven", "eight", "nine"};
        return units[n%10];
    }
}
