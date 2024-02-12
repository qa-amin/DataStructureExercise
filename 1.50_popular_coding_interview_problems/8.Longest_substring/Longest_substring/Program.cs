namespace Longest_substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdbeghef";

            int maxLength = 0;

            int start = 0;

            int[] indexes = new int[128];

            for (int i = 0; i < indexes.Length; i++)
            {
                indexes[i] = -1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                var asci = Convert.ToByte(str[i]);
                if (indexes[asci] >= start)
                {
                    start = indexes[asci] + 1;
                }

                indexes[asci] = i;

                maxLength = Math.Max(maxLength, i - start + 1);
            }

            Console.WriteLine($"Longest substring without repeating characters is {maxLength}");
        }
    }
}
