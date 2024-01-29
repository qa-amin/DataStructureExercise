namespace First_repeating
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Time : O(n) Space : O(n)
			string str = "responsible";

			var dic = new Dictionary<char, bool>();

			char? answer = null;
			
			foreach (var s in str)
			{
				if (dic.ContainsKey(s))
				{
					answer = s;
					break;
				}
				else
				{
					dic[s] = true;
				}
			}

			if (answer != null)
			{
				Console.WriteLine($"First Repeating Character is {answer}");
			}
			else
			{
				Console.WriteLine("There is No Repeating Character");
			}
		}
	}
}
