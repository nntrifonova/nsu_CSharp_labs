// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace lab_1_cs;

class Program
{
    private static void Main()
    {
    var cg = new ContenderGenerator("Men.txt");
    var rate = cg.Shuffle(cg.rating);
    var name = cg.Shuffle(cg.princes);

    var hall = new Hall(name, rate);
    var princess = new Princess(hall, 0);

    var husbant = princess.takeDesigion();
    var husbantIndex = husbant.getRate;
    if (husbantIndex >= 50)
    {
        Console.WriteLine("Имя: {0}  Рейтинг: {1}  ",  husbant.GetName, husbantIndex);

    }
    else if (husbantIndex == -1)
    {
        husbantIndex = 10;
        Console.WriteLine("Single and happy {0}", husbantIndex );

    }
    else
    {
        husbantIndex = 0;
        Console.WriteLine("Имя: {0}  Рейтинг: {1}  ",  husbant.GetName, husbantIndex);

    }
    }

}
