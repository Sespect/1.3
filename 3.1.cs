using System;
using System.IO;
using System.Linq;
class Program
{
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");
        int[] chosenNumbers = lines[0].Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(lines[1]);
        using (StreamWriter outputFile = new StreamWriter("output.txt"))
        {
            for (int i = 0; i < n; i++)
            {
                int[] ticketNumbers = lines[i + 2].Split(' ').Select(int.Parse).ToArray();
                int matchingNumbers = ticketNumbers.Count(num => chosenNumbers.Contains(num));
                if (matchingNumbers >= 3)
                {
                    outputFile.WriteLine("Lucky");
                }
                else
                {
                    outputFile.WriteLine("Unlucky");
                }
            }
        }
    }
}