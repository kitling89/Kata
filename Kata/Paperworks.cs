namespace Kata;

public class Paperworks
{
    public static int Paperwork(int n, int m)
    {
        if (n <= 0 ||m <= 0)
            return 0;

        return n * m;
    }
}