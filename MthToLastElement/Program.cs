using System.IO;
using System.Collections.Generic;
using System.Linq;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamReader reader = File.OpenText(args[0]))
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (null == line)
                    continue;

                var input = line.Split(' ');
                //Make sure we are at least getting 2 arguments on the line
                if (input.Length < 2) continue;

                //Split the line into input array and index (return if index is not a valid int)
                var array = input.Take(input.Length - 1);
                int index = 0;
                if (!int.TryParse(input[input.Length - 1], out index)) return;

                var output = FindMthChar(array, index);
                if (output.Length > 0) Console.WriteLine(output);
            }
    }

    private static string FindMthChar(IEnumerable<string> array, int index)
    {
        if (index > array.Count() || index < 0) return string.Empty;

        return array.ElementAt(array.Count() - index);
    }
}