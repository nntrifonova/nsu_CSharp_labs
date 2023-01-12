using System.Text.Json.Nodes;

namespace lab_1_cs;

public class Friend
{
    private static Contender currentBest = new Contender(0,"");
    
    public bool Advicing(Contender currentContender)
    {
        if (currentContender.getRate > currentBest.getRate)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}