namespace Kata;

public class Walk
{
    public static bool IsValidWalk(string[] walk)
    {
        if (walk.Length  != 10) { return false; }

        int horizontal = 0;
        int vertical = 0;

        foreach (string dir in walk)
        {
            switch (dir)
            {
                case "n":
                    vertical += 1;
                    break;
                case "s": 
                    vertical -= 1;
                    break;
                case "e":
                    horizontal += 1;
                    break;
                case "w":
                    horizontal -= 1;
                    break;
                }
        }

        return horizontal == 0 && vertical == 0;
    }
}