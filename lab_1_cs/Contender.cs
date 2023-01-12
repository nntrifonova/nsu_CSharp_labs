namespace lab_1_cs;

public class Contender
{
    private string name;
    private int rating;
    
    
    public Contender(int currentRating, string currentName)
    {
        name = currentName;
        rating = currentRating;
    }

    public int getRate
    {

        get { return rating; }
    }

    public string GetName
    {

        get { return name; }
    }
}