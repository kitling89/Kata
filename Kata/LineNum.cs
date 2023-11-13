namespace Kata
{
    public class LineNum
    {
        public static List<string> Number(List<string> lines)
        {
            return lines.Select((item, index) => $"{index + 1}: {item}").ToList();
        }
    }
}