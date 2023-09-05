namespace Kata;

public class RGBtoHEX
{
    public static string Rgb(int r, int g, int b)
    {
        int red = Math.Clamp(r, 0, 255);
        int green = Math.Clamp(g, 0, 255);
        int blue = Math.Clamp(b, 0, 255);


        return $"{red:X2}{green:X2}{blue:X2}";
    }
}