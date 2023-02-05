using System;

public class Linq
{
	public Linq()
	{
		readString();
	}

	public void readString()
    {
		string s = "Hello, my name is so and so";
		IEnumerable<char> lst = s.Where(c => c == 'o');
		/** Where is Filter
		 * */
		List<char> lst2 = s.Where(c => c == 'o').ToList();
		int count = lst.Count();
		int count2 = lst2.Count();
		Console.WriteLine(count);

		/** Select is Map */
		s.Select(c => c + " ");
    }
}
