namespace Kata;

public class UniqueOrder
{
    public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
    {
        var list = new List<T>();
        T cache = default(T);

        foreach (var item in iterable)
        {
            if (!EqualityComparer<T>.Default.Equals(item, cache))
            {
                list.Add(item);
                cache = item;
            }
        }

        return list;

    }
}