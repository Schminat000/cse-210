using System;


namespace Unit02.Game
{
    public class Deck
    {
    public int value = 0;
    public int points = 0;
    public int previousValue = 0;

    public Deck()
    {
    }

    public int Card(int previousValue)
    {

        Random random = new Random();

        for (int i = 1; i < 13; i++)
            value = random.Next(1, 13);

        Console.Write("Higher or Lower? [h/l] ");
        string decision = Console.ReadLine();

        if (decision == "h")
            if (value >= previousValue)
                points = 100;
            else
                points = -75;
        else if (decision == "l")
            if (value <= previousValue)
                points = 100;
            else
                points = -75;
        else
            points = 0;


        return points;
    }
    }

}