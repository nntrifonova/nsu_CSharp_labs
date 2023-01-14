using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace lab_2;

public class ContenderGenerator
{
    public List<int> rating = new List<int>();
    public List<string> princes = new List<string>();
    public List<Contender> guests = new List<Contender>();

    public void CreateContenders()
    {
        foreach (string line in File.ReadLines("Men.txt"))
        {
            princes.Add(line);
        }
        for (int i = 1; i <= 100; i++)
        {
            rating.Add(i);
        }
    }
    public List<Contender> InviteAllGuests()
    {
        for (int i = 0; i <= 99; i++)
        {
            var prince = new Contender(this.rating[i], this.princes[i]);
            guests.Add(prince);
        }

        return guests;
    }

    public void Shuffle<T>(List<T> list)
    {
        Random rand = new Random();

        for (int i = list.Count - 1; i >= 1; i--)
        {
            int j = rand.Next(i + 1);

            var tmp = list[j];
            list[j] = list[i];
            list[i] = tmp;
        }
    }

}    