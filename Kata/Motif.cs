namespace Kata;

public class Motif
{
    public static int[] DeleteNth(int[] arr, int x)
    {
        foreach (int i in arr)
        {
            
            int sum = 0;
            while (sum < x)
            {
                if (arr[i] == arr[i + 1])
                    sum++;
                else
                {
                    
                }
            }
        }

    }
}