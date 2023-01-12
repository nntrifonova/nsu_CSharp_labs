using System.ComponentModel.Design;

namespace lab_1_cs;
using System;
using System.Collections.Generic;
using System.IO;

public class Princess
{
    private  Hall halls;
    private static int numberOfContender = 0;
    private static Friend friend;
    private Contender nobody = new Contender(-1, "Nobody");
    
    public Princess(Hall hall_, int number)
    {
        halls = hall_;
        numberOfContender = number;
        friend = new Friend();
    }
    
    public Contender takeDesigion()
    {
        while (numberOfContender < 100)
        {
            Contender nextContender = halls.CallNext;
            if (numberOfContender > 4 && friend.Advicing(nextContender))
            {
                return nextContender;
            }
            else
            {
                numberOfContender++;
            }
        }
        return nobody;
    }

    
    
}