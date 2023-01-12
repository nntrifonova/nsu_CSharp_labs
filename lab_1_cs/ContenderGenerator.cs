using System;
using System.Collections.Generic;
using System.IO;
namespace lab_1_cs;

public class ContenderGenerator
{
    public List<int> rating = new List<int>();
    public List<string> princes = new List<string>();

    public ContenderGenerator(string path)
    {
        
        foreach (string line in File.ReadLines(path))
        {
            princes.Add(line);
        }
        for (int i = 1; i <= 100; i++)
        {
            rating.Add(i);
        }
    }

    public List<T> Shuffle<T>(List<T> list)
    {
        Random rand = new Random();
        
        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);

            var tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }

        return list;
    }

}    